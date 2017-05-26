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
    }
}