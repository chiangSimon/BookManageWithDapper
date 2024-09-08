using BookManageWithDapper.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookManageWithDapper.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookManageController : ControllerBase
    {

        private readonly BookDbContext _bookDbContext;

        public BookManageController(IConfiguration configuration)
        {
            _bookDbContext = new BookDbContext(configuration);
        }

        public IEnumerable<dynamic> GetData()
        {
            return _bookDbContext.GetData();
        }

    }
}
