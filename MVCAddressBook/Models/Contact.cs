using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MVCAddressBook.Enums;


namespace MVCAddressBook.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }  //Connects to the Category Category below - is the actual Id property of one Category record
        public Category Category { get; set; } //Let's each contact access the information of their category

        [Display(Name = "First Name")]
        public string FirstName { get; set; }  //Name of Contact
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        public string City { get; set; }

        public State State { get; set; }

        [DataType(DataType.PostalCode)]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Home Phone")]
        public string HomePhone { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Work Phone")]
        public string WorkPhone { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Fax Number")]
        public string FaxNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Profile Picture")]
        public byte[] Poster { get; set; }
        public string ContentType { get; set; }


    }
}
