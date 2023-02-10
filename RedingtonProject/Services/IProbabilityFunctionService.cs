using RedingtonProject.Models;

namespace RedingtonProject.Services
{
    
    public interface IProbabilityFunctionService
    {
        double AIntersectionB(ProbabilityModel pm);
        double AUnionB(ProbabilityModel pm);   
    }

}
