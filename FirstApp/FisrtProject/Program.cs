using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisrtProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VetContext();
            var ps = context.Patients;
            var vs = context.Visits;
            //var AnimalType = context.AnimalType;
        }
    }
}
