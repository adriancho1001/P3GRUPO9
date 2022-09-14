using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class DetailsBusModel : PageModel
    {
       private readonly RepositorioBuses repositorioBuses;
        public Buses Bus {get;set;}
 
        public DetailsBusModel(RepositorioBuses repositorioBuses)
       {
            this.repositorioBuses=repositorioBuses;
       }
 
        public IActionResult OnGet(int BusId)
        {
            Bus=repositorioBuses.GetWithId(busId);
            return Page();
 
        }
    }
}