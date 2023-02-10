using Microsoft.AspNetCore.Mvc;
using RedingtonProject.Models;
using RedingtonProject.Services;

namespace RedingtonProject.Controllers
{
    public class FunctionController : IProbabilityFunctionService
    {
  
        LogController logger = new LogController();

        public double FunctionOne(ProbabilityModel pm)
        {
            pm.P_OUT = (double)Decimal.Multiply((Decimal)pm.P_A, (Decimal)pm.P_B);

            logger.runLogger(pm);
            return pm.P_OUT;
        }

        public double FunctionTwo(ProbabilityModel pm)
        {
             pm.P_OUT = (double)((Decimal)(pm.P_A + pm.P_B) - (Decimal.Multiply((Decimal)pm.P_A, (Decimal)pm.P_B)));
             logger.runLogger(pm);
             return pm.P_OUT;  
        }



    }
}
