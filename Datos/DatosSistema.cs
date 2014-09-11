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
               DataTable dt = new DataTable();
               SqlCommand cmd = new SqlCommand();
               cmd.Connection = con.conectar();
               cmd.CommandText = procedimiento;
               cmd.CommandType = CommandType.StoredProcedure;
               if (procedimiento.Length!=0 && parametros.Length==valparametros.Length)
               {
                   int i = 0;
                   foreach (string parametro in parametros)
                       cmd.Parameters.AddWithValue(parametro,valparametros[i++]);
                   try
                   {
                       SqlDataReader dr = cmd.ExecuteReader();
                       dt.Load(dr);
                       con.desconectar();
                       return dt;
                   }
                   catch (Exception)
                   {
                       
                      
                   }
               }
               return dt;
       
       }
    }
}
