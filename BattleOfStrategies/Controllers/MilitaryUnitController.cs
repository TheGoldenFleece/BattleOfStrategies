using BattleOfStrategies.Data;
using BattleOfStrategies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BattleOfStrategies.Controllers
{
    public class MilitaryUnitController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MilitaryUnitController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<MilitaryUnit> militaryUnits = _db.MilitaryUnits;

            return View(militaryUnits);
        }

        //Get
        public IActionResult Create()
        {
            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MilitaryUnit obj)
        {
            if (ModelState.IsValid)
            {
                _db.MilitaryUnits.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

    }
}
