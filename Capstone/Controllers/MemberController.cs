using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Application;
using Domain;
using Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Capstone.Controllers
{
    public class MemberController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly IMemberService _memberService;


        public MemberController(ApplicationDbContext context, IMemberService memberService)
        {
            _context = context;
            _memberService = memberService;
        }
        // GET: Member
        public async Task<IActionResult> Index()
        {

            var loggedInMember = GetLoggedInMember();
            if (loggedInMember == null)
            {
                return RedirectToAction(nameof(Create));
            }
            else
            {
                loggedInMember.BudgetList = _context.Budgets.ToList();
                await _context.SaveChangesAsync();
                if (loggedInMember.BudgetList == null)
                {
                    int id = loggedInMember.Id;
                    return RedirectToAction("CreateBudget", new {id});
                }
                return View(loggedInMember);
            }
        }

        // GET: Member/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Member/Create
        public async Task<IActionResult> Create()
        {
            Member member = new Member();
            return View(member);
        }

        // POST: Member/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Member member)
        {

            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                member.ApplicationId = userId;
                _context.Add(member);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }

        // GET: Member/Edit/5
        public async Task<IActionResult> Update(Member member)
        {
            return View();
        }

        // POST: Member/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(string id, Member member)
        {
            try
            {
                // TODO: Add update logic here
                var currentMember = _context.Members.Where(c => c.ApplicationId == id).Single();
                currentMember.FirstName = member.FirstName;
                currentMember.LastName = member.LastName;
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public Member GetLoggedInMember()
        {
            var currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInMember = _context.Members.SingleOrDefault(b => b.ApplicationId == currentUserId);
            return loggedInMember;
        }
        //Budget
        public IActionResult CreateBudget(int id)
        {
            Budget budget = new Budget();
            return View(budget);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBudget(int id, Budget budget)
        {
            budget.Id = 0;
            budget.MemberId = id;
            _context.Budgets.Add(budget);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> SeeBudget(int id)
        {
            Budget budget = _context.Budgets.Where(c => c.Id == id).Single();
            return View(budget);
        }
    }
}