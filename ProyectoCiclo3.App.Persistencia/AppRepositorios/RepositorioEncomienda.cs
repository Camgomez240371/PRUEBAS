using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEncomienda
    {
        List<Encomienda> Encomiendas;
 
    public RepositorioEncomienda()
        {
            Encomiendas= new List<Encomienda>()
            {
                new Encomienda{id=1,nombre="Mario",apellidos= "Sánchez",direccion= "Carrera 27",telefono= "8945412121"},
                new Encomienda{id=2,nombre="Camila",apellidos= "Rodriguez",direccion= "Calle 96",telefono= "895656562"},
                new Encomienda{id=3,nombre="Maria Carolina",apellidos= "Perez",direccion= "Avenida Sur con 14",telefono= "12145454"} 
            };
        }
 
        public IEnumerable<Encomienda> GetAll()
        {
            return Encomiendas;
        }
 
        public Encomienda GetencomiendaWithId(int id){
            return Encomiendas.SingleOrDefault(b => b.id == id);
        }
    }
}
