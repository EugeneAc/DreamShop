using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IList<Category> SubCategories { get; set; }
        public IList<Product> Products { get; set; }
    }

    public static class CategoryExtensiton
    {
        public static IEnumerable<Product> GetProductsInCategory(this Category category, int categoryId)
        {
            if (category.ID == categoryId)
            {
                if (category.Products != null && category.Products.Any())
                {
                    foreach (var product in category.Products)
                        yield return product;
                }
            }
            if (category.SubCategories != null && category.SubCategories.Any())
            {
                foreach (var product in category.SubCategories.SelectMany(c => c.GetProductsInCategory(categoryId)))
                {
                    yield return product;
                }
            }
        }

        public static Product SearchProduct(this Category category, int productId)
        {
            
            if (category.SubCategories != null && category.SubCategories.Any())
                foreach (var cat in category.SubCategories)
                {
                    var found = cat.SearchProduct(productId);
                    if (found != null)
                        return found;
                }
            if (category.Products != null && category.Products.Any())
            {
                foreach (var product in category.Products)
                {
                    if (product.ID == productId)
                        return product;
                };
            }
            return null;
        }
    }
}

