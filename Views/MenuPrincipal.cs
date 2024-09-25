using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rosales_WaterLevel_Monitor.Views
{
    public partial class frm_MenuPrincipal : Form
    {
        public frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void frm_MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_usuarios usuarios = new frm_usuarios();
            usuarios.ShowDialog();
            
        }

        private void sensoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void diagnósticosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
