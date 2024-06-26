﻿using GarajYeri.Business.Abstract;
using GarajYeri.Data;
using GarajYeri.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace GarajYeri.Web.Controllers
{
    [Authorize]
    public class VehicleController : Controller
    {

        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        public IActionResult Index()
        {


            return View();
        }

        public IActionResult GetAll()
        {
            bool isAdmin = User.IsInRole("Admin");
            int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            return Json(new { data = _vehicleService.GetAll(isAdmin, userId) });

        }

        [HttpPost]
        public IActionResult Add(Vehicle vehicle)
        {
            return Ok(_vehicleService.Add(vehicle));

        }
        [HttpPost]
        public IActionResult Update(Vehicle vehicle)
        {
            return Ok(_vehicleService.Update(vehicle));
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _vehicleService.Delete(id);
            return Ok();
        }

        [HttpPost]
        public IActionResult GetById(int id)
        {
            return Ok(_vehicleService.GetById(id));
        }



    }
}