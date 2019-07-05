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
                if (loggedInMember.BudgetList.Count == 0)
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
            Budget budget = _context.Budgets.Where(c => c.MemberId == id).Single();
            budget.BillList = _context.Bills.ToList();
            budget.GoalList = _context.Goals.ToList();
            budget.ExpenseList = _context.Expenses.ToList();
            budget.IncomeList = _context.Incomes.ToList();
            await _context.SaveChangesAsync();
            return View(budget);
        }
        public IActionResult CreateIncome(int id)
        {
            Income income = new Income();
            return View(income);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateIncome(int id, Income income)
        {
            income.Id = 0;
            income.BudgetId = id;
            _context.Incomes.Add(income);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UpdateIncome(int id, Income oldIncome)
        {
            Income income = _context.Incomes.Where(c => c.Id == id).Single();
            income = oldIncome;
            int budgetId = income.BudgetId.Value;
            _context.SaveChanges();
            return RedirectToAction("SeeBudget", new { budgetId });
        }
        public IActionResult CreateBill(int id)
        {
            Bill bill = new Bill();
            return View(bill);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBill(int id, Bill bill)
        {
            bill.Id = 0;
            bill.BudgetId = id;
            _context.Bills.Add(bill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UpdateBill(int id, Bill oldbill)
        {
            Bill bill = _context.Bills.Where(c => c.Id == id).Single();
            bill = oldbill;
            int budgetId = bill.BudgetId.Value;
            _context.SaveChanges();
            return RedirectToAction("SeeBudget", new { budgetId });
        }
        public IActionResult CreateGoal(int id)
        {
            Goal goal= new Goal();
            return View(goal);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateGoal(int id, Goal goal)
        {
            goal.Id = 0;
            goal.BudgetId = id;
            _context.Goals.Add(goal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UpdateGoal(int id, Goal oldGoal)
        {
            Goal goal = _context.Goals.Where(c => c.Id == id).Single();
            goal = oldGoal;
            int budgetId = goal.BudgetId.Value;
            _context.SaveChanges();
            return RedirectToAction("SeeBudget", new { budgetId });
        }
        public IActionResult CreateExpense(int id)
        {
            Expense expense = new Expense();
            return View(expense);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateExpense(int id, Expense expense)
        {
            expense.Id = 0;
            expense.BudgetId = id;
            _context.Expenses.Add(expense);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UpdateExpense(int id, Expense oldexpense)
        {
           Expense expense = _context.Expenses.Where(c => c.Id == id).Single();
            expense = oldexpense;
            int budgetId = expense.BudgetId.Value;
            _context.SaveChanges();
            return RedirectToAction("SeeBudget", new { budgetId });
        }
        public async Task<IActionResult> Calculate(int id)
        {
            Budget budget = _context.Budgets.Where(c => c.Id == id).Single();
            _memberService.GetNetIncome(budget);
            _memberService.DeductBills(budget);
            _memberService.DeductGoals(budget);
            _memberService.DivideRemainder(budget);
            return RedirectToAction("SeeBudget", new { id });
        }
    }
}