namespace Comunidad
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.btnListadoComunidad = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnListadoGastos = new DevExpress.XtraBars.BarButtonItem();
            this.btnListadoPropiedades = new DevExpress.XtraBars.BarButtonItem();
            this.btnListadoPropietario = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevaComunidad = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnListadoComunidad,
            this.btnListadoGastos,
            this.btnListadoPropiedades,
            this.btnListadoPropietario,
            this.btnNuevaComunidad});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbon.Size = new System.Drawing.Size(1115, 179);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Comunidad";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnListadoComunidad);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNuevaComunidad);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Comunidad";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 528);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1115, 40);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Gastos";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Propiedades";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Propietario";
            // 
            // btnListadoComunidad
            // 
            this.btnListadoComunidad.Caption = "Listado";
            this.btnListadoComunidad.Glyph = ((System.Drawing.Image)(resources.GetObject("btnListadoComunidad.Glyph")));
            this.btnListadoComunidad.Id = 1;
            this.btnListadoComunidad.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnListadoComunidad.LargeGlyph")));
            this.btnListadoComunidad.Name = "btnListadoComunidad";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnListadoGastos);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Listado";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnListadoPropiedades);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Listado";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnListadoPropietario);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Listado";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Listado";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnListadoGastos
            // 
            this.btnListadoGastos.Caption = "Listado";
            this.btnListadoGastos.Glyph = ((System.Drawing.Image)(resources.GetObject("btnListadoGastos.Glyph")));
            this.btnListadoGastos.Id = 2;
            this.btnListadoGastos.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnListadoGastos.LargeGlyph")));
            this.btnListadoGastos.Name = "btnListadoGastos";
            // 
            // btnListadoPropiedades
            // 
            this.btnListadoPropiedades.Caption = "Listado";
            this.btnListadoPropiedades.Glyph = ((System.Drawing.Image)(resources.GetObject("btnListadoPropiedades.Glyph")));
            this.btnListadoPropiedades.Id = 3;
            this.btnListadoPropiedades.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnListadoPropiedades.LargeGlyph")));
            this.btnListadoPropiedades.Name = "btnListadoPropiedades";
            // 
            // btnListadoPropietario
            // 
            this.btnListadoPropietario.Caption = "Listado";
            this.btnListadoPropietario.Glyph = ((System.Drawing.Image)(resources.GetObject("btnListadoPropietario.Glyph")));
            this.btnListadoPropietario.Id = 4;
            this.btnListadoPropietario.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnListadoPropietario.LargeGlyph")));
            this.btnListadoPropietario.Name = "btnListadoPropietario";
            // 
            // btnNuevaComunidad
            // 
            this.btnNuevaComunidad.Caption = "Nuevo";
            this.btnNuevaComunidad.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNuevaComunidad.Glyph")));
            this.btnNuevaComunidad.Id = 5;
            this.btnNuevaComunidad.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNuevaComunidad.LargeGlyph")));
            this.btnNuevaComunidad.Name = "btnNuevaComunidad";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 568);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "Principal";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnListadoComunidad;
        private DevExpress.XtraBars.BarButtonItem btnListadoGastos;
        private DevExpress.XtraBars.BarButtonItem btnListadoPropiedades;
        private DevExpress.XtraBars.BarButtonItem btnListadoPropietario;
        private DevExpress.XtraBars.BarButtonItem btnNuevaComunidad;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}