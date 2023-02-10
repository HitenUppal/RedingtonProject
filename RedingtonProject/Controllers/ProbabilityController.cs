using Microsoft.AspNetCore.Mvc;
using RedingtonProject.Models;
using RedingtonProject.Services;


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
                    _service.AIntersectionB(pm);
                    break;
                case 2:
                    _service.AUnionB(pm);
                    break;
                default:
                    break;
            }

        }

    }
}
