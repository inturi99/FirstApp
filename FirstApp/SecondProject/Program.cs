using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new BreakAwayContext();
            var ds = context.Destinations;
            var lg = context.Lodging;
        }

       
    }
}
