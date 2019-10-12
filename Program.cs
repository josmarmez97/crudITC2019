using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Pruebapost.Models;

namespace Pruebapost
{
    class Program
    {
        static void Main(string[] args)
        {           
           //leer();
           //agregar();
           //leer();                                
          // eliminar();
           //leer();
           //actualizar();
           //leer();
        }

        public static void leer()
        {
                var context = new usuariosContext();
                var usr = context.Usuarios.FromSql("SELECT *FROM usuarios").ToList();
                //SELECT * FROM usuarios left join roles on id = id_usuarios;                        
                foreach(var c in usr)
                {
                    System.Console.WriteLine($"id:{c.IdUsuarios} userid:{c.Userid} nombre:{c.Nombre} pass:{c.Pass}");                                        
                }
        }
        
        public static void agregar()
        {            
                System.Console.Write("Se agrego un registro nuevo\n");
                 var context = new usuariosContext();
                context.Add(new Usuarios{ IdUsuarios = 7 ,Userid="joseXD",Nombre="jose mendez",Pass="12345"});                
                //context.Add(new Usuarios{ IdUsuarios = 6 ,Userid="hhhh",Nombre="FG",Pass="abcde"});  
                context.SaveChanges();                                                    
        }
       
        public static void eliminar()
        {
                System.Console.Write("Se esta eliminando los datos que tienen id = 5\n\n");
                var context = new usuariosContext();
                //context.Usuarios.FromSql("DELETE FROM usuarios WHERE IdUsuarios = 5"); ESTA SENTENCIA NO SIRVE
                context.Remove(new Usuarios{ IdUsuarios = 5 });
                context.SaveChanges();           
        }
        
        public static void actualizar()
        {
            Console.WriteLine("Actualizando la base de datos en un momento\n");
            var context = new usuariosContext();
            context.Update(new Usuarios{ IdUsuarios = 6,Userid="qaz",Nombre="qwe",Pass="09876"});
            context.SaveChanges();  
        }

    }
}
