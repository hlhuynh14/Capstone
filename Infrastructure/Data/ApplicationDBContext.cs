using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Domain;


namespace Infrastructure.Data
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<IActionResult> Members{ get; set; }
        public DbSet<FillingStatuses> FillingStatuses { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
