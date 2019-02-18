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

        private static Category BuildCategoryTree()
        {
            return new Category()
            {
                ID = 1,
                Name = "Root Category",
                SubCategories = new List<Category>()
                {
                    new Category()
                    {
                        ID = 1,
                        Name = "Cars",
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
                                Name = "Nissan",
                                Price = 500
                            }
                        }
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
            };
        }

        public Category GetCategoryTree()
        {
            return BuildCategoryTree();
        }
    }
}
