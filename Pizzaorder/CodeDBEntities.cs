using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Pizzaorder
{
    class CodeDBEntities : DbContext
    {
        public DbSet<PizzaDetail> PizzaDetails { get; set; }

        public CodeDBEntities() : base("MyDBPizza")
        {


        }
    }
}