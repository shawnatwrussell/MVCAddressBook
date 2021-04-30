using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using MVCAddressBook.Enums;

namespace MVCAddressBook.Models
{
    public class Category
    {
        public int Id { get; set; } //Primary Key

        public CategoryType CategoryType { get; set; }
        public string Name { get; set; }  //Name of Category

        [Display(Name = "Category Image")]
        public byte[] Poster { get; set; }
        public string ContentType { get; set; }


        public ICollection<Contact> Contact { get; set; } = new HashSet<Contact>();  //Creates a Foreign Key

    }
}
