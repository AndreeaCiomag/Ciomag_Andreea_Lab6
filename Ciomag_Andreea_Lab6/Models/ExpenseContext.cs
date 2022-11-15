using System;
using Microsoft.EntityFrameworkCore;

namespace Ciomag_Andreea_Lab6.Models
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options)
            : base(options)
        {
        }

        public DbSet<Expenses> Expenses { get; set; }
        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }
    }
}

