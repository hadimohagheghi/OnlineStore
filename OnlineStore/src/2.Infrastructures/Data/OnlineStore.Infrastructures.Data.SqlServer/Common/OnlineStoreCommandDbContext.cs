using Microsoft.EntityFrameworkCore;

namespace OnlineStore.Infrastructures.Data.SqlServer.Common
{
    public class OnlineStoreCommandDbContext : DbContext
    {
        public OnlineStoreCommandDbContext(DbContextOptions<OnlineStoreCommandDbContext> options) : base(options)
        {
            
        }
    }
}
