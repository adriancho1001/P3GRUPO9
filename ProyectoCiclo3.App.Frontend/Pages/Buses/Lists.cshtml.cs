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
    public class ListBusModel : PageModel
    {
       
        private readonly RepositorioBuses repositorioBuses;
        public IEnumerable<Buses> Buses {get;set;}
 
    public ListBusModel(RepositorioBuses repositorioBuses)
    {
        this.repositorioBuses=repositorioBuses;
     }
 
    public void OnGet()
    {
        Buses=repositorioBuses.GetAll();
    }
    }
}
