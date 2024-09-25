using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rosales_WaterLevel_Monitor
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_login());
        }
    }

    public static class ConfiguracionProyecto
    {
        public static int IDUSUARIO { get; set; }
        public static string USUARIO { get; set; }
        public static string CONTRASENA { get; set; }
    }

}
