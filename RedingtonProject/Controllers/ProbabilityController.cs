using Microsoft.AspNetCore.Mvc;
using RedingtonProject.Models;
using RedingtonProject.Services;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Transactions;

namespace RedingtonProject.Controllers
{
    public class ProbabilityController : Controller
    {
        public ProbabilityModel pm = new ProbabilityModel();
        private readonly IProbabilityFunctionService _service;

        public ProbabilityController(IProbabilityFunctionService service)
        {
            _service = service;
        }
 
        public IActionResult Index(double ViewA, double ViewB, string ViewFunc)
        {
            // Binds Views to Models through Function 
            DefaultModelBind(ViewA, ViewB, ViewFunc);

            FunctionSwitch();

            return View(pm);
            
        }

        private ProbabilityModel DefaultModelBind(double ViewA, double ViewB, string ViewFunc)
        {
            // all user inputs 
            pm.P_A = ViewA;
            pm.P_B = ViewB;
            pm.FUNC_MODEL = Convert.ToInt32(ViewFunc);

            return pm;
        }

        private void FunctionSwitch()
        {
            switch (pm.FUNC_MODEL)
            {
                case 1:
                    _service.FunctionOne(pm);
                    break;
                case 2:
                    _service.FunctionTwo(pm);
                    break;
                default:
                    break;
            }

        }

    }
}
