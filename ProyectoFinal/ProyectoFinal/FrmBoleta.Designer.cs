/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 15/12/2025
 * Time: 12:05 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoFinal
{
	partial class FrmBoleta
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMateria = new System.Windows.Forms.TextBox();
			this.txtCalificacion = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Materia";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Calificación";
			// 
			// txtMateria
			// 
			this.txtMateria.Location = new System.Drawing.Point(118, 30);
			this.txtMateria.Name = "txtMateria";
			this.txtMateria.Size = new System.Drawing.Size(100, 22);
			this.txtMateria.TabIndex = 2;
			// 
			// txtCalificacion
			// 
			this.txtCalificacion.Location = new System.Drawing.Point(118, 58);
			this.txtCalificacion.Name = "txtCalificacion";
			this.txtCalificacion.Size = new System.Drawing.Size(100, 22);
			this.txtCalificacion.TabIndex = 3;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(12, 107);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(90, 35);
			this.btnAgregar.TabIndex = 4;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregarClick);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2});
			this.listView1.Location = new System.Drawing.Point(118, 107);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(377, 201);
			this.listView1.TabIndex = 5;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Materia";
			this.columnHeader1.Width = 120;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Calificación";
			this.columnHeader2.Width = 100;
			// 
			// FrmBoleta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 340);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtCalificacion);
			this.Controls.Add(this.txtMateria);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmBoleta";
			this.Text = "FrmBoleta";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.TextBox txtCalificacion;
		private System.Windows.Forms.TextBox txtMateria;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
