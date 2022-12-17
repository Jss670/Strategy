
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Strategy
{
    class program
    {
        static void main(String[] args) 
        { 
            EmpezarConstruccion nuevacasa= new EmpezarConstruccion();
            nuevacasa.ComprarMuebles();
            nuevacasa.IniciarConstruccion();
                 
        }
    }
}