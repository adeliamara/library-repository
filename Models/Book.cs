using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models
{
    public class Book
    {
        [Key, Display(Name = "Codigo do livro")]
        public int Id { get; set; }
        [Display(Name = "Nome do livro")]
        public string? BookName { get; set; }
        [Display(Name = "Nome do autor")]
        public string? AuthorName { get; set; }
        [Display(Name = "numero de exemplares")]
        public int NumberOfBooks { get; set; }

         public void AddToCatalog(Catalog catalog)
        {
            catalog.Books.Add(this);
            Console.WriteLine($"Livro '{BookName}' adicionado ao catálogo.");
        }

        public void RemoveFromCatalog(Catalog catalog)
        {
            catalog.Books.Remove(this);
            Console.WriteLine($"Livro '{BookName}' removido do catálogo.");
        }
    }
}
