using Microsoft.AspNetCore.Mvc;
using RedingtonProject.Models;

namespace RedingtonProject.Controllers
{
    public class LogController : Controller
    {

        public void runLogger(ProbabilityModel pm)
        {
            Thread t = new Thread(() => PLogger(pm));
            t.Start();  
        }


        private void PLogger(ProbabilityModel pm)
        {

            string logPA = pm.P_A.ToString();
            string logPB = pm.P_B.ToString();
            string logPOUT = pm.P_OUT.ToString();

            string logFunction = "";

            if (pm.FUNC_MODEL == 1)
            {
                logFunction = "Function 1";
            }
            if (pm.FUNC_MODEL == 2)
            {
                logFunction = "Function 2";
            }

            Thread.Sleep(1000);

            string sysPath = Environment.CurrentDirectory.ToString();

            string dT = DateTime.Now.ToString("dd-MM-yyyy--HH-mm-ss");
            string date = DateTime.Now.ToString("dd-MM-yyyy");

            System.IO.Directory.CreateDirectory(sysPath + "/logs");   

            string filePath = sysPath + "/logs/" + "log-" + dT + ".txt";

            StreamWriter sb = new StreamWriter(filePath);

            string[] loggerOutput = { date, logPA, logPB, logFunction, logPOUT };
            string[] labels = { "Date:  ", "P(A):  ", "P(B):  ", "Function Type: ", "Output Calculation:  " };

            for (int i = 0; i < loggerOutput.Length; i++)
            {
                sb.WriteLine(labels[i] + loggerOutput[i]);
            }
            sb.Close();
        }



    }
}
