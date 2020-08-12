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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void cmbOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOption.SelectedIndex == 0)
            {
                dgvData.DataSource = clsConnection.instance.Load_Data("prods");
            }
            else
            {
                dgvData.DataSource = clsConnection.instance.Load_Data("detalles");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cmbOption.SelectedIndex == 0)
            {
                frmProductos prods = new frmProductos();
                prods.ShowDialog();
            }
            else
            {
                frmDetalles detalles = new frmDetalles();
                detalles.ShowDialog();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbOption.SelectedIndex == 0)
            {
                frmProductos prods = new frmProductos();
                prods.id = int.Parse(dgvData.Rows[dgvData.CurrentRow.Index].Cells[0].Value.ToString());
                prods.txProd.Text = dgvData.Rows[dgvData.CurrentRow.Index].Cells[1].Value.ToString();
                prods.txtTipo.Text = dgvData.Rows[dgvData.CurrentRow.Index].Cells[2].Value.ToString();
                prods.txtProv.Text = dgvData.Rows[dgvData.CurrentRow.Index].Cells[3].Value.ToString();
                prods.txtMarca.Text = dgvData.Rows[dgvData.CurrentRow.Index].Cells[4].Value.ToString();
                prods.txtCod.Text = dgvData.Rows[dgvData.CurrentRow.Index].Cells[5].Value.ToString();
                prods.btnInsert.Text = "Actualizar";
                prods.ShowDialog();
            }
            else
            {
                frmDetalles dets = new frmDetalles();
                dets.txtPrecComp.Text = dgvData.Rows[dgvData.CurrentRow.Index].Cells[2].Value.ToString();
                dets.txtprecVenta.Text = dgvData.Rows[dgvData.CurrentRow.Index].Cells[3].Value.ToString();
                dets.txtStock.Text = dgvData.Rows[dgvData.CurrentRow.Index].Cells[4].Value.ToString();
                dets.txtGanancia.Text = dgvData.Rows[dgvData.CurrentRow.Index].Cells[5].Value.ToString();
                dets.btnInsert.Text = "Actualizar";
                dets.ShowDialog();
            }
        }
        int idp;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbOption.SelectedIndex == 0)
            {
                idp = int.Parse(dgvData.Rows[dgvData.CurrentRow.Index].Cells[0].Value.ToString());
                clsConnection.instance.All_prods("delete", "", "", "", "", "", idp);
                MessageBox.Show("Eliminacion correcta..");
                clsConnection.instance.Load_Data("prods");
            }else{
                idp = int.Parse(dgvData.Rows[dgvData.CurrentRow.Index].Cells[0].Value.ToString());
                clsConnection.instance.All_details("delete", 0, 0, 0, 0, 0, idp);
                MessageBox.Show("Eliminacion correcta..");
                clsConnection.instance.Load_Data("detalles");
            }
        }
    }
}
