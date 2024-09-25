using Rosales_WaterLevel_Monitor.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rosales_WaterLevel_Monitor.Controllers
{
    internal class SensoresController
    {

        public SensoresModel InsertarSensor(SensoresModel LOCALIZACION)
        {
            return SensoresModel.Insertar(LOCALIZACION);
        }

        public string ActualizarSensor(SensoresModel LOCALIZACION)
        {
            return SensoresModel.Actualizar(LOCALIZACION);
        }

        public string EliminarSensor(int IDSENSOR)
        {
            return SensoresModel.Eliminar(IDSENSOR);
        }

        public SensoresModel ObtenerUsuarioPorId(int IDSENSOR)
        {
            return SensoresModel.ObtenerPorId(IDSENSOR);
        }

        public List<SensoresModel> ObtenerUsuarios()
        {
            return SensoresModel.ObtenerTodos();
        }


    }
}
