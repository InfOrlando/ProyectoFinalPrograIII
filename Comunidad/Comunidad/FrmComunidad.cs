using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace Comunidad
{
    public partial class FrmComunidad : DevExpress.XtraEditors.XtraForm
    {
        public FrmComunidad()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            //creacion de objeto a la clase cliente

            Comunidad comunidad = new Comunidad();

            //creacion del archivo

            string NombreArchivo = "Comunidad.txt";//Nombre del Archivo txt



            //asignacion de datos a variables
            comunidad.Identificacion = txtIdentificacion.Text;
            comunidad.Nombre = txtNombre.Text;
            comunidad.Poblacion = txtPoblacin.Text;




            // funciones para escribir en el archivo registro.txt


            FileStream archivo = new FileStream(NombreArchivo, FileMode.Append, FileAccess.Write);
            StreamWriter Escribir = new StreamWriter(archivo);

            //enviar datos a objeto escribir
            Escribir.WriteLine(comunidad.Identificacion);
            Escribir.WriteLine(comunidad.Nombre);
            Escribir.WriteLine(comunidad.Poblacion);
        
            //cerrar la escritura
            Escribir.Close();

            MessageBox.Show("Datos registrados con exito"); //mostrar mensaje en pantalla

            limpiarCajas(); //se manda a llamar el metodo limpiar cajas
        }


        void limpiarCajas()
        {
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            txtPoblacin.Text = "";
            txtIdentificacion.Focus();
          
        }
    }
    
}