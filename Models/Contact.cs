using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Phonebook.Models
{
    public class Contact
    {
            public int Id { get; set; }
            [DisplayName("First Name")]
            [StringLength(60, MinimumLength = 3)]
            [Required]
            public string FirstName { get; set; }

            [DisplayName("Last Name")]
            [StringLength(60, MinimumLength = 3)]
            [Required]
            public string LastName { get; set; }

            public string Number { get; set; }


    }
}
