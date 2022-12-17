using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class ConstruirTecho : Casa
    {
        public void Habitar()
        {
            Console.WriteLine("Construir");
        }
       
    }
}
