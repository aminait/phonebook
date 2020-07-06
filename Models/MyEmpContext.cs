using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phonebook.Models
{
    public class MyEmpContext : DbContext
    {
        public virtual DbSet<Userdetails> Userdetails { get; set; }

        public MyEmpContext(DbContextOptions<MyEmpContext> options) : base(options)
        {

        }
    }
}