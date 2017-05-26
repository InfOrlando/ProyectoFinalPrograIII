using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Comunidad
{
    public partial class Principal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnNuevaComunidad_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmComunidad frm = new FrmComunidad();
            frm.ShowDialog();
        }

        private void btnNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmGasto frm = new FrmGasto();
            frm.ShowDialog();
        }

        private void btnNuevaPropiedad_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void btnNuevoPropietario_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmPropietario frm = new FrmPropietario();
            frm.ShowDialog();
        }

        private void btnListadoComunidad_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmListas listas = new FrmListas();
            listas.mostrarDatosComunidad();
            listas.lblTitulo.Text = "Comunidad";
            listas.MdiParent = this;
            listas.Show();
            
        }

        private void btnListadoPropietario_ItemClick(object sender, ItemClickEventArgs e)
        {

            FrmListas listas = new FrmListas();
            listas.mostrarDatosPropietario();
            listas.lblTitulo.Text = "Propietario";
            listas.MdiParent = this;
            listas.Show();

        }

        private void btnListadoGastos_ItemClick(object sender, ItemClickEventArgs e)
        {

            FrmListas listas = new FrmListas();
            listas.mostrarDatosGastosXZona();
            listas.lblTitulo.Text = "Gastos por Zona";
            listas.MdiParent = this;
            listas.Show();

        }

        private void btnNuevoTipoDePropiedades_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmTipoDePorpiedad tipoPropiedad = new FrmTipoDePorpiedad();
            tipoPropiedad.ShowDialog();
        }

        private void btnListadoTipoPropiedades_ItemClick(object sender, ItemClickEventArgs e)
        {
            

            FrmListas listas = new FrmListas();
            listas.mostrarDatosTipoPropiedad();
            listas.lblTitulo.Text = "Tipos de Propiedad";
            listas.MdiParent = this;
            listas.Show();
        }
    }
}