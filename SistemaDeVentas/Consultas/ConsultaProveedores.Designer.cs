namespace SistemaDeVentas.Consultas
{
    partial class ConsultaProveedores
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
            this.ConsultaProveedoressdataGridView = new System.Windows.Forms.DataGridView();
            this.Desdelabel = new System.Windows.Forms.Label();
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.Hastalabel = new System.Windows.Forms.Label();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicke = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.ConsultaProveedorlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaProveedoressdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaProveedoressdataGridView
            // 
            this.ConsultaProveedoressdataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultaProveedoressdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaProveedoressdataGridView.Location = new System.Drawing.Point(53, 207);
            this.ConsultaProveedoressdataGridView.Name = "ConsultaProveedoressdataGridView";
            this.ConsultaProveedoressdataGridView.Size = new System.Drawing.Size(680, 312);
            this.ConsultaProveedoressdataGridView.TabIndex = 91;
            // 
            // Desdelabel
            // 
            this.Desdelabel.AutoSize = true;
            this.Desdelabel.Location = new System.Drawing.Point(67, 179);
            this.Desdelabel.Name = "Desdelabel";
            this.Desdelabel.Size = new System.Drawing.Size(37, 15);
            this.Desdelabel.TabIndex = 90;
            this.Desdelabel.Text = "Desde";
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.Location = new System.Drawing.Point(231, 133);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(244, 21);
            this.FiltrotextBox.TabIndex = 88;
            // 
            // Hastalabel
            // 
            this.Hastalabel.AutoSize = true;
            this.Hastalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hastalabel.Location = new System.Drawing.Point(228, 175);
            this.Hastalabel.Name = "Hastalabel";
            this.Hastalabel.Size = new System.Drawing.Size(47, 18);
            this.Hastalabel.TabIndex = 87;
            this.Hastalabel.Text = "Hasta";
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastadateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(280, 175);
            this.HastadateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(112, 22);
            this.HastadateTimePicker.TabIndex = 86;
            // 
            // DesdeDateTimePicke
            // 
            this.DesdeDateTimePicke.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicke.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicke.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicke.Location = new System.Drawing.Point(110, 171);
            this.DesdeDateTimePicke.Margin = new System.Windows.Forms.Padding(2);
            this.DesdeDateTimePicke.Name = "DesdeDateTimePicke";
            this.DesdeDateTimePicke.Size = new System.Drawing.Size(114, 22);
            this.DesdeDateTimePicke.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 84;
            this.label1.Text = "Filtrar";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "UsuarioId",
            "Nombre"});
            this.comboBox1.Location = new System.Drawing.Point(103, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 83;
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.AutoSize = true;
            this.Imprimirbutton.ForeColor = System.Drawing.Color.Black;
            this.Imprimirbutton.Image = global::SistemaDeVentas.Properties.Resources.print;
            this.Imprimirbutton.Location = new System.Drawing.Point(41, 546);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(93, 65);
            this.Imprimirbutton.TabIndex = 92;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.ForeColor = System.Drawing.Color.Black;
            this.Buscarbutton.Image = global::SistemaDeVentas.Properties.Resources.search1;
            this.Buscarbutton.Location = new System.Drawing.Point(481, 103);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(95, 53);
            this.Buscarbutton.TabIndex = 89;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // ConsultaProveedorlabel
            // 
            this.ConsultaProveedorlabel.AutoSize = true;
            this.ConsultaProveedorlabel.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultaProveedorlabel.Location = new System.Drawing.Point(170, 39);
            this.ConsultaProveedorlabel.Name = "ConsultaProveedorlabel";
            this.ConsultaProveedorlabel.Size = new System.Drawing.Size(371, 40);
            this.ConsultaProveedorlabel.TabIndex = 93;
            this.ConsultaProveedorlabel.Text = "Consulta De Proveedores";
            // 
            // ConsultaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(785, 630);
            this.Controls.Add(this.ConsultaProveedorlabel);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.ConsultaProveedoressdataGridView);
            this.Controls.Add(this.Desdelabel);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.Hastalabel);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdeDateTimePicke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ConsultaProveedores";
            this.Text = "ConsultaProveedores";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaProveedoressdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.DataGridView ConsultaProveedoressdataGridView;
        private System.Windows.Forms.Label Desdelabel;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.Label Hastalabel;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ConsultaProveedorlabel;
    }
}