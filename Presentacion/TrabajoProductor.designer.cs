using System.Windows.Forms;

namespace Presentacion
{
    partial class TrabajoProductor
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboZ3 = new System.Windows.Forms.ComboBox();
            this.btnSubir = new System.Windows.Forms.Button();
            this.cboNitrato = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.listViewCriterios = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.cboPredios = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbZ3 = new System.Windows.Forms.RadioButton();
            this.rbz2 = new System.Windows.Forms.RadioButton();
            this.cboFertilizantes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 107);
            this.panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::Presentacion.Properties.Resources.exit;
            this.btnSalir.Location = new System.Drawing.Point(914, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(33, 25);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 7;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Presentacion.Properties.Resources.minimize;
            this.btnMinimizar.Location = new System.Drawing.Point(875, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(33, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(348, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido Productor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.cboZ3);
            this.panel2.Controls.Add(this.btnSubir);
            this.panel2.Controls.Add(this.cboNitrato);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.listViewCriterios);
            this.panel2.Controls.Add(this.cboPredios);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.rbZ3);
            this.panel2.Controls.Add(this.rbz2);
            this.panel2.Controls.Add(this.cboFertilizantes);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cboProductos);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 341);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cboZ3
            // 
            this.cboZ3.FormattingEnabled = true;
            this.cboZ3.Items.AddRange(new object[] {
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.2"});
            this.cboZ3.Location = new System.Drawing.Point(61, 283);
            this.cboZ3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboZ3.Name = "cboZ3";
            this.cboZ3.Size = new System.Drawing.Size(121, 23);
            this.cboZ3.TabIndex = 19;
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(838, 226);
            this.btnSubir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(99, 33);
            this.btnSubir.TabIndex = 18;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            // 
            // cboNitrato
            // 
            this.cboNitrato.FormattingEnabled = true;
            this.cboNitrato.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70"});
            this.cboNitrato.Location = new System.Drawing.Point(62, 186);
            this.cboNitrato.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboNitrato.Name = "cboNitrato";
            this.cboNitrato.Size = new System.Drawing.Size(121, 23);
            this.cboNitrato.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(70, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "nitrato del suelo:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFecha.Location = new System.Drawing.Point(806, 14);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 15);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "lblFecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(722, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha Actual:";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(838, 273);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(99, 33);
            this.btnexit.TabIndex = 12;
            this.btnexit.Text = "Salir";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(838, 177);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 33);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // listViewCriterios
            // 
            this.listViewCriterios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewCriterios.GridLines = true;
            this.listViewCriterios.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewCriterios.Location = new System.Drawing.Point(190, 93);
            this.listViewCriterios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listViewCriterios.Name = "listViewCriterios";
            this.listViewCriterios.Size = new System.Drawing.Size(640, 213);
            this.listViewCriterios.TabIndex = 10;
            this.listViewCriterios.UseCompatibleStateImageBehavior = false;
            this.listViewCriterios.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Producto";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fertilizacion";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Predio";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Z2.2 O Z3.0";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fecha";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Criterios";
            this.columnHeader6.Width = 100;
            // 
            // cboPredios
            // 
            this.cboPredios.FormattingEnabled = true;
            this.cboPredios.Items.AddRange(new object[] {
            ">Zona oeste",
            ">Zona este",
            ">Zona central"});
            this.cboPredios.Location = new System.Drawing.Point(214, 47);
            this.cboPredios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboPredios.Name = "cboPredios";
            this.cboPredios.Size = new System.Drawing.Size(121, 23);
            this.cboPredios.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(214, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Elige su predios:";
            // 
            // rbZ3
            // 
            this.rbZ3.AutoSize = true;
            this.rbZ3.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbZ3.Location = new System.Drawing.Point(88, 226);
            this.rbZ3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbZ3.Name = "rbZ3";
            this.rbZ3.Size = new System.Drawing.Size(47, 19);
            this.rbZ3.TabIndex = 7;
            this.rbZ3.TabStop = true;
            this.rbZ3.Text = "Z3.0";
            this.rbZ3.UseVisualStyleBackColor = true;
            // 
            // rbz2
            // 
            this.rbz2.AutoSize = true;
            this.rbz2.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbz2.Location = new System.Drawing.Point(88, 253);
            this.rbz2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbz2.Name = "rbz2";
            this.rbz2.Size = new System.Drawing.Size(47, 19);
            this.rbz2.TabIndex = 6;
            this.rbz2.TabStop = true;
            this.rbz2.Text = "Z2.2";
            this.rbz2.UseVisualStyleBackColor = true;
            // 
            // cboFertilizantes
            // 
            this.cboFertilizantes.FormattingEnabled = true;
            this.cboFertilizantes.Items.AddRange(new object[] {
            ">Nitrogeno",
            ">Fosforo"});
            this.cboFertilizantes.Location = new System.Drawing.Point(62, 117);
            this.cboFertilizantes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboFertilizantes.Name = "cboFertilizantes";
            this.cboFertilizantes.Size = new System.Drawing.Size(121, 23);
            this.cboFertilizantes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(62, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Elige la Fertelizacion";
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Items.AddRange(new object[] {
            "-> Frutas",
            "      >Manzanas",
            "      >Naranjas",
            "      >Limones",
            "",
            "-----------------------------",
            "",
            "-> Verduras",
            "     >Papas rosadas",
            "     >Zapallo criollo ",
            "",
            "-----------------------------",
            "",
            "->Cereales ",
            "      >Trigo",
            "      >Cebada"});
            this.cboProductos.Location = new System.Drawing.Point(62, 47);
            this.cboProductos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(121, 23);
            this.cboProductos.TabIndex = 3;
            this.cboProductos.SelectedIndexChanged += new System.EventHandler(this.cboProductos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(62, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elige un productos:";
            // 
            // TrabajoProductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 448);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TrabajoProductor";
            this.Text = "TrabajoProductor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private ComboBox cboPredios;
        private Label label4;
        private RadioButton rbZ3;
        private RadioButton rbz2;
        private ComboBox cboFertilizantes;
        private Label label3;
        private ComboBox cboProductos;
        private Label label2;
        private Button btnGuardar;
        private ListView listViewCriterios;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnexit;
        private Label label5;
        private Label lblFecha;
        private Label label6;
        private ComboBox cboNitrato;
        private Button btnSubir;
        private ComboBox cboZ3;
        private PictureBox btnSalir;
        private PictureBox btnMinimizar;
    }
}