using System.Windows.Forms;

namespace ProductorDES
{
    partial class PrincipalProd
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
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnPredio = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnTrabajo = new System.Windows.Forms.Button();
            this.panelInicial = new System.Windows.Forms.Panel();
            this.panelTitulo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(756, 92);
            this.panelTitulo.TabIndex = 0;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(273, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenido Productor ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.btnProductos);
            this.panel2.Controls.Add(this.btnPredio);
            this.panel2.Controls.Add(this.btnCompra);
            this.panel2.Controls.Add(this.btnTrabajo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 364);
            this.panel2.TabIndex = 1;
            // 
            // btnProductos
            // 
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProductos.Location = new System.Drawing.Point(4, 175);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(168, 51);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnPredio
            // 
            this.btnPredio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPredio.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPredio.Location = new System.Drawing.Point(4, 254);
            this.btnPredio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPredio.Name = "btnPredio";
            this.btnPredio.Size = new System.Drawing.Size(168, 51);
            this.btnPredio.TabIndex = 0;
            this.btnPredio.Text = "Predio";
            this.btnPredio.UseVisualStyleBackColor = true;
            this.btnPredio.Click += new System.EventHandler(this.btnPredio_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCompra.Location = new System.Drawing.Point(4, 97);
            this.btnCompra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(168, 57);
            this.btnCompra.TabIndex = 3;
            this.btnCompra.Text = "Compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnTrabajo
            // 
            this.btnTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrabajo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTrabajo.Location = new System.Drawing.Point(4, 20);
            this.btnTrabajo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTrabajo.Name = "btnTrabajo";
            this.btnTrabajo.Size = new System.Drawing.Size(168, 57);
            this.btnTrabajo.TabIndex = 2;
            this.btnTrabajo.Text = "Trabajo";
            this.btnTrabajo.UseVisualStyleBackColor = true;
            this.btnTrabajo.Click += new System.EventHandler(this.btnTrabajo_Click);
            // 
            // panelInicial
            // 
            this.panelInicial.BackColor = System.Drawing.Color.Silver;
            this.panelInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInicial.Location = new System.Drawing.Point(175, 92);
            this.panelInicial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelInicial.Name = "panelInicial";
            this.panelInicial.Size = new System.Drawing.Size(581, 364);
            this.panelInicial.TabIndex = 2;
            // 
            // PrincipalProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 456);
            this.Controls.Add(this.panelInicial);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PrincipalProd";
            this.Text = "PrincipalProd";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTitulo;
        private Panel panel2;
        private Button btnCompra;
        private Button btnTrabajo;
        private Panel panelInicial;
        private Label label1;
        private Button btnPredio;
        private Button btnProductos;
    }
}