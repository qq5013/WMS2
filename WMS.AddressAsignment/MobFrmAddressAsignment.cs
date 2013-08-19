using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.Globals;

namespace WMS.AddressAsignment
{
    public partial class MobFrmAddressAsignment : DevExpress.XtraEditors.XtraForm
    {
        public MobFrmAddressAsignment()
        {
            InitializeComponent();
        }

        private void MobFrmAddressAsignmentLoad(object sender, EventArgs e)
        {
            findSkuTextEdit.Focus();
            getPartsFromSystemTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void FindSkuTextEditKeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left || e.KeyData == Keys.Right)
            {
                findSkuTextEdit.Focus();
                findSkuTextEdit.SelectAll();
            }
            if (e.KeyCode == Keys.Enter)
            {
                SearchGood();
            }
        }

        int typeRestGoods = 0;
        private void SearchGood()
        {
            
            if (typeRestGoods >= 0)
            {
                switch (typeRestGoods)
                {
                    case 0:

                        if (ObjectsForAddressAsignmets.DSsell == null)
                        {
                            var sellFrm = new FrmDirGoods(TypeOfGoods.SellGood) { Owner = this };
                        }

                        DataRow[] sellResult = new DataRow[1];
                        if (findSkuTextEdit.Text.Length <= 5)
                        {
                            sellResult = ObjectsForAddressAsignmets.DSsell.Select("ID = " + findSkuTextEdit.EditValue);
                        }
                        else
                        {
                            sellResult = ObjectsForAddressAsignmets.DSsell.Select("BarCode = '" + findSkuTextEdit.EditValue + "'");
                        }


                        if (sellResult.Length != 0)
                        {
                            foreach (var row in sellResult)
                            {
                                ObjectsForAddressAsignmets.SkuIdFromDirs = Convert.ToInt32(row["ID"]);
                                ObjectsForAddressAsignmets.LastFocusedSkuId = ObjectsForAddressAsignmets.SkuIdFromDirs;
                                findSkuTextEdit.Text = row["ID"].ToString();
                                descriptionLabelControl.Text = row["Description"].ToString();
                            }
                            GetPartForSellGood();
                            findSkuTextEdit.Focus();
                            findSkuTextEdit.SelectAll();
                        }
                        else
                            XtraMessageBox.Show(" Товар не найден! ", " Внимание !", MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                        findSkuTextEdit.Text = ObjectsForAddressAsignmets.LastFocusedSkuId.ToString();
                        findSkuTextEdit.SelectAll();
                        break;
                        /*
                    case 1:
                        if (ObjectsForAddressAsignmets.DSlab == null)
                        {
                            var labFrm = new FrmDirGoods(TypeOfGoods.LabGood) { Owner = this };
                        }

                        DataRow[] labresult = new DataRow[1];
                        if (findSkuButtonEdit.Text.Length <= 5)
                        {
                            labresult = ObjectsForAddressAsignmets.DSlab.Select("ID = " + findSkuButtonEdit.EditValue);
                        }
                        else
                        {
                            labresult = ObjectsForAddressAsignmets.DSlab.Select("BarCode = '" + findSkuButtonEdit.EditValue + "'");
                        }


                        if (labresult.Length != 0)
                        {
                            foreach (var row in labresult)
                            {
                                ObjectsForAddressAsignmets.SkuIdFromDirs = Convert.ToInt32(row["ID"]);
                                ObjectsForAddressAsignmets.LastFocusedSkuId = ObjectsForAddressAsignmets.SkuIdFromDirs;
                                findSkuButtonEdit.Text = row["ID"].ToString();
                                goodDescriptionTextEdit.Text = row["Description"].ToString();
                            }
                            GetPartForLabGood();
                            findSkuButtonEdit.Focus();
                            findSkuButtonEdit.SelectAll();
                        }
                        else
                            XtraMessageBox.Show(" Товар не найден! ", " Внимание !", MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                        findSkuButtonEdit.Text = ObjectsForAddressAsignmets.LastFocusedSkuId.ToString();
                        findSkuButtonEdit.SelectAll();
                        break;
                         * */
                }


            }
            else
            {
                XtraMessageBox.Show("Укажите тип остатков!", "Внимание !!!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }

        private void GetPartForSellGood()
        {
            getPartsFromSystemTableAdapter.FillSell(partsFromSystemDataSet.GetPartsFromSystem, ObjectsForAddressAsignmets.SkuIdFromDirs, typeRestGoods);
            addressAsignmentGridView.ExpandAllGroups();
            addressAsignmentGridView.BestFitColumns();
            DataRow[] resultExists = partsFromSystemDataSet.GetPartsFromSystem.Select("addAddress = 1");
            DataRow[] resultNotExists = partsFromSystemDataSet.GetPartsFromSystem.Select("addAddress = 0");
        }
    }
}