using RedingtonProject.Models;

namespace RedingtonProject.Services
{
    
    public interface IProbabilityFunctionService
    {
        double FunctionOne(ProbabilityModel pm);
        double FunctionTwo(ProbabilityModel pm);   
    }

}
