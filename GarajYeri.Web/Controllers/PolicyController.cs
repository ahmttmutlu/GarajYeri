using GarajYeri.Models;
using GarajYeri.Repository.Shared.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace GarajYeri.Web.Controllers
{
    public class PolicyController : Controller
    {
        private readonly IRepository<Policy> _policyRepository;

        public PolicyController(IRepository<Policy> policyRepository)
        {
            _policyRepository = policyRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult GetAll(Guid id)
        //{


        //}
    }
}