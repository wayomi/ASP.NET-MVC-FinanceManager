using FinanceManage.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceManage.Data
{
    public class ApplicataionDbContext : DbContext
    {
        public ApplicataionDbContext(DbContextOptions<ApplicataionDbContext> options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Expense> Expenses { get; set; }
    }
}
