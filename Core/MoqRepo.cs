using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    public class MoqRepo : IRepo
    {
        
        public static IList<Category> FillData()
        {
            return new List<Category>()
            {
                new Category() {
                ID = 1,
                Name = "Root Category",
                SubCategories = new List<Category>()
                {
                    new Category()
                    {
                        ID = 2,
                        Name = "Cars",
                        SubCategories = new List<Category>()
                        {
                            new Category()
                            {
                                ID = 3,
                                Name = "Off Road",
                                Products = new List<Product>()
                        {
                            new Product()
                            {
                                ID = 4,
                                Name = "Jeep",
                                Price = 1000
                            },
                            new Product()
                            {
                                ID = 5,
                                Name = "Super Jeep",
                                Price = 500
                            }
                        }
                            },
                            new Category()
                            {
                                ID = 6,
                                Name = "Light",
                                Products = new List<Product>()
                        {
                            new Product()
                            {
                                ID = 7,
                                Name = "Mini",
                                Price = 100
                            },
                            new Product()
                            {
                                ID = 8,
                                Name = "Super mini",
                                Price = 50
                            }
                        }
                            }
                        },
                        
                    },
                    new Category()
                    {
                        ID = 9,
                        Name = "Food",
                        Products = new List<Product>()
                        {
                            new Product()
                            {
                                ID = 10,
                                Name = "Pizza",
                                Price = 2
                            },
                            new Product()
                            {
                                ID = 11,
                                Name = "Tea",
                                Price = 1
                            }
                        }
                    }
                }
                }
            };
        }

        public IList<Category> GetCategoryTree()
        {
            return FillData();
        }

        public IEnumerable<Product> GetCategoryProducts(int categoryId)
        {
            return FillData().SelectMany(s => s.GetProductsInCategory(categoryId));      
        }

        public Product GetProduct(int productId)
        {
            return FillData().Select(s => s.SearchProduct(productId)).FirstOrDefault();
        }

        
    }
}
