using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Phonebook.Models
{
    public class ContactList
    {

            public List<Contact> Contacts { get; set; }
            public SelectList Numbers { get; set; }
            public string ContactNumber { get; set; }
            public string SearchString { get; set; }
    }
}

