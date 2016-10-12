namespace SistemaDeVentas
{
    partial class LoginUsuarios
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
            this.TiposUsuarioscomboBox1 = new System.Windows.Forms.ComboBox();
            this.TiposUsuarioslabel = new System.Windows.Forms.Label();
            this.Contraseñalabel2 = new System.Windows.Forms.Label();
            this.NombreUsuariolabel = new System.Windows.Forms.Label();
            this.NombreUsuariostextBox1 = new System.Windows.Forms.TextBox();
            this.ContraseñatextBox2 = new System.Windows.Forms.TextBox();
            this.IniciarSeccionbutton1 = new System.Windows.Forms.Button();
            this.NombreUsuarioerrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ContraseñaerrorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NombreUsuarioerrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContraseñaerrorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // TiposUsuarioscomboBox1
            // 
            this.TiposUsuarioscomboBox1.FormattingEnabled = true;
            this.TiposUsuarioscomboBox1.Location = new System.Drawing.Point(31, 186);
            this.TiposUsuarioscomboBox1.Name = "TiposUsuarioscomboBox1";
            this.TiposUsuarioscomboBox1.Size = new System.Drawing.Size(251, 21);
            this.TiposUsuarioscomboBox1.TabIndex = 1;
            // 
            // TiposUsuarioslabel
            // 
            this.TiposUsuarioslabel.AutoSize = true;
            this.TiposUsuarioslabel.Location = new System.Drawing.Point(31, 167);
            this.TiposUsuarioslabel.Name = "TiposUsuarioslabel";
            this.TiposUsuarioslabel.Size = new System.Drawing.Size(77, 13);
            this.TiposUsuarioslabel.TabIndex = 2;
            this.TiposUsuarioslabel.Text = "TiposUsuarios:";
            // 
            // Contraseñalabel2
            // 
            this.Contraseñalabel2.AutoSize = true;
            this.Contraseñalabel2.Location = new System.Drawing.Point(31, 112);
            this.Contraseñalabel2.Name = "Contraseñalabel2";
            this.Contraseñalabel2.Size = new System.Drawing.Size(69, 13);
            this.Contraseñalabel2.TabIndex = 3;
            this.Contraseñalabel2.Text = "Contraseñas:";
            // 
            // NombreUsuariolabel
            // 
            this.NombreUsuariolabel.AutoSize = true;
            this.NombreUsuariolabel.Location = new System.Drawing.Point(31, 50);
            this.NombreUsuariolabel.Name = "NombreUsuariolabel";
            this.NombreUsuariolabel.Size = new System.Drawing.Size(104, 13);
            this.NombreUsuariolabel.TabIndex = 4;
            this.NombreUsuariolabel.Text = "Nombre  de Usuario:";
            // 
            // NombreUsuariostextBox1
            // 
            this.NombreUsuariostextBox1.Location = new System.Drawing.Point(31, 66);
            this.NombreUsuariostextBox1.Name = "NombreUsuariostextBox1";
            this.NombreUsuariostextBox1.Size = new System.Drawing.Size(251, 20);
            this.NombreUsuariostextBox1.TabIndex = 5;
            // 
            // ContraseñatextBox2
            // 
            this.ContraseñatextBox2.Location = new System.Drawing.Point(31, 128);
            this.ContraseñatextBox2.Name = "ContraseñatextBox2";
            this.ContraseñatextBox2.PasswordChar = '*';
            this.ContraseñatextBox2.Size = new System.Drawing.Size(251, 20);
            this.ContraseñatextBox2.TabIndex = 6;
            // 
            // IniciarSeccionbutton1
            // 
            this.IniciarSeccionbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IniciarSeccionbutton1.Image = global::SistemaDeVentas.Properties.Resources.go;
            this.IniciarSeccionbutton1.Location = new System.Drawing.Point(84, 214);
            this.IniciarSeccionbutton1.Name = "IniciarSeccionbutton1";
            this.IniciarSeccionbutton1.Size = new System.Drawing.Size(150, 57);
            this.IniciarSeccionbutton1.TabIndex = 0;
            this.IniciarSeccionbutton1.Text = "Iniciar Sesion";
            this.IniciarSeccionbutton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IniciarSeccionbutton1.UseVisualStyleBackColor = true;
            this.IniciarSeccionbutton1.Click += new System.EventHandler(this.IniciarSeccionbutton1_Click);
            // 
            // NombreUsuarioerrorProvider1
            // 
            this.NombreUsuarioerrorProvider1.ContainerControl = this;
            // 
            // ContraseñaerrorProvider2
            // 
            this.ContraseñaerrorProvider2.ContainerControl = this;
            // 
            // LoginUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 283);
            this.Controls.Add(this.ContraseñatextBox2);
            this.Controls.Add(this.NombreUsuariostextBox1);
            this.Controls.Add(this.NombreUsuariolabel);
            this.Controls.Add(this.Contraseñalabel2);
            this.Controls.Add(this.TiposUsuarioslabel);
            this.Controls.Add(this.TiposUsuarioscomboBox1);
            this.Controls.Add(this.IniciarSeccionbutton1);
            this.Name = "LoginUsuarios";
            this.Text = "LoginUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.NombreUsuarioerrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContraseñaerrorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IniciarSeccionbutton1;
        private System.Windows.Forms.ComboBox TiposUsuarioscomboBox1;
        private System.Windows.Forms.Label TiposUsuarioslabel;
        private System.Windows.Forms.Label Contraseñalabel2;
        private System.Windows.Forms.Label NombreUsuariolabel;
        private System.Windows.Forms.TextBox NombreUsuariostextBox1;
        private System.Windows.Forms.TextBox ContraseñatextBox2;
        private System.Windows.Forms.ErrorProvider NombreUsuarioerrorProvider1;
        private System.Windows.Forms.ErrorProvider ContraseñaerrorProvider2;
    }
}