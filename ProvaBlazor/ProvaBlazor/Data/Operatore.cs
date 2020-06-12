using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaBlazor.Data
{
    public class Operatore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public class Metereologo : Operatore
    {
        public string Competenza { get; set; }
    }

    public class Presentatore : Operatore
    {
        public string Lingua { get; set; }
    }
}
