using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class MoqRepo : IRepo
    {
        private static readonly Mock<IRepo> _mock;
        static MoqRepo()
        {
            _mock = new Mock<IRepo>();
            _mock.Setup(repo => repo.GetCategoryTree()).Returns(BuildCategoryTree());
        }

        private static IList<Category> BuildCategoryTree()
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
                        ID = 1,
                        Name = "Cars",
                        SubCategories = new List<Category>()
                        {
                            new Category()
                            {
                                ID = 10,
                                Name = "Off Road",
                                Products = new List<Product>()
                        {
                            new Product()
                            {
                                ID = 1,
                                Name = "Jeep",
                                Price = 1000
                            },
                            new Product()
                            {
                                ID = 2,
                                Name = "Super Jeep",
                                Price = 500
                            }
                        }
                            },
                            new Category()
                            {
                                ID = 10,
                                Name = "Light",
                                Products = new List<Product>()
                        {
                            new Product()
                            {
                                ID = 1,
                                Name = "Mini",
                                Price = 100
                            },
                            new Product()
                            {
                                ID = 2,
                                Name = "Super mini",
                                Price = 50
                            }
                        }
                            }
                        },
                        
                    },
                    new Category()
                    {
                        ID = 2,
                        Name = "Food",
                        Products = new List<Product>()
                        {
                            new Product()
                            {
                                ID = 3,
                                Name = "Pizza",
                                Price = 2
                            },
                            new Product()
                            {
                                ID = 4,
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
            return BuildCategoryTree();
        }
    }
}
