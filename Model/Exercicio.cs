    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace SmartPersonal
    {
        class Exercicio
        {
            public int id_exercicio { get; set; }
            public string nome_exercicio { get; set; }
            public string nome_aparelho { get; set; }
            public string tipo_exercicio { get; set; }

            public Exercicio()
            {
                id_exercicio = 0;
                nome_exercicio = "";
                nome_aparelho = "";
                tipo_exercicio = "";
            }
        }
    }
