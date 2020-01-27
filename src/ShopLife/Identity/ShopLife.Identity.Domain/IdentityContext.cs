using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopLife.Identity.Domain.Entities;

namespace ShopLife.Identity.Domain
{
    internal class IdentityContext : IdentityDbContext<User, IdentityRole<int>, int>, IIdentityContext
    {
        public IdentityContext(DbContextOptions<IdentityContext> options)
            : base(options)
        {
        }
    }
}