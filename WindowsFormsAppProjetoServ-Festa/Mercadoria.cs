using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaDoSeuZe
{
    public class Mercadoria
    {
        public int cod_mercadorias { get; set; }
        public string nome { get; set; }
        public DateTime validade { get; set; }
        public string alcool { get; set; }
        public int saldo_estoque { get; set; }
        public int adicionar_valor { get; set; }
        public double valor_produto { get; set; }
        public Mercadoria()
        {
            cod_mercadorias= 0;
        }
    }
}
