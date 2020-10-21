using Microsoft.EntityFrameworkCore;
namespace web_api_empresa.Models{
    class Conexion : DbContext{
        public Conexion (DbContextOptions<Conexion> options) : base(options){}
        public DbSet<Clientes> Clientes {get;set;}      
    }
 class Conectar{
           private const string cadenaConexion = "server=Antonio;port=3306;database=db_empresa;";
            public static Conexion Create(){
                var constructor = new DbContextOptionsBuilder<Conexion>();
                constructor.UseMySQL(cadenaConexion);
                var Conexion = new Conexion (constructor.Options);
                return Conexion;

            }
        }

}