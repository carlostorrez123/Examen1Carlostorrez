using Actividad1.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado.DAL
{
    public class PersonaDal
    {
        public DataTable ListarPersonaDal()
        {
            string consulta = "select * from persona";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

    }
}
