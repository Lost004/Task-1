using Taskone.Model;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace FirstTask.Controllers
{
    public class ModelController : Controller
    {
        private readonly List<Model> _models;

        public ModelController()
        {
            _models = new List<Model>
            {
                new Model { Id = 1, Name = "M5", MarkaId= 1 },
                new Model { Id = 2, Name = "A6", MarkaId= 2 },
                new Model { Id = 3, Name = "S-500", MarkaId= 3 },
                new Model { Id = 4, Name = "911", MarkaId= 4 },
            };
        }
        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                if (_models.Exists(m => m.Id == id)) NotFound();

                return View(_models.FindAll(m => m.MarkaId == id));
            }
            return View(_models);
        }
    }
}
