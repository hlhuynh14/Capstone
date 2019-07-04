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
        private readonly MemberLogic memberLogics;
        

        public MemberController(ApplicationDbContext context, MemberLogic memberLogic)
        {
            _context = context;
            memberLogics = memberLogic;
          
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
                try
                {
                // TODO: Add insert logic here
                _context.Add(member);
                _context.SaveChanges();
    
                return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }

            // GET: Member/Edit/5
            public ActionResult Edit(int id)
            {
                return View();
            }

            // POST: Member/Edit/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Edit(int id, IFormCollection collection)
            {
                try
                {
                    // TODO: Add update logic here

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }

            // GET: Member/Delete/5
            public ActionResult Delete(int id)
            {
                return View();
            }

            // POST: Member/Delete/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Delete(int id, IFormCollection collection)
            {
                try
                {
                    // TODO: Add delete logic here

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
    }
    }