using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppXmlToDB.Models
{
    public class ProContext:DbContext
    {
        public ProContext(DbContextOptions<ProContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
