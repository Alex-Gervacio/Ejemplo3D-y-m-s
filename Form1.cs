using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo3D
{
    public partial class Form1 : Form
    {
        Persona persona = new Persona();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {            
            persona.Dpi = textBoxDPI.Text;
            persona.Nombre = textBoxNombre.Text;
            persona.Apellido = textBoxApellido.Text;
            persona.Telefono = textBoxTelefono.Text;
            persona.FechaNacimiento = dateTimePicker1.Value;
            
        }

        private void buttonSalida_Click(object sender, EventArgs e)
        {                                  
            labelDPI.Text = persona.Dpi;
            labelNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(persona.Nombre).Trim();
            labelApellido.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(persona.Apellido).Trim();
            labelTelefono.Text = persona.Telefono;
            //labelFechaNacimiento.Text = persona.FechaNacimiento.ToString();
            //labelEdad.Text = persona.edad().ToString();
            labelEdad.Visible = true;
        }

        private void buttonAbrirCuentas_Click(object sender, EventArgs e)
        {
            FormCuenta formularioCuenta = new FormCuenta();
            formularioCuenta.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - dateTimePicker1.Value.Year;
            if (fechaActual < dateTimePicker1.Value.AddYears(edad)) edad--;

            labelEdad.Text = "Tienes " + edad.ToString() + " años";
        }

        private void label1Edad_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
