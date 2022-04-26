using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioData
{
    public class DataContext : DbContext
    {
        DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Nota> Nota { get; set; }
    }
}
