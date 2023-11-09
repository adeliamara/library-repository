using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models
{
    public class Student: Member
    {

        [Display(Name = "Escola")]
        public string? studentCollege { get; set; }

        public void CheckoutBook() {
            Console.WriteLine("Book Checked Out");
        }

        public void ReturnBook() {
            Console.WriteLine("Book Returned");
        }
    }
}