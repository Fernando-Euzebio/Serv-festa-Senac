using System;

namespace bibliotecaDoSeuZe
{
    public class Pessoa
    {
        public int cod_pessoa { get; set; }
        public string nome { get; set; }
        public DateTime data_nascimento { get; set; }
        public string tipo { get; set; }

        public Pessoa ()
        {
            cod_pessoa = 0;
        }
    }
}