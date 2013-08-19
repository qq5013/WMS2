using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using WMS.Globals;


namespace WMS.CheckAddress
{
    public partial class FrmCheckAddress : XtraForm
    {
        public FrmCheckAddress()
        {
            InitializeComponent();
            checkAddressTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
            getRestsFromAllDepozitsTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
            descriptionLabelControl.Text = "";
            artLabelControl.Text = "";
            seriaLabelControl.Text = "";
            expDateLabelControl.Text = "";
        }

        private void FindTextEditKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (findTextEdit.Text.Length != 0)
                {
                    wMSDataSet.GetRestsFromAllDepozits.Clear();
                    descriptionLabelControl.Text = "";
                    artLabelControl.Text = "";
                    seriaLabelControl.Text = "";
                    expDateLabelControl.Text = "";

                    checkAddressTableAdapter.Fill(wMSDataSet.CheckAddress, findTextEdit.Text);
                    if (wMSDataSet.CheckAddress.Rows.Count == 0)
                    {
                        

                    }
                    lastProductsOnAddressGridView.BestFitColumns();
                    lastProductsOnAddressGridView.ExpandAllGroups();
                    findTextEdit.Text = "";
                    findTextEdit.Focus();
                }
                else
                {
                    wMSDataSet.CheckAddress.Clear();
                    wMSDataSet.GetRestsFromAllDepozits.Clear();
                    descriptionLabelControl.Text = "";
                    artLabelControl.Text = "";
                    seriaLabelControl.Text = "";
                    expDateLabelControl.Text = "";
                }
            }
        }

        private void LastProductsOnAddressGridViewFocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (lastProductsOnAddressGridView.FocusedRowHandle >= 0)
            {
                descriptionLabelControl.Text =
                    lastProductsOnAddressGridView.GetRowCellValue(e.FocusedRowHandle, colDescription).ToString();
                artLabelControl.Text =
                    lastProductsOnAddressGridView.GetRowCellValue(e.FocusedRowHandle, colID_Product).ToString();
                seriaLabelControl.Text  =
                    lastProductsOnAddressGridView.GetRowCellValue(e.FocusedRowHandle, colSeries).ToString();
                expDateLabelControl.Text =
                    Convert.ToDateTime(lastProductsOnAddressGridView.GetRowCellValue(e.FocusedRowHandle, colExpirationDate)).ToString("yyyy-MM-dd");

                getRestsFromAllDepozitsTableAdapter.Fill(wMSDataSet.GetRestsFromAllDepozits,
                                                         Convert.ToInt32(
                                                             lastProductsOnAddressGridView.GetRowCellValue(
                                                                 e.FocusedRowHandle, colID_PartRow)),
                                                         Convert.ToInt32(
                                                             lastProductsOnAddressGridView.GetRowCellValue(
                                                                 e.FocusedRowHandle, colID_Product)));
                infoAboutProductGridView.BestFitColumns();
                findTextEdit.Focus();
            }
        }
    }
}