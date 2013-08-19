using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.Globals;
using WMS.DataBaseLayers;

namespace WMS.Inventory
{
    public partial class FrmInventory : XtraForm
    {
        public int NumDoc { get; set; }
        public FrmInventory()
        {
            InitializeComponent();
        }

        private void FrmInventoryLoad(object sender, System.EventArgs e)
        {
            

        }

        private void NewDocButtonClick(object sender, System.EventArgs e)
        {
            var worker = new InventoryAddresses();
            NumDoc = worker.CreateNewDocInventory();
            numDocTextEdit.Text = NumDoc.ToString();
            docsRowsInventoryTableAdapter.Fill(wMSDataSet.DocsRowsInventory, NumDoc);
        }

        private void FindTextEditKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                
            }
        }
        
    }
}