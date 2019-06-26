
/*esta clase es importante ya que aqui se agregan todas las tablas que se necesitan
 connectar con la db*/
namespace Shop.Web.Data
{
    using Microsoft.EntityFrameworkCore;//para usar con la DbContext si no lanzara un error.
    using Shop.Web.Data.Entities;//para que la tabla Product pueda ser usada.
    using System;
    using System;
    
    //esta clase hereda de DbContext
    public class DataContext : DbContext
    {
        /*se crea una propiedad de tipo DbSet para cada tabla que deseamos
         que se incluya en la bd, osea esta tabla se va a mapear en el entity framework
         con esto ya los productos seran tratados como colecciones de un objeto de tipo Productos y no
         como campos de una tabla, cada vez que necesitenmos un campo de la tabla accesaremos
         a travez de la propiedad de tipo DbSet<Product>*/
        public DbSet<Product> Products { get; set; }
        //para conectarme a la bd creo este constructor
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        /*NOTA==>no le hemos dicho a que bd nos vamos a conectar, hay que marcar el string de la _
         * conexion de la bd y eso lo hacemos en el archivo json llamado appsettings.json */
    }
}
