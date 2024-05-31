using GarajYeri.Data;
using GarajYeri.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GarajYeri.Web.Controllers
{
    [Authorize(Roles ="Admin")]
    public class PolicyTypeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PolicyTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAll()
        {
            return Json(new { data = _context.PoliciesTypes.Where(pt => !pt.IsDeleted) });
        }
        [HttpPost]
        public IActionResult GetById(int id) 
        {
            return Ok(_context.PoliciesTypes.Find(id));
        }

        [HttpPost]
        public IActionResult Add(PolicyType policyType)
        {
            _context.PoliciesTypes.Add(policyType);
            _context.SaveChanges();
            return Ok(policyType);
        }
        [HttpPost]
        public IActionResult HardDelete(PolicyType policyType)
        {
            _context.PoliciesTypes.Remove(policyType);
            _context.SaveChanges();
            return Ok(policyType);
        }
        [HttpPost]
        public IActionResult SoftDelete(int id)
        {
            var policyType = _context.PoliciesTypes.Find(id);
            if (policyType != null)
            {
                policyType.IsDeleted = true;

                _context.PoliciesTypes.Update(policyType);

                try
                {
                    _context.SaveChanges();
                    return Ok(policyType);
                }
                catch (Exception ex)
                {
                    // return StatusCode(500, ex.Message);
                    return BadRequest(ex);
                }

            }
            else
            {
                return BadRequest("HATA !");
            }

        }
        [HttpPost]
        public IActionResult Update(PolicyType policyType)
        {
            _context.PoliciesTypes.Update(policyType);
            _context.SaveChanges();
            return Ok(policyType);
        }

    }
}
