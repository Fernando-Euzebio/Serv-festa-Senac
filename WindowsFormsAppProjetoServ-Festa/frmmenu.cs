using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProjetoServ_Festa
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var frmpessoas = new frmpessoas();
            frmpessoas.ShowDialog();
        }

        private void mercadoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmmercadoria = new frmmercadoria();
            frmmercadoria.ShowDialog();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void saidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmsaida = new frmsaida();
            frmsaida.ShowDialog();
        }

        private void frmmenu_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmpessoas = new frmpessoas();
            frmpessoas.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmmercadorias = new frmmercadoria();
            frmmercadorias.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var frmsaida = new frmsaida();
            frmsaida.ShowDialog();
        }
    }
}
