using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Microsoft.AspNetCore.Http;
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
        public Category GetCategoryTree()
        {
            return _repo.GetCategoryTree();
        }
    }
}