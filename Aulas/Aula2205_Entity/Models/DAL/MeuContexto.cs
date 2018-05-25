using System.Data.Entity;

namespace Aula2205_Entity.Models.DAL
{
    public class MeuContexto : DbContext
    {
        public MeuContexto() : base("strConn")
        {
            //DropCreateDatabaseAlways 

            //DropCreateDatabaseIfModelChanges

            //Migrations (pra produção)

            
            Database.SetInitializer<MeuContexto>(new DropCreateDatabaseIfModelChanges<MeuContexto>());
        }

        
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Atividade> Atividade { get; set; }

    }
}