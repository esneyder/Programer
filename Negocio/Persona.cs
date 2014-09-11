using Datos;
using System;
using System.Collections.Generic;
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
		public int nuevaPersona(Persona per) {
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
	}
}
