using Microsoft.EntityFrameworkCore;

namespace PrototipoEntityFramework
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}