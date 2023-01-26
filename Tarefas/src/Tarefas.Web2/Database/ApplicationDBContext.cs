using Microsoft.EntityFrameworkCore;

namespace Tarefas.Web2.Database 
{
    public class ApplicationDBContext : DbContext {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):base(options)        {


        }
    }



}