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
    public class EditUsuariosModel : PageModel
    {
       private readonly RepositorioUsuarios RepositorioUsuarios;
              public Usuarios Usuarios {get;set;}

        public DetailsUsuariosModel(RepositorioUsuarios RepositorioUsuarios) => this.RepositorioUsuarios = RepositorioUsuarios;

        public IActionResult OnGet(int UsuariosId)
        {
                Usuarios=RepositorioUsuarios.GetUsuariosWithId(UsuariosId);
                return Page();
 
        }
    }
}