using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPersonal
{
    class Treino
    {
        public int id_treino { get; set; }
        public int id_usuario { get; set; }
        public string nome_instrutor { get; set; }
        public string nome_exercicio { get; set; }
        public string nome_aparelho { get; set; }
        public string tipo_exercicio { get; set; }
        public int series { get; set; }
        public int repeticoes { get; set; }
        public int duracao { get; set; }

        public Treino()
        {
            id_treino = 0;
            id_usuario = 0;
            nome_instrutor = "";
            nome_aparelho = "";
            nome_exercicio = "";
            series = 0;
            repeticoes = 0;
            duracao = 0;
        }
    }
}
