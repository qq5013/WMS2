using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WMS.AddressReplenishment
{
    public partial class FrmAcceptanceReplenishmentList : DevExpress.XtraEditors.XtraForm
    {
        public FrmAcceptanceReplenishmentList()
        {
            InitializeComponent();
            replenishmentListInfoTableAdapter.Connection = Globals.GlobalParameters.WmsGlobalSqlConnection;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                var result = Globals.DecodeCode128.Decode(textEdit1.Text);

                if (result.IdReplDoc != 0)
                {
                    replenishmentListInfoTableAdapter.Fill(wMSDataSet.ReplenishmentListInfo,
                                                           result.IdReplDoc);
                    gridView1.ExpandAllGroups();
                    gridView1.BestFitColumns();
                    textBox1.Enabled = false;
                }
            }
        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                var result = Globals.DecodeCode128.Decode(textEdit1.Text);

                if (result.IdReplDoc != 0 && result.IdReplDocRow != 0)
                {
                    var worker = new DataBaseLayers.AddressMigration();
                    worker.RemovePartFromTranzit(result.IdReplDoc, result.IdReplDocRow);
                    
                    replenishmentListInfoTableAdapter.Fill(wMSDataSet.ReplenishmentListInfo, Convert.ToInt32(textBox1.Text));
                    gridView1.ExpandAllGroups();
                    gridView1.BestFitColumns();
                    textEdit1.Text = "";
                    textEdit1.Focus();
                }
            }
        }
    }
}