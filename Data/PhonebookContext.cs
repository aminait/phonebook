using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Phonebook.Models;



namespace Phonebook.Data
{
    public class PhoneBookContext : DbContext
    {
        public PhoneBookContext(DbContextOptions<PhoneBookContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contact { get; set; }

        public DbSet<Phonebook.Models.Userdetails> Userdetails { get; set; }
    }
}
