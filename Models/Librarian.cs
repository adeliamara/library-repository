using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models
{
    public class Librarian
    {
        [Display(Name = "codio da livraria")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string? Name { get; set; }

        [Display(Name = "Ebdereço")]
        public string? Adress { get; set; }

        [Display(Name = "numero telefone")]
        public string? PhoneNumber { get; set; }

        public void updateInfo() {
            Console.WriteLine("Info Updated");
        }

        public void issueBooks() {
            Console.WriteLine("Book Issued");
        }

        public void memberInfo() {
            Console.WriteLine("Member Info");
        }

        public void searchBook() {
            Console.WriteLine("Book Searched");
        }

        public void returnBook() {
            Console.WriteLine("Book Returned");
        }
    }
}