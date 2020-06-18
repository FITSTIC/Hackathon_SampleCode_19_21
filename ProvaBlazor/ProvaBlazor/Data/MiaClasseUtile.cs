using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaBlazor.Data
{
    public class MiaClasseUtile
    {
        private int h;
        public MiaClasseUtile(int h)
        {
            this.h = h;
        }

        public string Saluto()
        {
            return "Ciao "+h;
        }
    }
}
