using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLibrary
{
    public class ApplicationClass
    {
        public string DirectRun(string initial_data)
        {
            string status = "in progress";

            try
            {
                Console.WriteLine("Hello, " + initial_data);
                status = "success";
            }
            catch (Exception)
            {
                status = "fail";
            }

            return status;
        }

        public string RunLauncher()
        {
            string status = "in progress";

            try
            {
                string initial_data = "guest. Current status - " + status;
                status = DirectRun(initial_data);
            }
            catch (Exception)
            {
                status = "fail";
            }

            return status;
        }

        public double Hypotenuse(double first_leg, double second_leg)
        {
            return Math.Sqrt(Math.Pow(first_leg, 2) + Math.Pow(second_leg, 2));
        }

        public char SymbolFromCode(int ascii_code)
        {
            char symbol = Convert.ToChar(ascii_code);

            return symbol;
        }

        public int HowmuchSeconds(int[] time) // 0] years; 1] days; 2] hours; 3] minutes; 4] seconds.
        {
            int days = time[0] * 365 + time[1];
            int hours = days * 24 + time[2];
            int minutes = hours * 60 + time[3];
            int seconds = minutes * 60 + time[4];

            return seconds;
        }
    }
}
