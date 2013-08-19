using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using WMS.Globals;

namespace WMS.Assembly
{
    public partial class FrmCollectator : XtraForm
    {
        public string Comment { get; set; }
        public FrmCollectator(string comment)
        {
            InitializeComponent();
            collectatoriTableAdapter.Connection.ConnectionString = GlobalParameters.OnixConnectionString;
            Comment = comment;
        }

        private void FrmCollectator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onixDataSet.Collectatori' table. You can move, or remove it, as needed.
            collectatoriTableAdapter.Fill(onixDataSet.Collectatori);
            commMemoEdit.Text = Comment;
        }

        private void gridLookUpEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void gridLookUpEdit1_Popup(object sender, EventArgs e)
        {
            collectGridLookUpEditView.FocusedRowHandle = GridControl.AutoFilterRowHandle;
            collectGridLookUpEditView.FocusedColumn = colCLT1002;
            collectGridLookUpEditView.ShowEditor();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (collectGridLookUpEdit.EditValue != null)
            {
                FrmAssembly.IdCollectator = Convert.ToInt32(collectGridLookUpEdit.EditValue);
                FrmAssembly.Comment = commMemoEdit.Text ?? "";
                Close();
                DialogResult = DialogResult.OK;
            }
            else
            XtraMessageBox.Show("Необходимо выбрать сборщика для данного заказа", "Внимание!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }
    }
}