using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models
{
    public class Alert
    {
        [Key, Display(Name = "Código do alerta")]
        public int Id { get; set; }

        [Display(Name = "Data do problema")]
        public DateOnly IssueDate { get; set; }

        [Required, Display(Name = "Nome do livro")]
        public string? BookName { get; set; }

        public DateOnly ReturnDate { get; set; }
        [Display(Name = "Data de devolução")]
        public int Fine { get; set; }

        public int FineCall()
        {
            return 0;
        }

        public void ViewAlert()
        {
            Console.WriteLine("Alerta visualizado");
        }

        public void SendToLibrarian()
        {
            Console.WriteLine("Alerta enviado");
        }

        public void DeleteAlert()
        {

            using (var dbContext = new MyDbContext()) 
            {
                var alertToRemove = dbContext.Alerts.FirstOrDefault(a => a.Id == Id);
                if (alertToRemove != null)
                {
                    dbContext.Alerts.Remove(alertToRemove);
                    dbContext.SaveChanges();
                    Console.WriteLine($"Alerta para o livro '{BookName}' deletado em {DateTime.Now}.");
                }
            }
        }

    }
}