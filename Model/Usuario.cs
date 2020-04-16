using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPersonal
{
    class Usuario
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string datanasc { get; set; }
        public double peso { get; set; }
        public double altura { get; set; }
        public string sexo { get; set; }
        public string email { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string senhacrip { get; set; }
        public int tipoUsuario { get; set; }
        public int status { get; set; }
        public int reset { get; set; }

        public Usuario()
        {
            codigo = 0;
            nome = "";
            datanasc = "";
            peso = 0;
            altura = 0;
            sexo = "";
            email = "";
            login = "";
            senha = "";
            senhacrip = "";
            tipoUsuario = 0;
            status = 0;
            reset = 0;
        }
    }
}
