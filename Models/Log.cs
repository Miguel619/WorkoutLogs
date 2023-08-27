using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoTheWork.Models
{
    public class Log
    {
        public int Id { get; set; }
        public string Activity { get; set; }
        public string Duration { get; set; }
        public int Calories { get; set; }
        public Log()
        {

        }
    }
}
