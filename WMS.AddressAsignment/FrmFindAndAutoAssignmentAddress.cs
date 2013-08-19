using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.DataBaseLayers;

namespace WMS.AddressAsignment
{
    public partial class FrmFindAndAutoAssignmentAddress : XtraForm
    {
        public int IdProduct { get; set; }
        public int AllowQty { get; set; }


        public FrmFindAndAutoAssignmentAddress(int idProduct, int allowQty)
        {
            InitializeComponent();
            IdProduct = idProduct;
            AllowQty = allowQty;
            allowQtyTextEdit.Text = AllowQty.ToString();
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            wMSDataSet.NeededTypeAndQtyCells.Clear();
            wMSDataSet.FindedAddresses.Clear();
            var worker = new AddressAssignmentAuto();

            var ds = worker.GetInfoCellsAndFindCellsForProduct(IdProduct, Convert.ToInt32(qtySpinEdit.Value));
            
            wMSDataSet.NeededTypeAndQtyCells.Merge(ds.Tables["NeededTypeAndQtyCells"]);
            wMSDataSet.FindedAddresses.Merge(ds.Tables["FindedAddresses"]);


            //DialogResult = DialogResult.OK;
            //Close();

        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            Close();
        }
    }
}