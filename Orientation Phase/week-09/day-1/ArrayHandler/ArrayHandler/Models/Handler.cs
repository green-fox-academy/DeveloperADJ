using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayHandler.Models
{
    public class Handler
    {
        public string What { get; set; }
        public int[] Numbers { get; set; }

        public int Sum()
        {
            int total = 0;

            foreach (var number in Numbers)
            {
                total += number;
            }

            return total;
        }

        public JsonResult ProcessArray()
        {
            if (What == "sum")
            {
                return new JsonResult(new { result = Sum()});
            }
            else if (What == "multiply")
            {
                return new JsonResult(new { result = Multiply() });
            }
            else if (What == "double")
            {
                return new JsonResult(new { result = Double() });
            }
            else
            {
                return new JsonResult(new { error = "Please provide what to do with the numbers!" });
            }
        }

        public int Multiply()
        {
            int result = 1;
            foreach (var number in Numbers)
            {
                result *= number;
            }

            return result;
        }

        public List<int> Double()
        {
            var doubledNumbers = new List<int>();

            foreach (var number in Numbers)
            {
                doubledNumbers.Add(number * 2);
            }

            return doubledNumbers;
        }
    }
}
