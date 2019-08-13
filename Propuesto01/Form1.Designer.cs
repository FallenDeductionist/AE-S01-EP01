namespace Propuesto01
{
	partial class Form1
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
			this.dgClientes = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.tbBusqueda = new System.Windows.Forms.TextBox();
			this.lblCantidad = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// dgClientes
			// 
			this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgClientes.Location = new System.Drawing.Point(54, 134);
			this.dgClientes.Name = "dgClientes";
			this.dgClientes.Size = new System.Drawing.Size(687, 150);
			this.dgClientes.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(79, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "NOMBRE DEL CLIENTE";
			// 
			// tbBusqueda
			// 
			this.tbBusqueda.Location = new System.Drawing.Point(247, 78);
			this.tbBusqueda.Name = "tbBusqueda";
			this.tbBusqueda.Size = new System.Drawing.Size(478, 20);
			this.tbBusqueda.TabIndex = 2;
			this.tbBusqueda.TextChanged += new System.EventHandler(this.TbBusqueda_TextChanged);
			// 
			// lblCantidad
			// 
			this.lblCantidad.Location = new System.Drawing.Point(625, 341);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(100, 20);
			this.lblCantidad.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(363, 344);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "TOTAL DE CLIENTES";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblCantidad);
			this.Controls.Add(this.tbBusqueda);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgClientes);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgClientes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbBusqueda;
		private System.Windows.Forms.TextBox lblCantidad;
		private System.Windows.Forms.Label label2;
	}
}

