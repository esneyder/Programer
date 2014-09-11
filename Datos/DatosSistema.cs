using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class DatosSistema
    {
       public DataTable getDatos(string procedimiento,
           string[] parametros, params object[] valparametros) {
               Conexion con = new Conexion();
               SqlCommand cmd = new SqlCommand();
               cmd.Connection = con.conectar();
               cmd.CommandText = procedimiento;
               cmd.CommandType = CommandType.StoredProcedure;
               if (procedimiento.Length!=0 && parametros.Length==valparametros.Length)
               {
                   int i = 0;
                   foreach (string parametro in parametros)
                       cmd.Parameters.AddWithValue(parametro,valparametros[i++]);
               
               }
       
       }
    }
}
