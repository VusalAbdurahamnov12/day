using System.Collections.Generic;

namespace day.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Product { get; set; }
    }
}
