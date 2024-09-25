using Rosales_WaterLevel_Monitor.Controllers;
using Rosales_WaterLevel_Monitor.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Rosales_WaterLevel_Monitor
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region
            try
            {
                UsuariosController _usuariosController = new UsuariosController();
                var usuariomodel = _usuariosController.AutenticarUsuario(txt_Usuario.Text.Trim(), txt_Contraseña.Text.Trim());
                if (usuariomodel != null)
                {
                    //lbl_mensaje.Text = "Ingreso exitoso";
                    //this.Hide();
                    MessageBox.Show("¡Ingreso exitoso!");

                    ConfiguracionProyecto.IDUSUARIO = usuariomodel.IDUSUARIO;
                    ConfiguracionProyecto.USUARIO = usuariomodel.USUARIO;
                    ConfiguracionProyecto.CONTRASENA = usuariomodel.CONTRASENA;

                    frm_MenuPrincipal _frm_usuarios = new frm_MenuPrincipal();
                    this.Hide();
                    //_frm_usuarios.AjustarMenuSegunRol(usuariomodel.Roles);
                    _frm_usuarios.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    //.Text = "Usuario o contraseña incorrectos";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //lbl_mensaje.Text = $"Error: {ex.Message}";
            }
            #endregion
        }

        private void txt_Contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
