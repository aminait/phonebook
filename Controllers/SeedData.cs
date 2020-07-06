using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Phonebook.Data;
using Phonebook.Models;
using System;
using System.Linq;

namespace Phonebook.Controllers
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PhoneBookContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PhoneBookContext>>()))
            {
                // Look for any contacts
                if (context.Contact.Any())
                {
                    return;   // DB has been seeded
                }

                context.Contact.AddRange(
                    new Contact
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        Number = "05333333333"
                    },

                    new Contact
                    {
                        FirstName = "James",
                        LastName = "Smith",
                        Number = "05331234567"
                    },

                    new Contact
                    {
                        FirstName = "Jane",
                        LastName = "Doe",
                        Number = "05330987654"
                    }
                   
                );
                context.Userdetails.AddRange(
                    new Userdetails
                    {
                        FirstName = "Testing",
                        LastName = "One",
                        Mobile = "05342334321"
                    },

                    new Userdetails
                    {
                        FirstName = "Second",
                        LastName = "Testing",
                        Mobile = "05334444553"
                    },

                    new Userdetails
                    {
                        FirstName = "Number",
                        LastName = "Three",
                        Mobile = "05366643232"
                    }

                );
                context.SaveChanges();
            }

        }
    }
}