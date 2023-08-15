using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers
{
    [Route("Category")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public string GetAllCategory()
        {
            return "Olá Mundo!";
        }

        [HttpGet("Id")]
        public string GetCategoryById(int id)
        {
            return "Olá Mundo!";
        }

        [HttpPost]
        public string AddCategory()
        {
            return "Olá Mundo!";
        }

        [HttpPut]
        public string PutCategory()
        {
            return "Olá Mundo!";
        }

        [HttpDelete]
        public string DeleteCategory()
        {
            return "Olá Mundo!";
        }
    }
}
