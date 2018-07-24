using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Pizzaorder
{
    class PizzaDetail
    {
        [Key]
        public int PizzaId { get; set; }
        [Required]
        public string PizzaName { get; set; }
        [Required]
        public string PizzaToppings { get; set; }
        [Required]
        public string PizzaType { get; set; }
        [Required]

        public char PizzaSize { get; set; }
        [Required]
        public int PizzaPrice
        {
            get; set;

        }
    }
}
