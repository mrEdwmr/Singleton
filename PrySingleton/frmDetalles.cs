using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrySingleton
{
    public partial class frmDetalles : Form
    {
        public frmDetalles()
        {
            InitializeComponent();
            cmbProd.DataSource = clsConnection.instance.Load_Data("prods");
            cmbProd.DisplayMember = "Producto";
            cmbProd.ValueMember = "ID";
        }
        public int id;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (btnInsert.Text == "Insert")
            {
                clsConnection.instance.All_details("insert", cmbProd.SelectedIndex, float.Parse(txtPrecComp.Text), float.Parse(txtprecVenta.Text), int.Parse(txtStock.Text), float.Parse(txtGanancia.Text), 0);
                MessageBox.Show("Insercion lista..");
                clsConnection.instance.Load_Data("prods");
            }
            else
            {
                clsConnection.instance.All_details("Update", cmbProd.SelectedIndex, float.Parse(txtPrecComp.Text), float.Parse(txtprecVenta.Text), int.Parse(txtStock.Text), float.Parse(txtGanancia.Text), id);
                clsConnection.instance.Load_Data("prods");
                this.Close();
                MessageBox.Show("Actualizacion lista..");
            }
        }
    }
}
