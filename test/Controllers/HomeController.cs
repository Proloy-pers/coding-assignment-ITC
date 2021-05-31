using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public int getProbability1()
        {
            string First_nameA = "ABC";
            string Last_nameA = "ABC";
            DateTime Date_of_birthA = DateTime.Now;
            int Identification_numberA = 12345;
            string First_nameB = "ABC";
            string Last_nameB = "DEF";
            DateTime Date_of_birthB = DateTime.Now;
            int Identification_numberB = 12345;

            int case1 = Convert.ToInt32(string.Compare(First_nameA, First_nameB));
            int case2 = Convert.ToInt32(string.Compare(Last_nameB, Last_nameA));
            int case3 = Convert.ToInt32(DateTime.Compare(Date_of_birthA.Date, Date_of_birthB.Date));
            int case4 = Convert.ToInt32(Identification_numberA.CompareTo(Identification_numberB));

            int case1Result = 0;
            int case2Result = 0;
            int case3Result = 0;
            int case4Result = 0;

            switch (case1)
            {
                case 0:
                     case1Result = 20;
                    break;
                case 1:
                     case1Result = 0;
                    break;

            }
            switch (case2)
            {
                case 0:
                    case2Result = 40;
                    break;
                case 1:
                     case2Result = 0;
                    break;

            }
            switch (case3)
            {
                case 0:
                     case3Result = 40;
                    break;
                case 1:
                     case3Result = 0;
                    break;

            }
            switch (case4)
            {
                case 0:
                     case4Result = 100;
                    break;
                case 1:
                     case4Result = 0;
                    break;

            }

            int resultA = case1Result + case2Result + case3Result;
            int ans = 0;
            if (case4Result == 100)
            {
                ans = 100;
            }
            else
            {
                ans = resultA;
            }
            return ans;

        }
        
        [HttpPost]
        public int getProbability([FromHeader] string First_name1, [FromHeader] string Last_name1, [FromHeader] DateTime Date_of_birth1, [FromHeader] int Identification_number1, [FromHeader] string First_name2, [FromHeader] string Last_name2, [FromHeader] DateTime Date_of_birth2, [FromHeader] int Identification_number2)
        {
            if (First_name1 == null|| First_name2 == null)
            {
                First_name1 = "unknown1";
                First_name2 = "unknown2";
            }
            if (Last_name1 == null|| Last_name2 == null)
            {
                Last_name1 = "unknown";
                Last_name2 = "unknown2";
            }
            if (Date_of_birth1 == null || Date_of_birth2 == null)
            {
                Date_of_birth1 = DateTime.Now;
                Date_of_birth2 = Date_of_birth1.AddDays(1);

            }
            if (Identification_number1 == null || Identification_number2 == null)
            {
                Identification_number1 = 12345;
                Identification_number2 = 45678;

            }
            string First_nameA = First_name1.ToUpper();
            string Last_nameA = Last_name1.ToUpper();
            DateTime Date_of_birthA = Date_of_birth1;
            int Identification_numberA = Identification_number1;
            string First_nameB = First_name2.ToUpper();
            string Last_nameB = Last_name2.ToUpper();
            DateTime Date_of_birthB = Date_of_birth2;
            int Identification_numberB = Identification_number2;
            string initialA = First_name1.Substring(0, 1);
            string initialB = First_nameB.Substring(0, 1);

            int case1 = Convert.ToInt32(string.Compare(First_nameA, First_nameB));
            int case2 = Convert.ToInt32(string.Compare(Last_nameB, Last_nameA));
            int case3 = Convert.ToInt32(DateTime.Compare(Date_of_birthA.Date, Date_of_birthB.Date));
            int case4 = Convert.ToInt32(Identification_numberA.CompareTo(Identification_numberB));
            int case5 = Convert.ToInt32(string.Compare(initialA, initialB));
            int case1Result = 0;
            int case2Result = 0;
            int case3Result = 0;
            int case4Result = 0;
            int case5Result = 0;

            switch (case1)
            {
                case 0:
                    case1Result = 20;
                    break;
                case 1:
                    case1Result = 0;
                    break;

            }
            switch (case2)
            {
                case 0:
                    case2Result = 40;
                    break;
                case 1:
                    case2Result = 0;
                    break;

            }
            switch (case3)
            {
                case 0:
                    case3Result = 40;
                    break;
                case 1:
                    case3Result = 0;
                    break;

            }
            switch (case4)
            {
                case 0:
                    case4Result = 100;
                    break;
                case 1:
                    case4Result = 0;
                    break;

            }
            switch (case5)
            {
                case 0:
                    case5Result = 15;
                    break;
                case 1:
                    case5Result = 0;
                    break;

            }

            int resultA = case1Result + case2Result + case3Result+case5Result;
            int ans = 0;
            if (case4Result == 100)
            {
                ans = 100;
            }
            else
            {
                ans = resultA;
            }
            return ans;

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
