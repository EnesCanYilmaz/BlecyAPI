using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlecyAPI.Application.Repositories.Post;
using Microsoft.AspNetCore.Mvc;

namespace BlecyAPI.API.Controllers
{
    [Route("api/[controller]")]
    public class PostsController : Controller
    {
        readonly private IPostReadRepository _readPostRepository;

        public PostsController(IPostReadRepository readPostRepository)
        {
            _readPostRepository = readPostRepository;
        }

        [HttpGet]
        public async Task<IActionResult>List()
        {
            return Ok(_readPostRepository.GetAll());
        }
    }
}

