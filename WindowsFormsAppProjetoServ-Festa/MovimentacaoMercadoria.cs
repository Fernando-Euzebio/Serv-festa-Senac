using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaDoSeuZe
{
    public class MovimentacaoMercadoria
    {
        public int cod_movimentacao_mercadoria { get; set; }    
        public int cod_movimentacao { get; set; }
        public int cod_mercadoria { get; set; }
        public int quantidade { get; set; }
        public int adicionar_valor { get; set; }
        public string nome { get; set; }
        public DateTime data_movimentacao { get; set; }
        public MovimentacaoMercadoria() 
        {
            cod_mercadoria= 0;
            cod_movimentacao= 0;
        }
    }
}
