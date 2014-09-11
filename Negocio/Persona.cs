using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
	public class Persona
	{

		public string cedula { get; set; }
		public string nombre { get; set; }
		public string apellido { get; set; }
		public DateTime fechaNacimiento { get; set; }
		public int edad { get; set; }
		public string ciudad { get; set; }

		//método para insertar registros en la base de datos
		public int nuevaPersona(Persona per)
		{
			DatosSistema datos = new DatosSistema();
			String[] parametros = { "@operacion",
								  "@cedula",
								  "@nombre",
								  "@apellido",
								  "@fechaNacimiento",
								  "@edad",
								  "@ciudad"};
			return datos.Ejecutar("spPersonaIA",
							parametros, "I",
							per.cedula,
							per.nombre,
							per.apellido,
							per.fechaNacimiento,
							per.edad,
							per.ciudad);


		}

		//método para actulizar un registro en la base de datos

		public int actualzar(Persona per)
		{
			DatosSistema datos = new DatosSistema();
			string[] parametros ={"@operacion",
									 "@cedula",
									 "@nombre",
									 "@apellido",
								     "@fechaNacimiento",
									"@edad",
								 "@ciudad"};
			return datos.Ejecutar("spPersonaIA", parametros, "A",
				per.cedula,
				per.nombre,
				per.fechaNacimiento,
				per.edad,
				per.ciudad);



		}
		//método para eliminar registro
		public int eliminar(int cedula)
		{
			DatosSistema datos = new DatosSistema();
			String[] parametros = { "@operacion", "@cedula" };
			return datos.Ejecutar("spPersonaSE", parametros, "E", cedula);

		}
		//método consultar
		public DataTable mostrarRegistros()
		{
			DatosSistema datos = new DatosSistema();
			DataTable dt = new DataTable();
			string[] parametros = { "@operacion", "@cedula" };
			return datos.getDatos("spPersonaSE", parametros, "T", 0);

		}
		//método registro expesifico
		public Persona getRegistros(string ced)
		{
			DatosSistema datos = new DatosSistema();
			DataTable dt = new DataTable();
			string[] parametros = { "@operacion", "cedula" };
			dt = datos.getDatos("spPersonaSE", parametros, "S", ced);
			Persona p = new Persona();
			foreach (DataRow fila in dt.Rows)
			{
				p.cedula = fila["cedula"].ToString();
				p.nombre = fila["nombre"].ToString();
				p.apellido = fila["apellido"].ToString();
				p.fechaNacimiento = Convert.ToDateTime(fila["fechaNacimiento"].ToString());
				p.edad = Convert.ToInt32(fila["edad"].ToString());
				p.ciudad = fila["ciudad"].ToString();

			}
			return p;
		}

	}
}
