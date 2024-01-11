using graciellyStore.Maps;
using graciellyStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graciellyStore.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GraciellyStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
        }

        public DbSet<Produtos> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutosMap());
        }
    }
}
