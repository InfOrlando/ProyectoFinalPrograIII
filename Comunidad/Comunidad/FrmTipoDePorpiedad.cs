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
    public partial class FrmTipoDePorpiedad : DevExpress.XtraEditors.XtraForm
    {
        public FrmTipoDePorpiedad()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //creacion de objeto a la clase cliente

            TipoDePropiedad tipo = new TipoDePropiedad();

            //creacion del archivo

            string NombreArchivo = "TipoDePropiedad.txt";//Nombre del Archivo txt



            //asignacion de datos a variables
            tipo.Identificacion = txtCodigo.Text;
            tipo.Nombre = txtDescripcion.Text;




            // funciones para escribir en el archivo registro.txt


            FileStream archivo = new FileStream(NombreArchivo, FileMode.Append, FileAccess.Write);
            StreamWriter Escribir = new StreamWriter(archivo);

            //enviar datos a objeto escribir

            Escribir.WriteLine(tipo.Identificacion);
            Escribir.WriteLine(tipo.Nombre);

        

            //cerrar la escritura
            Escribir.Close();

            MessageBox.Show("Datos registrados con exito"); //mostrar mensaje en pantalla

            limpiarCajas(); //se manda a llamar el metodo limpiar cajas
        }


        void limpiarCajas()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtCodigo.Focus();

        }
    }
    
}