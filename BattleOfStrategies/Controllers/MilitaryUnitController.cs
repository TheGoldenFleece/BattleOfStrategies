using BattleOfStrategies.Data;
using BattleOfStrategies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BattleOfStrategies.Controllers
{
    public class MilitaryUnitController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MilitaryUnitController(ApplicationDbContext db)
        {
            _db = db;
        }

        //Get
        public IActionResult Index()
        {
            IEnumerable<MilitaryUnit> objMilitaryUnitList = _db.MilitaryUnits;

            return View(objMilitaryUnitList);
        }


        //public IActionResult Create()
        //{
        //    IEnumerable<MilitaryUnit> objMilitaryUnitList = _db.MilitaryUnits;

        //    return View(objMilitaryUnitList);
        //}

    }
}
