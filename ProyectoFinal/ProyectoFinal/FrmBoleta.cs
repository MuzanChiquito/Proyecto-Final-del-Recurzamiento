/*
 * Created by SharpDevelop.
 * User: crist
 * Date: 15/12/2025
 * Time: 12:05 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal
{
	/// <summary>
	/// Description of FrmBoleta.
	/// </summary>
	public partial class FrmBoleta : Form
	{
		public FrmBoleta()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
	
private void btnAgregarClick(object sender, EventArgs e)
{
    if (txtMateria.Text == "" || txtCalificacion.Text == "")
    {
        MessageBox.Show("Llene todos los campos");
        return;
    }

    ListViewItem item = new ListViewItem(txtMateria.Text);
    item.SubItems.Add(txtCalificacion.Text);

    listView1.Items.Add(item);

    txtMateria.Clear();
    txtCalificacion.Clear();
    txtMateria.Focus();
}
			
		
	}
}
