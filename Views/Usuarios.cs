using Rosales_WaterLevel_Monitor.Controllers;
using Rosales_WaterLevel_Monitor.Modelos;
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
    public partial class frm_usuarios : Form
    {
        public frm_usuarios()
        {
            InitializeComponent();
        }
        UsuariosController usuariosController = new UsuariosController();
        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'monitoreoAguaDataSet.USUARIOS' Puede moverla o quitarla según sea necesario.
            this.uSUARIOSTableAdapter.Fill(this.monitoreoAguaDataSet.USUARIOS);
            // TODO: esta línea de código carga datos en la tabla 'monitoreoAguaDataSet.REGISTRO' Puede moverla o quitarla según sea necesario.
            this.rEGISTROTableAdapter.Fill(this.monitoreoAguaDataSet.REGISTRO);

        }

        private void btn_GuardarUsuarios (object sender, EventArgs e)
        {
            string respuesta = "";
            UsuariosModel USUARIO = new UsuariosModel
            {
                usuario_id = codigousuario,
                nombre = dataGridView1.Text
            };
            try
            {
                if (codigousuario == 0)
                {
                    respuesta = usuariosController.InsertarUsuario(USUARIO);
                }
                else
                {
                    respuesta = usuariosController.ActualizarUsuario(USUARIO);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Se guardo con exito");
            codigUsuario = 0;
            dataGridView1.Enabled = false;
            dataGridView1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_MenuPrincipal menu = new frm_MenuPrincipal();
            menu.ShowDialog();
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            codigoUsuario = Convert.ToInt16(dataGridView1.SelectedCells );
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            UsuariosModel usuariosModel = new UsuariosModel { usuario_id = codigoUsuario };
            DialogResult result = MessageBox.Show("Desea Eliminar el Autor", "Formulario de Autores", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (UsuariosController.EliminarUsuario(usuariosModel: usuariosModel) == "ok")
                {
                    MessageBox.Show("Se elimino con exito");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al eliminar");
                }
            }
            else
            {
                MessageBox.Show("El usuario cancelo la eliminacion");




            }
        }
}
}