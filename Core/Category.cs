using System.Collections.Generic;

namespace Core
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IList<Category> SubCategories { get; set; }
        public IList<Product> Products { get; set; }
    }
}
