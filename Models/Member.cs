using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models
{
    public class Member
    {
        [Display(Name = "Código do membro")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string? Name { get; set; }

        [Display(Name = "Endereço")]
        public string? Adress { get; set; }

        [Display(Name = "Telefone")]
        public int Phone { get; set; }

        [Display(Name = "Book")]
        public virtual ICollection<Book> Books { get; set; }

        public void requestForBook() 
        {
            Console.WriteLine("Book Requested");
        }

        public void returnBook() 
        {
            Console.WriteLine("Book Returned");
        }
    }


}