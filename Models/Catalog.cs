using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models
{
    public class Catalog
    {
        [Display(Name = "Catalog ID")]
        public int Id { get; set; }

        [Display(Name = "Nome do autor")]
        public string? AuthorName { get; set; }

        [Display(Name = "Numero de copias")]
        public int NumberOfCopies { get; set; }

        [Required, Display(Name = "Livros")]
        public virtual ICollection<Book> Books { get; set; }

        public void UpdateInfo() 
        {
            Console.WriteLine("Catalogo atualizaod");
        }

        public void Search() 
        {
            Console.WriteLine("Busca no catalogo");
        }

    }
}