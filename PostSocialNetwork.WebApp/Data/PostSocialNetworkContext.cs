using Microsoft.EntityFrameworkCore;
using PostSocialNetwork.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostSocialNetwork.WebApp.Data
{
    public class PostSocialNetworkContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=tcp:post-social-network-db-server.database.windows.net,1433;Initial Catalog=PostSocialNetwork-Db;Persist Security Info=False;User ID=gustavo;Password=@dsInf123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
