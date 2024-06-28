using GarajYeri.Business.Abstract;
using GarajYeri.Data;
using GarajYeri.Models;
using GarajYeri.Repository.Shared.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace GarajYeri.Web.Controllers
{
    public class VehicleTypeController : Controller
    {
        private readonly IVehicleTypeService _vehicleTypeService;

        public VehicleTypeController(IVehicleTypeService vehicleTypeService)
        {
            _vehicleTypeService = vehicleTypeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            //   return Json(new { data = _context.VehicleTypes.Where(vt => !vt.IsDeleted) });
            return Json(new { data = _vehicleTypeService.GetAll() });
        }

        [HttpPost]
        public IActionResult Add(VehicleType vehicleType)
        {
            
         
            //_context.VehicleTypes.Add(vehicleType);
            //_context.SaveChanges();
            return Ok(_vehicleTypeService.Add(vehicleType));
        }


        [HttpPost]
        public IActionResult SoftDelete(int id)
        {
           
            //var vehicleType = _context.VehicleTypes.Find(id);
            //vehicleType.IsDeleted = true;
            //vehicleType.DateDeleted= DateTime.Now;
            //_context.VehicleTypes.Update(vehicleType);
            //_context.SaveChanges();
            return Ok(_vehicleTypeService.Delete(id));
        }

        [HttpPost]
        public IActionResult Update(VehicleType vehicleType)
        {
           
            //_context.VehicleTypes.Update(vehicleType);
            //_context.SaveChanges();
            return Ok(_vehicleTypeService.Update(vehicleType));
        }

        [HttpPost]
        public IActionResult GetById(int id)
        {
            return Ok(_vehicleTypeService.GetById(id));
        }
    }
}