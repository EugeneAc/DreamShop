using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IRepo
    {
        IList<Category> GetCategoryTree();

        IEnumerable<Product> GetCategoryProducts(int categoryId);

        Product GetProduct(int productId);
    }
}
