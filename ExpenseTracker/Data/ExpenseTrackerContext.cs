using ExpenseTracker.Data.Models;
using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ExpenseTracker.Data
{
    public class ExpenseTrackerContext : DbContext
    {
        public ExpenseTrackerContext(DbContextOptions<ExpenseTrackerContext> options)
            : base(options) { }

        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Income> Incomes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data pentru Category
            modelBuilder.Entity<Category>()
                .HasData(new Category[]
                {
                    new Category { Id = 1, Name = "Food" },
                    new Category { Id = 2, Name = "Travel" },
                    new Category { Id = 3, Name = "Entertainment" },
                    new Category { Id = 4, Name = "Education" },
                    new Category { Id = 5, Name = "Clothes" },
                    new Category { Id = 6, Name = "House" },
                });

            // Seed data pentru Expense (asigură-te că folosești DateTime.UtcNow)
            modelBuilder.Entity<Expense>()
                .HasData(new[]
                {
                    new Expense { Id = 1, Title = "Grocery Shopping", Date = DateTime.UtcNow, Amount = 100.0m, Planned = true, CategoryId = 1 },
                    new Expense { Id = 2, Title = "Train Ticket", Date = DateTime.UtcNow, Amount = 50.0m, Planned = false, CategoryId = 2 },
                    new Expense { Id = 3, Title = "Movie Night", Date = DateTime.UtcNow, Amount = 30.0m, Planned = true, CategoryId = 3 },
                    new Expense { Id = 4, Title = "Online Course", Date = DateTime.UtcNow, Amount = 200.0m, Planned = true, CategoryId = 4 },
                    new Expense { Id = 5, Title = "New Jacket", Date = DateTime.UtcNow, Amount = 150.0m, Planned = false, CategoryId = 5 },
                    new Expense { Id = 6, Title = "Rent", Date = DateTime.UtcNow, Amount = 800.0m, Planned = true, CategoryId = 6 }
                });

            
            modelBuilder.Entity<Income>()
                .HasData(new[]
                {
                    new Income { Id = 1, Title = "Freelance Gig", Date = DateTime.UtcNow, Amount = 500.0m, Type = IncomeType.Salary },
                    new Income { Id = 2, Title = "Scholarship Grant", Date = DateTime.UtcNow, Amount = 1000.0m, Type = IncomeType.Scholarship },
                    new Income { Id = 3, Title = "Birthday Gift", Date = DateTime.UtcNow, Amount = 200.0m, Type = IncomeType.Gift },
                    new Income { Id = 4, Title = "Lottery Prize", Date = DateTime.UtcNow, Amount = 10000.0m, Type = IncomeType.LuckyWinnings }
                });
        

            base.OnModelCreating(modelBuilder);
        }
    }
}
