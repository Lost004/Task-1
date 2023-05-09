using Microsoft.AspNetCore.Mvc;

using Taskone.Model;

namespace FirstTask.Controllers
{
    public class CarController : Controller
    {
        private readonly List<Car> _cars;

        public CarController()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1,Price=29000,Modelid=1},
                new Car { Id = 2,Price=19000,Modelid=2},
                new Car { Id = 3,Price=59000,Modelid=3},
                new Car { Id = 4,Price=79000,Modelid=4},
            };
        }
        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                if (_cars.Exists(m => m.Id == id)) NotFound();

                return View(_cars.FindAll(m => m.Modelid == id));
            }
            return View(_cars);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) BadRequest();

            Car car = _cars.Find(c => c.Id == id);

            if (car == null) return NotFound();

            return View(car);
        }
    }
}