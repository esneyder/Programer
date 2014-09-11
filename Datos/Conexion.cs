using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {

        public SqlConnection con { get; set; }

        private string cadenaconexion() {
			return @"data source=localhost;initial catalog=bd;user id=esneyder;password=alvarez123";
        }

        //método conexión
        public SqlConnection conectar() {
            con = new SqlConnection(cadenaconexion());
            try
            {
                this.con.Open();
                return this.con;
            }
            catch (Exception)
            {

                return null;
            }
        

        }
        //método para cerrar la conexión
        public void desconectar(){
            if (this.con!=null)
            {
                this.con.Close();
            }
        }

    }
}
