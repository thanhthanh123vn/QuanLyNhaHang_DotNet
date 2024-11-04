using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Object
{
    internal class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
