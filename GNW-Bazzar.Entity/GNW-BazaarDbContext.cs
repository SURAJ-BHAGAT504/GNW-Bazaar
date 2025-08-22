using Microsoft.EntityFrameworkCore;

namespace GNW_Bazzar.Entity
{
    public class GNW_BazaarDbContext(DbContextOptions<GNW_BazaarDbContext> options) : DbContext(options)
    {

    }
}
