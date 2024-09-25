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
    public partial class frm_InsertarUsuario : Form
    {
        public frm_InsertarUsuario()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            if (comprobar())
            {
                var resultado = new UsuariosModel();
                string res = "";
                var usuario = new UsuariosModel
                {
                    ID = this.id,
                    NombreUsuario = txt_NombreUsuario.Text.Trim().ToString(),
                    Password = txt_Contrasenia.Text.Trim().ToString(),
                    Roles = cmb_Roles.SelectedItem.ToString()
                };
                MessageBox.Show(cmb_Roles.SelectedItem.ToString());
                if (this.id != 0)
                {
                    res = UsuariosModel.Actualizar(usuario);
                }
                else
                {
                    resultado = _usuariosController.InsertarUsuario(usuario);
                    res = resultado.ID > 0 ? "ok" : "error";
                }
                if (res == "ok")
                {
                    MessageBox.Show("Se guardo con exito");
                    cargalista();
                    txt_Contrasenia.Text = "";
                    txt_NombreUsuario.Text = "";
                    txt_Repita.Text = "";
                    cmb_Roles.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al guardar, intentelo mas tarde");
                }

            }



        }
    }
}
