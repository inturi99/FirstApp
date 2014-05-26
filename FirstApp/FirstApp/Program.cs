using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new TestEntities();
            var countries = context.Countries;
            var states = context.States;
            var Employies = context.Employies;
        }
    }
}
