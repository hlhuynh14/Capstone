﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Domain.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<int?>("BudgetId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("BudgetId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Domain.Budget", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MemberId");

                    b.Property<string>("Name");

                    b.Property<double>("Percent");

                    b.Property<double>("RemainderAfterBill");

                    b.Property<double>("RemainderAfterExpenses");

                    b.Property<double>("RemainderAfterGoals");

                    b.Property<double>("TotalMonthlyNetIncome");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Budgets");
                });

            modelBuilder.Entity("Domain.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<int?>("BudgetId");

                    b.Property<string>("Name");

                    b.Property<double>("Percent");

                    b.HasKey("Id");

                    b.HasIndex("BudgetId");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("Domain.FederalTax", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<double>("Bracket");

                    b.Property<string>("FillingStatus");

                    b.Property<double>("MarginalRate");

                    b.HasKey("Id");

                    b.ToTable("FederalTaxes");
                });

            modelBuilder.Entity("Domain.FillingStatuses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FillingStatus");

                    b.HasKey("Id");

                    b.ToTable("FillingStatuses");
                });

            modelBuilder.Entity("Domain.Goal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BudgetId");

                    b.Property<double>("CurrentSavings");

                    b.Property<DateTime>("DateChecker");

                    b.Property<double>("EstimatedHighLoan");

                    b.Property<double>("EstimatedHighTotal");

                    b.Property<double>("EstimatedLowLoan");

                    b.Property<double>("EstimatedLowTotal");

                    b.Property<double>("GoalSavingsPerMonth");

                    b.Property<DateTime>("GoalsDateChecker");

                    b.Property<string>("GoalsName");

                    b.Property<double>("GoalsSavings");

                    b.Property<double>("InterestRate");

                    b.Property<int>("LoanTermInYears");

                    b.Property<int>("MonthGoals");

                    b.Property<int>("Months");

                    b.Property<string>("Name");

                    b.Property<bool>("Savings");

                    b.Property<double>("SavingsEstimated");

                    b.Property<double>("SavingsPerMonth");

                    b.Property<bool>("SavingsTowardGoal");

                    b.Property<double>("TargetSavings");

                    b.HasKey("Id");

                    b.HasIndex("BudgetId");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("Domain.Income", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<int?>("BudgetId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("BudgetId");

                    b.ToTable("Incomes");
                });

            modelBuilder.Entity("Domain.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("Domain.Tax", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("EstimatedNetIncome");

                    b.Property<string>("FillingStatus");

                    b.Property<double>("GrossIncome");

                    b.Property<double>("MedicareTax");

                    b.Property<int?>("MemberId");

                    b.Property<double>("SocialSecurityTax");

                    b.Property<string>("StateAbbrevation");

                    b.Property<double>("TaxableIncome");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Taxes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Domain.ApplicationRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.ToTable("ApplicationRole");

                    b.HasDiscriminator().HasValue("ApplicationRole");
                });

            modelBuilder.Entity("Domain.Bill", b =>
                {
                    b.HasOne("Domain.Budget", "Budget")
                        .WithMany("BillList")
                        .HasForeignKey("BudgetId");
                });

            modelBuilder.Entity("Domain.Budget", b =>
                {
                    b.HasOne("Domain.Member", "member")
                        .WithMany("BudgetList")
                        .HasForeignKey("MemberId");
                });

            modelBuilder.Entity("Domain.Expense", b =>
                {
                    b.HasOne("Domain.Budget", "Budget")
                        .WithMany("ExpenseList")
                        .HasForeignKey("BudgetId");
                });

            modelBuilder.Entity("Domain.Goal", b =>
                {
                    b.HasOne("Domain.Budget", "Budget")
                        .WithMany("GoalList")
                        .HasForeignKey("BudgetId");
                });

            modelBuilder.Entity("Domain.Income", b =>
                {
                    b.HasOne("Domain.Budget", "Budget")
                        .WithMany("IncomeList")
                        .HasForeignKey("BudgetId");
                });

            modelBuilder.Entity("Domain.Member", b =>
                {
                    b.HasOne("Domain.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationId");
                });

            modelBuilder.Entity("Domain.Tax", b =>
                {
                    b.HasOne("Domain.Member", "member")
                        .WithMany("TaxList")
                        .HasForeignKey("MemberId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Domain.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Domain.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Domain.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
