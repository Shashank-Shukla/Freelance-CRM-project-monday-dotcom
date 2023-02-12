using CRM_Monday.Models.DbContextModels;
using Microsoft.EntityFrameworkCore;
using CRM_Monday.Models.InputModels;

namespace CRM_Monday.Data.DbContexts
{
    public class UserDbContext: DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<CRM_Monday.Models.InputModels.UserLogin> UserLogin { get; set; }
    }
}
