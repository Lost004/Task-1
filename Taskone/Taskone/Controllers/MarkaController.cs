using Taskone.Model;
using Microsoft.AspNetCore.Mvc;

namespace Taskone.Controllers
{
    public class MarkaController : Controller
    {
        private readonly List<Marka> _marka;

        public MarkaController()
        {
            _marka = new List<Marka>
            {
                new Marka{ Id = 1, Name = "BMW"},
                new Marka{ Id = 2, Name = "Audi"},
                new Marka{ Id = 3, Name = "Mercedes"},
                new Marka{ Id = 4, Name = "Porsche"},
            };
        }

        public IActionResult Index()
        {
            return View(_marka);
        }
    }
}