using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuario
    {
        List<Usuario> usuarios;
 
    public RepositorioUsuario()
        {
            usuarios= new List<Usuario>()
            {
                new Usuario{id=1,nombre="Mario",apellidos= "Sánchez",direccion= "Carrera 27",telefono= "8945412121"},
                new Usuario{id=2,nombre="Camila",apellidos= "Rodriguez",direccion= "Calle 96",telefono= "895656562"},
                new Usuario{id=3,nombre="Maria Carolina",apellidos= "Perez",direccion= "Avenida Sur con 14",telefono= "12145454"} 
            };
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return usuarios;
        }
 
        public Usuario GetUsuarioWithId(int id){
            return usuarios.SingleOrDefault(b => b.id == id); 
        
        }
public Usuario Update(Usuario newUsuario){
            var user = _appContext.Usuarios.Find(newUsuario.id);

            if(user != null){
                user.nombre = newUsuario.nombre;
                user.apellidos = newUsuario.apellidos;
                user.direccion = newUsuario.direccion;
                user.telefono = newUsuario.telefono;
                user.ciudad = newUsuario.ciudad;
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
public Usuario Update(Usuario newUsuario){

            var user= usuarios.SingleOrDefault(b => b.id == newUsuario.id);

            if(user != null){
                user.nombre = newUsuario.nombre;
                user.apellidos = newUsuario.apellidos;
                user.direccion = newUsuario.direccion;
                user.ciudad = newUsuario.ciudad;
                user.telefono = newUsuario.telefono;
                
            }
        return user;
        }
 public Usuario Create(Usuario newUsuario)
        {
           if(usuarios.Count > 0){
           newUsuario.id=usuarios.Max(r => r.id) +1; 
            }else{
               newUsuario.id = 1; 
            }
           usuarios.Add(newUsuario);
           return newUsuario;
        }
         public void Delete(int id)
        {
        var user= usuarios.SingleOrDefault(b => b.id == id);
        usuarios.Remove(user);
        return;
        }  
        }

 
    }
 

