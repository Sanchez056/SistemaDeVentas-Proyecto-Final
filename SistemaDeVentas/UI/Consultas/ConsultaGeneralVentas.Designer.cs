namespace SistemaDeVentas
{
    partial class ConsultaGeneralVentas
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
            this.VentasDiariastabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.VentasDiariastabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // VentasDiariastabControl
            // 
            this.VentasDiariastabControl.Controls.Add(this.tabPage1);
            this.VentasDiariastabControl.Controls.Add(this.tabPage2);
            this.VentasDiariastabControl.Location = new System.Drawing.Point(12, 12);
            this.VentasDiariastabControl.Name = "VentasDiariastabControl";
            this.VentasDiariastabControl.SelectedIndex = 0;
            this.VentasDiariastabControl.Size = new System.Drawing.Size(694, 284);
            this.VentasDiariastabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(686, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ventas Diarias";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(686, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ventas Mensuales";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ConsultaGeneralVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 294);
            this.Controls.Add(this.VentasDiariastabControl);
            this.Name = "ConsultaGeneralVentas";
            this.Text = "ConsultaGeneralVentas";
            this.VentasDiariastabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl VentasDiariastabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}