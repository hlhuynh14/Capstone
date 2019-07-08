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
            var taxList = _context.Taxes.ToList();
            var loggedInMember = GetLoggedInMember();
            if (loggedInMember == null)
            {
                return RedirectToAction(nameof(Create));
            }
            if (taxList.Count == 0)
            {
                loggedInMember.BudgetList = _context.Budgets.ToList();
                await _context.SaveChangesAsync();
                if (loggedInMember.BudgetList.Count == 0)
                {
                    int id = loggedInMember.Id;
                    return RedirectToAction("CreateBudget", new { id });
                }
                return View(loggedInMember);

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
                return RedirectToAction("Index2", new { loggedInMember });
            }
        }
        public async Task<IActionResult> Index2()
        {
            var member = GetLoggedInMember();
            member.TaxList = _context.Taxes.ToList();
            member.BudgetList = _context.Budgets.ToList();
            await _context.SaveChangesAsync();
            return View(member);
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
                _context.SaveChanges();
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
        public async Task<IActionResult> SeeBudget(int? id)
        {
            Budget budget = _context.Budgets.Where(c => c.MemberId == id).Single();
            budget.BillList = _context.Bills.ToList();
            budget.GoalList = _context.Goals.ToList();
            budget.ExpenseList = _context.Expenses.ToList();
            budget.IncomeList = _context.Incomes.ToList();
            await _context.SaveChangesAsync();
            return View(budget);
        }
        //Incomes
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
            _context.Incomes.Add(income);
            await _context.SaveChangesAsync();
            return RedirectToAction("SeeBudget", new { id });
        }
        public async Task<IActionResult> UpdateIncome(int id)
        {
            Income income = _context.Incomes.Where(c => c.Id == id).Single();

            return View(income);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateIncome(int id, Income newIncome)
        {
            Income income = _context.Incomes.Where(c => c.Id == id).Single();
            income.Name = newIncome.Name;
            income.Amount = newIncome.Amount;
            int? budgetId = income.BudgetId;
            Budget budget = _context.Budgets.Where(c => c.Id == budgetId).Single();
            _context.SaveChanges();
            id = budget.MemberId.Value;
            return RedirectToAction("SeeBudget", new {id});
        }
        public async Task<IActionResult> DeleteIncome(int? id)
        {
            Income income = _context.Incomes.Where(c => c.Id == id).Single();

            return View(income);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteIncome(int id)
        {
            Income income = _context.Incomes.Where(c => c.Id == id).Single();
            _context.Remove(income);
            int? budgetId = income.BudgetId;
            Budget budget = _context.Budgets.Where(c => c.Id == budgetId).Single();
            _context.SaveChanges();
            id = budget.MemberId.Value;
            return RedirectToAction("SeeBudget", new { id });
        }
        //Bills
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
            _context.Bills.Add(bill);
            await _context.SaveChangesAsync();
            return RedirectToAction("SeeBudget", new { id });
        }
        public async Task<IActionResult> UpdateBill(int id)
        {
           Bill bill = _context.Bills.Where(c => c.Id == id).Single();

            return View(bill);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateBill(int id, Bill newBill)
        {
            Bill bill = _context.Bills.Where(c => c.Id == id).Single();
            bill.Name = newBill.Name;
            bill.Amount = newBill.Amount;
            int? budgetId = bill.BudgetId;
            Budget budget = _context.Budgets.Where(c => c.Id == budgetId).Single();
            _context.SaveChanges();
            id = budget.MemberId.Value;
            return RedirectToAction("SeeBudget", new { id });
        }
        public async Task<IActionResult> DeleteBill(int? id)
        {
            Bill bill = _context.Bills.Where(c => c.Id == id).Single();

            return View(bill);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteBill(int id)
        {
            Bill bill = _context.Bills.Where(c => c.Id == id).Single();
            _context.Remove(bill);
            int? budgetId = bill.BudgetId;
            Budget budget = _context.Budgets.Where(c => c.Id == budgetId).Single();
            _context.SaveChanges();
            id = budget.MemberId.Value;
            return RedirectToAction("SeeBudget", new { id });
        }
        //Goals
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
            id = goal.Id;
            return RedirectToAction("CalculateGoal", new { id });
        }
        public async Task<IActionResult> CalculateGoal(int id)
        {
            Goal goal = _context.Goals.Where(c => c.Id == id).Single();
            _memberService.CalculateLoan(goal);
            _memberService.EstimatedGoalSavings(goal);
            return View(goal);
        }
        public async Task<IActionResult> UpdateGoal(int id)
        {
            Goal goal = _context.Goals.Where(c => c.Id == id).Single();

            return View(goal);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateGoal(int id, Goal newGoal)
        {
            Goal goal = _context.Goals.Where(c => c.Id == id).Single();
            goal.Name = newGoal.Name;
            goal.GoalSavingsPerMonth = newGoal.GoalSavingsPerMonth;
            goal.GoalsSavings = newGoal.GoalsSavings;
            goal.InterestRate = newGoal.InterestRate;
            goal.MonthGoals = newGoal.MonthGoals;
            goal.LoanTermInYears = newGoal.LoanTermInYears;
            int? budgetId = goal.BudgetId;
            Budget budget = _context.Budgets.Where(c => c.Id == budgetId).Single();
            _context.SaveChanges();
            id = budget.MemberId.Value;
            return RedirectToAction("SeeBudget", new { id });
        }
        public async Task<IActionResult> DeleteGoal(int? id)
        {
            Goal goal = _context.Goals.Where(c => c.Id == id).Single();

            return View(goal);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteGoal(int id)
        {
            Goal goal = _context.Goals.Where(c => c.Id == id).Single();
            _context.Remove(goal);
            int? budgetId = goal.BudgetId;
            Budget budget = _context.Budgets.Where(c => c.Id == budgetId).Single();
            _context.SaveChanges();
            id = budget.MemberId.Value;
            return RedirectToAction("SeeBudget", new { id });
        }
        //Expenses
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
            _context.Expenses.Add(expense);
            await _context.SaveChangesAsync();
            return RedirectToAction("SeeBudget", new {id });
        }
        public async Task<IActionResult> UpdateExpense(int id)
        {
            Expense expense = _context.Expenses.Where(c => c.Id == id).Single();

            return View(expense);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateExpense(int id, Expense newExpense)
        {
            Expense expense = _context.Expenses.Where(c => c.Id == id).Single();
            expense.Name = newExpense.Name;
            expense.Percent = newExpense.Percent;
            int? budgetId = expense.BudgetId;
            Budget budget = _context.Budgets.Where(c => c.Id == budgetId).Single();
            _context.SaveChanges();
            id = budget.MemberId.Value;
            return RedirectToAction("SeeBudget", new { id });
        }
        public async Task<IActionResult> DeleteExpense(int? id)
        {
            Expense expense = _context.Expenses.Where(c => c.Id == id).Single();

            return View(expense);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteExpense(int id)
        {
            Expense expense = _context.Expenses.Where(c => c.Id == id).Single();
            _context.Remove(expense);
            int? budgetId = expense.BudgetId;
            Budget budget = _context.Budgets.Where(c => c.Id == budgetId).Single();
            _context.SaveChanges();
            id = budget.MemberId.Value;
            return RedirectToAction("SeeBudget", new { id });
        }
        //Overall
        public async Task<IActionResult> Calculate(int id)
        {
            Budget budget = _context.Budgets.Where(c => c.Id == id).Single();
            _memberService.GetNetIncome(budget);
            _memberService.DeductBills(budget);
            _memberService.DeductGoals(budget);
            _memberService.DivideRemainder(budget);
            return RedirectToAction("SeeBudget", new { id });
        }
        //Tax
        public IActionResult CreateTax(int id)
        {
            Tax tax = new Tax();
            return View(tax);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateTax(int id, Tax tax)
        {
            tax.Id = 0;
            tax.MemberId = id;
            _context.Taxes.Add(tax);
            await _context.SaveChangesAsync();
            return RedirectToAction("CalculateTax", new { id });
        }
        public async Task<IActionResult> SeeTax(int? id)
        {
            Tax tax = _context.Taxes.Where(c => c.MemberId == id).Single();
            return View(tax);
        }
        public async Task<IActionResult> UpdateTax(int id)
        {
            Tax tax = _context.Taxes.Where(c => c.Id == id).Single();

            return View(tax);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateTax(int id, Tax newTax)
        {
            Tax tax = _context.Taxes.Where(c => c.Id == id).Single();
            tax.FillingStatus = newTax.FillingStatus;
            tax.GrossIncome = newTax.GrossIncome;
            tax.StateAbbrevation = newTax.StateAbbrevation;
            int? memberId = tax.MemberId;
            Member member = _context.Members.Where(c => c.Id == memberId).Single();
            _context.SaveChanges();
            _memberService.GetFillingStatus(tax);
            return RedirectToAction("Index", new { member });
        }
        public async Task<IActionResult> DeleteTax(int? id)
        {
            Tax tax = _context.Taxes.Where(c => c.Id == id).Single();

            return View(tax);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteTax(int id)
        {
            Tax tax = _context.Taxes.Where(c => c.Id == id).Single();
            _context.Remove(tax);
            int? memberId = tax.MemberId;
            Member member = _context.Members.Where(c => c.Id == memberId).Single();
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> CalculateTax(int id)
        {
            Tax tax = _context.Taxes.Where(c => c.MemberId== id).Single();
            _memberService.GetFillingStatus(tax);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> SeeVideo()
        {
            return View();
        }


    }
}