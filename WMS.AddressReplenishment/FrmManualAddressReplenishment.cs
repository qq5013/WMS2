using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.Globals;
using WMS.DataBaseLayers;

namespace WMS.AddressReplenishment
{
    public partial class FrmManualAddressReplenishment : XtraForm
    {
        public static string Description { get; set; }
        public static string Seria { get; set; }
        public static string ExpDate { get; set; }
        public static string Rotation { get; set; }
        public static string RestByPart { get; set; }
        public static string RestAllDep { get; set; }

        public static int IdPartRow { get; set; }
        public static decimal QtyForReplenishment { get; set; }

        public FrmManualAddressReplenishment()
        {
            InitializeComponent();
            catalogZonesTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
        }

        private void FrmManualAddressReplenishmentLoad(object sender, EventArgs e)
        {
            catalogZonesTableAdapter.Fill(wMSDataSet.CatalogZones);
        }

        private void FindSkuTextEditKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                #region Проверяем на то что выбрали зону
                if (zoneLookUpEdit.EditValue != null)
                {
                    var worker = new DataBaseLayers.AddressReplenishment();
                    var resCheckAddressZone = worker.CheckAddresForThisZone(findSkuTextEdit.Text,
                                                                             Convert.ToInt32(zoneLookUpEdit.EditValue));
                    #region Проверяем соответсвие адреса и зоны
                    if (resCheckAddressZone == 1)
                    {
                        #region Проверяем присваивался ли адрес какой либо партии
                        if (!worker.CheckLinkAddressWithPart(findSkuTextEdit.Text))
                        {
                            MessageBox.Show("Данный адрес не присваивался никогда никакой партии!", "Внимание!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        #endregion

                        #region Проверяем свободен ли адрес
                        if (worker.CheckAddressIsBusy(findSkuTextEdit.Text))
                        {

                            DataTable resultDt = worker.ManualReplenishmentGetInfoAddressDataTable(findSkuTextEdit.Text,
                                                                                            Convert.ToInt32(
                                                                                                zoneLookUpEdit.EditValue));
                            #region Получаем необходимые значения переменных партии для поиска
                            if (resultDt.Rows.Count > 1)
                            {
                                var frm =
                                    new FrmMultiPartOnAddressTo(findSkuTextEdit.Text,
                                                                Convert.ToInt32(zoneLookUpEdit.EditValue));

                                if (frm.ShowDialog() != DialogResult.OK)
                                {
                                    return;
                                }
                            }
                            else
                            {
                                IdPartRow = Convert.ToInt32(resultDt.Rows[0]["ID_PartRow"]);
                                Description = resultDt.Rows[0]["Description"].ToString();
                                Seria = resultDt.Rows[0]["Series"].ToString();
                                ExpDate = Convert.ToDateTime(resultDt.Rows[0]["ExpirationDate"]).ToString("yyyy-MM-dd");
                            }
                            #endregion

                            #region Ищем адреса для этой партии на втором складе
                            int idProduct = worker.ManualReplenishmentGetIdProductByAddress(findSkuTextEdit.Text);
                            var listFindedAddresses = worker.ListAddressesOnDepozitForReplenishmentForThisPart(
                                IdPartRow, idProduct);
                            if (listFindedAddresses != null)
                            {
                                var rot = new DbAddressAsignment();
                                var frmQty =
                                    new FrmManualEnterQty(Description, Seria, ExpDate,
                                                          Math.Round(
                                                              Convert.ToDecimal(
                                                                  rot.GetInfoRotation(idProduct).Rows[0]["Qty"]), 0).
                                                              ToString(),
                                                          Math.Round(
                                                              worker.ManualReplenishmentGetRestsByAllDepozitsByThisPart(
                                                                  IdPartRow, idProduct), 0).ToString(),
                                                          Math.Round(
                                                              worker.ManualReplenishmentGetRestsByAllDepozits(idProduct),
                                                              0).ToString());

                                frmQty.ShowDialog();

                               foreach (string listFindedAddress in listFindedAddresses)
                                {
                                    wMSDataSet.DocForManualReplenishment.AddDocForManualReplenishmentRow(0, 0,
                                                                                                         0, 0,
                                                                                                         IdPartRow,
                                                                                                         listFindedAddress,
                                                                                                         findSkuTextEdit
                                                                                                             .Text,
                                                                                                         QtyForReplenishment,
                                                                                                         idProduct,
                                                                                                         Description,
                                                                                                         Seria,
                                                                                                         Convert.
                                                                                                             ToDateTime(
                                                                                                                 ExpDate));
                                    
                                }
                            }

                            #endregion

                            /*
                            
                                    if (idProduct > 0)
                                    {
                                        

                                        if (worker.ManualReplenishmentGetRestsByAllDepozits(idProduct) != null &&
                                            worker.ManualReplenishmentGetRestsByAllDepozits(idProduct) > 0)
                                        {
                                            
                                        }
                                    }
                                }*/

                        }
                        else
                        {
                            DataTable resultDt = worker.GetInfoPartLastOnAddress(findSkuTextEdit.Text);

                            IdPartRow = Convert.ToInt32(resultDt.Rows[0]["ID_PartRow"]);
                            Description = resultDt.Rows[0]["Description"].ToString();
                            Seria = resultDt.Rows[0]["Series"].ToString();
                            ExpDate = Convert.ToDateTime(resultDt.Rows[0]["ExpirationDate"]).ToString("yyyy-MM-dd");

                            DataTable findAddressesOnDep2 =
                                worker.GetAddressesOnDepozitForReplenishmentForThisProduct(
                                    Convert.ToInt32(resultDt.Rows[0]["ID_Product"]));
                            if (findAddressesOnDep2.Rows.Count > 0)
                            {
                                if (findAddressesOnDep2.Rows.Count > 1)
                                {
                                    
                                }
                                else
                                {
                                    
                                }
                            }
                            else
                            {
                                XtraMessageBox.Show("");
                            }
                        }
                        
                        #endregion
                    }
                    else
                    {
                        switch (resCheckAddressZone)
                        {
                            case -1:
                                XtraMessageBox.Show("Такого адреса не существует!", "Внимание!", MessageBoxButtons.OK,
                                                    MessageBoxIcon.Warning);
                                break;
                            case 0:
                                XtraMessageBox.Show("Просканированый адрес не принадлежит зоне которую пополняем!",
                                                    "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                        }
                    }
                    #endregion

                }
                else
                {
                    XtraMessageBox.Show("Укажите зону!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                #endregion
            }
        }
    }
}