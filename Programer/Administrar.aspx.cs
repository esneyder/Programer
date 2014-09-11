using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Programer
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

		protected void Button1_Click(object sender, EventArgs e)
		{
			Persona persona = new Persona();
			persona.cedula = TextBox1.Text;
			persona.nombre = TextBox2.Text;
			persona.apellido = TextBox3.Text;
			persona.fechaNacimiento =Convert.ToDateTime( TextBox4.Text);
			persona.edad =Convert.ToInt32( TextBox5.Text);
			persona.ciudad = TextBox6.Text;
			persona.nuevaPersona(persona);
		}
    }
}