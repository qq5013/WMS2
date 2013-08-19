using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WMS.AddressAsignment
{
    public partial class FrmListNonAcceptedDocs : XtraForm
    {
        public FrmListNonAcceptedDocs()
        {
            InitializeComponent();
            listRowsDocTableAdapter.Connection = Globals.GlobalParameters.OnixGlobalSqlConnection;
            listDocTableAdapter.Connection = Globals.GlobalParameters.OnixGlobalSqlConnection;
        }

        private void FrmListNonAcceptedDocsLoad(object sender, EventArgs e)
        {
            listDocTableAdapter.Fill(wMSDataSet.ListDoc);
            docsGridView.Focus();
        }

        private void DocsGridViewFocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (docsGridView.FocusedRowHandle >= 0)
            {
                listRowsDocTableAdapter.Fill(wMSDataSet.ListRowsDoc,
                                             Convert.ToInt32(docsGridView.GetRowCellValue(e.FocusedRowHandle, colDocId)));
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.None;
        }

        private void AcceptButtonClick(object sender, EventArgs e)
        {
            if (docsGridView.FocusedRowHandle >= 0)
            {
                FrmAddressAsignmentOnNonAcceptedDoc.SetIdDoc(Convert.ToInt32(docsGridView.GetRowCellValue(docsGridView.FocusedRowHandle, colDocId)));
                Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                XtraMessageBox.Show("Необходимо выбрать приход!", "Внимание!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
            
        }
    }
}