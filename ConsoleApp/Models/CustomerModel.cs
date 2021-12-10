using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTable.Models
{
    internal class CustomerModel
    {
        public CustomerModel(int number, string firstname, string lastname, string email, string allergies)
        {
            Number = number;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Allergies = allergies;
        }

        public int Number { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Allergies { get; set; }


        public override string ToString()
        {
            return "#" + Number + " " + FirstName + LastName + "," + Email;
        }
    }


}
