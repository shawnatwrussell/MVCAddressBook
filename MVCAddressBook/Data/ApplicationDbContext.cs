using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MVCAddressBook.Models;


namespace MVCAddressBook.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MVCAddressBook.Models.Category> Category { get; set; }
        public DbSet<MVCAddressBook.Models.Contact> Contact { get; set; }
    }
}
