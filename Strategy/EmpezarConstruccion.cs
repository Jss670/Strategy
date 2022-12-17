using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class EmpezarConstruccion
    {
        private Casa nuevacasa;
        public void IniciarConstruccion()
        {
            this.nuevacasa = new ConstruirTecho();
        }
        public void ComprarMuebles()
        {
            this.nuevacasa = new AmueblarCasa();
        }
       
    }
}
