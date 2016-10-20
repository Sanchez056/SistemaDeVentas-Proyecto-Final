namespace SistemaDeVentas
{
    partial class Presentacion
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
            this.components = new System.ComponentModel.Container();
            this.PresentacionprogressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PresentacionprogressBar1
            // 
            this.PresentacionprogressBar1.BackColor = System.Drawing.Color.Green;
            this.PresentacionprogressBar1.ForeColor = System.Drawing.Color.Green;
            this.PresentacionprogressBar1.Location = new System.Drawing.Point(154, 283);
            this.PresentacionprogressBar1.Name = "PresentacionprogressBar1";
            this.PresentacionprogressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PresentacionprogressBar1.RightToLeftLayout = true;
            this.PresentacionprogressBar1.Size = new System.Drawing.Size(373, 23);
            this.PresentacionprogressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PresentacionprogressBar1.TabIndex = 0;
            this.PresentacionprogressBar1.UseWaitCursor = true;
            this.PresentacionprogressBar1.Click += new System.EventHandler(this.PresentacionprogressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaDeVentas.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 318);
            this.Controls.Add(this.PresentacionprogressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Presentacion";
            this.Text = "Presentacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ProgressBar PresentacionprogressBar1;
    }
}