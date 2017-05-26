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
    public partial class FrmListas : DevExpress.XtraEditors.XtraForm
    {
        List<Comunidad> comunidades = new List<Comunidad>();
        List<Propietario> propietarios = new List<Propietario>();
        List<GastosPorZona> GastosxZona = new List<GastosPorZona>();
        List<TipoDePropiedad> TipoDePropiedades = new List<TipoDePropiedad>();


        public FrmListas()
        {
            InitializeComponent();
        }

        private void FrmListas_Load(object sender, EventArgs e)
        {

        }


        public void mostrarDatosComunidad()
        {
            string nombrearchivo = "C:\\Users\\Orlando Perez\\Source\\Repos\\ProyectoFinalPrograIII\\Comunidad\\Comunidad\\bin\\Debug\\Comunidad.txt";


            FileStream stream = new FileStream(nombrearchivo, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);



            while (leer.Peek() > -1)
            {
                Comunidad comuni = new Comunidad();

                comuni.Identificacion = leer.ReadLine();
                comuni.Nombre = leer.ReadLine();
                comuni.Poblacion = leer.ReadLine();

                comunidades.Add(comuni);  


            

            }
            //Cerrar el archivo
            leer.Close();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = comunidades;
            dataGridView1.Refresh();



        }


        public void mostrarDatosPropietario()
        {
            string nombrearchivo = "C:\\Users\\Orlando Perez\\Source\\Repos\\ProyectoFinalPrograIII\\Comunidad\\Comunidad\\bin\\Debug\\Propietario.txt";


            FileStream stream = new FileStream(nombrearchivo, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);



            while (leer.Peek() > -1)
            {
                Propietario propietario = new Propietario();
                propietario.Identificacion = leer.ReadLine();
                propietario.Nombre = leer.ReadLine();
                propietario.Email = leer.ReadLine();

                propietarios.Add(propietario);





            }
            //Cerrar el archivo
            leer.Close();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = propietarios;
            dataGridView1.Refresh();



        }


        public void mostrarDatosGastosXZona()
        {
            string nombrearchivo = "C:\\Users\\Orlando Perez\\Source\\Repos\\ProyectoFinalPrograIII\\Comunidad\\Comunidad\\bin\\Debug\\GastosXZona.txt";


            FileStream stream = new FileStream(nombrearchivo, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);



            while (leer.Peek() > -1)
            {
                GastosPorZona gastos = new GastosPorZona();
                gastos.Identificacion = leer.ReadLine();
                gastos.Nombre = leer.ReadLine();
                gastos.TipoDeReparto = leer.ReadLine();

                GastosxZona.Add(gastos);
                

            }
            //Cerrar el archivo
            leer.Close();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = GastosxZona;
            dataGridView1.Refresh();



        }


        public void mostrarDatosTipoPropiedad()
        {
            string nombrearchivo = "C:\\Users\\Orlando Perez\\Source\\Repos\\ProyectoFinalPrograIII\\Comunidad\\Comunidad\\bin\\Debug\\TipoDePropiedad.txt";


            FileStream stream = new FileStream(nombrearchivo, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);



            while (leer.Peek() > -1)
            {
                TipoDePropiedad tipoDePropiedad = new TipoDePropiedad();
                tipoDePropiedad.Identificacion = leer.ReadLine();
                tipoDePropiedad.Nombre = leer.ReadLine();

                TipoDePropiedades.Add(tipoDePropiedad);


              


            }
            //Cerrar el archivo
            leer.Close();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = TipoDePropiedades;
            dataGridView1.Refresh();



        }
    }
}