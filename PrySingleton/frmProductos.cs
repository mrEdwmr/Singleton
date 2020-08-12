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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        public int id; 
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (btnInsert.Text == "Insert")
            {
                clsConnection.instance.All_prods("insert", txProd.Text, txtTipo.Text, txtProv.Text, txtMarca.Text, txtCod.Text, 0);
                MessageBox.Show("Insercion lista..");
                clsConnection.instance.Load_Data("prods");
            }
            else {
                clsConnection.instance.All_prods("Update", txProd.Text, txtTipo.Text, txtProv.Text, txtMarca.Text, txtCod.Text, id);
                clsConnection.instance.Load_Data("prods");
                this.Close();
                MessageBox.Show("Actualizacion lista..");
            }
        }
    }
}
