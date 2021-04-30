using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MVCAddressBook.Enums;
using Microsoft.AspNetCore.Identity;

namespace MVCAddressBook.Models
{
    public class Category
    {
        public int Id { get; set; } //Primary Key


        public string Name { get; set; }  //Name of Category

        [Display(Name = "Category Image")]
        public byte[] Poster { get; set; }
        public string ContentType { get; set; }

        public CategoryType CategoryType { get; set; }

        public ICollection<Contact> Contact { get; set; } = new HashSet<Contact>();  //Creates a Foreign Key

    }
}
