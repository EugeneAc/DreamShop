using System.Linq;
using Core;
using Microsoft.AspNetCore.Mvc;

namespace DreamShop.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private IRepo _repo;
        public ShopController(IRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public Category[] GetCategoryTree()
        {
            return _repo.GetCategoryTree().ToArray();
        }

        [HttpGet]
        public Product GetProduct(int productId)
        {
            return _repo.GetProduct(productId);
        }

        [HttpGet]
        public Product[] GetCategoryProducts(int CategoryId)
        {
            return _repo.GetCategoryProducts(CategoryId).ToArray();
        }
    }
}