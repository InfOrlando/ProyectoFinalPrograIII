namespace Comunidad
{
    partial class FrmGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGasto));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdentificacion = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.cmTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdentificacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(346, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(122, 48);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Gasto";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(130, 134);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(132, 24);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Identificacion: ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(185, 185);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 24);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Nombre:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(106, 234);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(156, 24);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Tipo de Reparto: ";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(357, 131);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Properties.Appearance.Options.UseFont = true;
            this.txtIdentificacion.Size = new System.Drawing.Size(302, 30);
            this.txtIdentificacion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(357, 182);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Size = new System.Drawing.Size(302, 30);
            this.txtNombre.TabIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(282, 332);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(156, 65);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Guardar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(509, 332);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(156, 65);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "Cancelar";
            // 
            // cmTipo
            // 
            this.cmTipo.FormattingEnabled = true;
            this.cmTipo.Items.AddRange(new object[] {
            "Proporcional",
            "Igualatario"});
            this.cmTipo.Location = new System.Drawing.Point(356, 226);
            this.cmTipo.Name = "cmTipo";
            this.cmTipo.Size = new System.Drawing.Size(302, 24);
            this.cmTipo.TabIndex = 9;
            // 
            // FrmGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 457);
            this.Controls.Add(this.cmTipo);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmGasto";
            this.Text = "FrmGasto";
            ((System.ComponentModel.ISupportInitialize)(this.txtIdentificacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtIdentificacion;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.ComboBox cmTipo;
    }
}