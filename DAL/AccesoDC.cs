using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccesoDC : DbContext
    {
        public AccesoDC(DbContextOptions<AccesoDC> options) : base(options)
        {
        }

        // Aseguramos el uso de Ids autoincrementales.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        public DbSet<alumnosInformatica> alumnosInformatica { get; set; }
    }
}
