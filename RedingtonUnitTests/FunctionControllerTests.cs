using Microsoft.AspNetCore.Mvc;
using RedingtonProject.Controllers;
using RedingtonProject.Models;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using Xunit.Sdk;

namespace RedingtonUnitTests
{
    public class FunctionControllerTests
    {



        [Fact]
        public void Function1_PAnPB_ReturnPOUT()
        {

            var mockModel = new ProbabilityModel();
            mockModel.P_A = 0.2;
            mockModel.P_B = 0.3;
            mockModel.FUNC_MODEL = 1;
            double expected = 0.06;

            var controller = new FunctionController();

            var result = controller.FunctionOne(mockModel);

            Assert.Equal(result, expected);

        }

        [Fact]
        public void Function2_PAUB_ReturnPOUT()
        {
            var mockModel = new ProbabilityModel();
            mockModel.P_A = 0.2;
            mockModel.P_B = 0.3;
            mockModel.FUNC_MODEL = 2;
            double expected = 0.44;

            var controller = new FunctionController();

            var result = controller.FunctionTwo(mockModel);

            Assert.Equal(result, expected);
        }



    }
}