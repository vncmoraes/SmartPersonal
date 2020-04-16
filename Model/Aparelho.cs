using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPersonal
{
    class Aparelho
    {
        public int id_aparelho { get; set; }
        public string nome { get; set; }
        public string foto { get; set; }
        public string fotophp { get; set; }

        public Aparelho()
        {
            id_aparelho = 0;
            nome = "";
            foto = "";
            fotophp = "";
        }
    }
}
