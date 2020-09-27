using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVCProject1.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreMVCProject1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
