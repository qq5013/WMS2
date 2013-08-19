using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.DataBaseLayers;
using WMS.Globals;

namespace WMS.ReferenceAddressWithCells
{
    public partial class FrmReferenceAddressWithCells : XtraForm
    {
        public int FindedSku { get; set; }
        public static string FindedAddress { get; set; }
        public int Cell { get; set; }
        public FrmReferenceAddressWithCells()
        {
            InitializeComponent();
            saveCellButton.Enabled = false;
            execCrushShelfTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
            calcCellsGridView.BestFitColumns();
            Cell = -1;
        }

        private void CheckButton1CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkButton1.Checked)
            {
                Cell = 1;

                checkButton2.Checked = false;
                checkButton2.Enabled = false;

                checkButton3.Checked = false;
                checkButton3.Enabled = false;

                checkButton4.Checked = false;
                checkButton4.Enabled = false;

                checkButton5.Checked = false;
                checkButton5.Enabled = false;

                checkButton6.Checked = false;
                checkButton6.Enabled = false;

                checkButton7.Checked = false;
                checkButton7.Enabled = false;

                saveCellButton.Enabled = true;
            }
            else
            {
                Cell = -1;

                checkButton2.Checked = false;
                checkButton2.Enabled = true;

                checkButton3.Checked = false;
                checkButton3.Enabled = true;

                checkButton4.Checked = false;
                checkButton4.Enabled = true;

                checkButton5.Checked = false;
                checkButton5.Enabled = true;

                checkButton6.Checked = false;
                checkButton6.Enabled = true;

                checkButton7.Checked = false;
                checkButton7.Enabled = true;

                saveCellButton.Enabled = false;
            }
        }

        private void CheckButton2CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkButton2.Checked)
            {
                Cell = 2;

                checkButton1.Checked = false;
                checkButton1.Enabled = false;

                checkButton3.Checked = false;
                checkButton3.Enabled = false;

                checkButton4.Checked = false;
                checkButton4.Enabled = false;

                checkButton5.Checked = false;
                checkButton5.Enabled = false;

                checkButton6.Checked = false;
                checkButton6.Enabled = false;

                checkButton7.Checked = false;
                checkButton7.Enabled = false;

                saveCellButton.Enabled = true;
            }
            else
            {
                Cell = -1;

                checkButton1.Checked = false;
                checkButton1.Enabled = true;

                checkButton3.Checked = false;
                checkButton3.Enabled = true;

                checkButton4.Checked = false;
                checkButton4.Enabled = true;

                checkButton5.Checked = false;
                checkButton5.Enabled = true;

                checkButton6.Checked = false;
                checkButton6.Enabled = true;

                checkButton7.Checked = false;
                checkButton7.Enabled = true;

                saveCellButton.Enabled = false;
            }
        }

        private void CheckButton3CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkButton3.Checked)
            {
                Cell = 3;

                checkButton1.Checked = false;
                checkButton1.Enabled = false;

                checkButton2.Checked = false;
                checkButton2.Enabled = false;

                checkButton4.Checked = false;
                checkButton4.Enabled = false;

                checkButton5.Checked = false;
                checkButton5.Enabled = false;

                checkButton6.Checked = false;
                checkButton6.Enabled = false;

                checkButton7.Checked = false;
                checkButton7.Enabled = false;

                saveCellButton.Enabled = true;
            }
            else
            {
                Cell = -1;

                checkButton1.Checked = false;
                checkButton1.Enabled = true;

                checkButton2.Checked = false;
                checkButton2.Enabled = true;

                checkButton4.Checked = false;
                checkButton4.Enabled = true;

                checkButton5.Checked = false;
                checkButton5.Enabled = true;

                checkButton6.Checked = false;
                checkButton6.Enabled = true;

                checkButton7.Checked = false;
                checkButton7.Enabled = true;

                saveCellButton.Enabled = false;
            }
        }

        private void CheckButton4CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkButton4.Checked)
            {
                Cell = 4;

                checkButton1.Checked = false;
                checkButton1.Enabled = false;

                checkButton2.Checked = false;
                checkButton2.Enabled = false;

                checkButton3.Checked = false;
                checkButton3.Enabled = false;

                checkButton5.Checked = false;
                checkButton5.Enabled = false;

                checkButton6.Checked = false;
                checkButton6.Enabled = false;

                checkButton7.Checked = false;
                checkButton7.Enabled = false;

                saveCellButton.Enabled = true;
            }
            else
            {
                Cell = -1;

                checkButton1.Checked = false;
                checkButton1.Enabled = true;

                checkButton2.Checked = false;
                checkButton2.Enabled = true;

                checkButton3.Checked = false;
                checkButton3.Enabled = true;

                checkButton5.Checked = false;
                checkButton5.Enabled = true;

                checkButton6.Checked = false;
                checkButton6.Enabled = true;

                checkButton7.Checked = false;
                checkButton7.Enabled = true;

                saveCellButton.Enabled = false;
            }
        }

        private void CheckButton5CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkButton5.Checked)
            {
                Cell = 5;

                checkButton1.Checked = false;
                checkButton1.Enabled = false;

                checkButton2.Checked = false;
                checkButton2.Enabled = false;

                checkButton3.Checked = false;
                checkButton3.Enabled = false;

                checkButton4.Checked = false;
                checkButton4.Enabled = false;

                checkButton6.Checked = false;
                checkButton6.Enabled = false;

                checkButton7.Checked = false;
                checkButton7.Enabled = false;

                saveCellButton.Enabled = true;
            }
            else
            {
                Cell = -1;

                checkButton1.Checked = false;
                checkButton1.Enabled = true;

                checkButton2.Checked = false;
                checkButton2.Enabled = true;

                checkButton3.Checked = false;
                checkButton3.Enabled = true;

                checkButton4.Checked = false;
                checkButton4.Enabled = true;

                checkButton6.Checked = false;
                checkButton6.Enabled = true;

                checkButton7.Checked = false;
                checkButton7.Enabled = true;

                saveCellButton.Enabled = false;
            }
        }

        private void CheckButton6CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkButton6.Checked)
            {
                Cell = 6;

                checkButton1.Checked = false;
                checkButton1.Enabled = false;

                checkButton2.Checked = false;
                checkButton2.Enabled = false;

                checkButton3.Checked = false;
                checkButton3.Enabled = false;

                checkButton4.Checked = false;
                checkButton4.Enabled = false;

                checkButton5.Checked = false;
                checkButton5.Enabled = false;

                checkButton7.Checked = false;
                checkButton7.Enabled = false;

                saveCellButton.Enabled = true;
            }
            else
            {
                Cell = -1;

                checkButton1.Checked = false;
                checkButton1.Enabled = true;

                checkButton2.Checked = false;
                checkButton2.Enabled = true;

                checkButton3.Checked = false;
                checkButton3.Enabled = true;

                checkButton4.Checked = false;
                checkButton4.Enabled = true;

                checkButton5.Checked = false;
                checkButton5.Enabled = true;

                checkButton7.Checked = false;
                checkButton7.Enabled = true;

                saveCellButton.Enabled = false;
            }
        }

        private void CheckButton7CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkButton7.Checked)
            {
                Cell = 7;

                checkButton1.Checked = false;
                checkButton1.Enabled = false;

                checkButton2.Checked = false;
                checkButton2.Enabled = false;

                checkButton3.Checked = false;
                checkButton3.Enabled = false;

                checkButton4.Checked = false;
                checkButton4.Enabled = false;

                checkButton5.Checked = false;
                checkButton5.Enabled = false;

                checkButton6.Checked = false;
                checkButton6.Enabled = false;

                saveCellButton.Enabled = true;
            }
            else
            {
                Cell = -1;

                checkButton1.Checked = false;
                checkButton1.Enabled = true;

                checkButton2.Checked = false;
                checkButton2.Enabled = true;

                checkButton3.Checked = false;
                checkButton3.Enabled = true;

                checkButton4.Checked = false;
                checkButton4.Enabled = true;

                checkButton5.Checked = false;
                checkButton5.Enabled = true;

                checkButton6.Checked = false;
                checkButton6.Enabled = true;

                saveCellButton.Enabled = false;
            }
        }

        private void FindSkuButtonClick(object sender, System.EventArgs e)
        {
            var worker = new AddressMigration();
            var worker2 = new DataBaseLayers.ReferenceAddressWithCells();
            if (findSkuTextEdit.Text == "")
            {
                XtraMessageBox.Show("Необходимо указать или адрес или просканировать товар", "Внимание!!!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (referenceAllAddressesCheckEdit.CheckState != CheckState.Checked)
            {
                var result =
                    worker.FindSku(findSkuTextEdit.Text.Substring(findSkuTextEdit.Text.Length - 1, 1) == ";"
                                       ? findSkuTextEdit.Text.Substring(0, findSkuTextEdit.Text.Length - 1)
                                       : findSkuTextEdit.Text);

                if (result.IdSku > 0)
                {
                    FindedSku = result.IdSku;
                    

                    var dt = worker2.GetListAddressForProduct(result.IdSku);

                    if (dt != null && dt.Rows.Count != 0)
                    {
                        if (dt.Rows.Count > 1 && result.FoundSkuBy != FoundSkuBy.Address)
                        {
                            var frm = new FrmListAddresses(result.IdSku);
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                findSkuTextEdit.Text = FindedAddress;
                                findSkuTextEdit.SendKey(new KeyEventArgs(Keys.Enter));
                            }
                        }
                        else
                        {
                            addressProductLabelControl.Text = dt.Rows.Count > 1
                                                                  ? findSkuTextEdit.Text
                                                                  : dt.Select()[0]["ADDRESS"].ToString();

                            descriptionProductLabelControl.Text = worker2.GetDescriptionProduct(result.IdSku);
                            typeRotationLabelControl.Text = worker2.GetTypeRotaton(result.IdSku);
                            qtyMaxRotationLabelControl.Text = worker2.GetMaxQtyByRotation(result.IdSku);
                            typeCellLabelControl.Text = worker2.GetTypeCellForAddress(addressProductLabelControl.Text);
                            dateReferenceAddressLabelControl.Text =
                                worker2.GetUpdateDateCellForAddress(addressProductLabelControl.Text);
                            execCrushShelfTableAdapter.Fill(wMSDataSet.ExecCrushShelf, result.IdSku, null, 90, 1, 15,
                                                            null);
                            findSkuTextEdit.Text = result.IdSku.ToString();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Ненайдена ни одна партия с адресом для данного товара", "Внимание!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        addressProductLabelControl.Text = "";
                        wMSDataSet.ExecCrushShelf.Clear();
                    }
                }

                else
                {
                    XtraMessageBox.Show("Введены не корректные данные, попробуйте ещё раз!", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    /*
                    skuDescriptionLabelControl.Text = "Не найден тоавр для данного запроса!";
                    skuDescriptionLabelControl.ForeColor = Color.Red;
                    splitContainerControl1.Visible = false;
                    moveAllQtyButton.Enabled = false;
                    movePartialQtyButton.Enabled = false;
                    cleanAddressButton.Enabled = false;
                     * */
                }
            }
            else
            {
                if (findSkuTextEdit.Text.Substring(0,1) == "D")
                {
                    if (worker.FindIdAddressFromCatalog(findSkuTextEdit.Text.Substring(findSkuTextEdit.Text.Length - 1, 1) ==
                                                ";"
                                                    ? findSkuTextEdit.Text.Substring(0, findSkuTextEdit.Text.Length - 1)
                                                    : findSkuTextEdit.Text) >= 0)
                    {
                        addressProductLabelControl.Text =
                            findSkuTextEdit.Text.Substring(findSkuTextEdit.Text.Length - 1, 1) ==
                            ";"
                                ? findSkuTextEdit.Text.Substring(0, findSkuTextEdit.Text.Length - 1)
                                : findSkuTextEdit.Text;

                        descriptionProductLabelControl.Text = "---";
                        typeRotationLabelControl.Text = "---";
                        qtyMaxRotationLabelControl.Text = "---";
                        typeCellLabelControl.Text = worker2.GetTypeCellForAddress(addressProductLabelControl.Text);
                        dateReferenceAddressLabelControl.Text =
                                worker2.GetUpdateDateCellForAddress(addressProductLabelControl.Text);
                        wMSDataSet.ExecCrushShelf.Clear();
                    }
                    else
                    {
                        XtraMessageBox.Show("Не существует в системе такой адрес!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Не верный адрес!\nПросканируйте стикер адреса!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }

            findSkuTextEdit.Focus();
            findSkuTextEdit.SelectAll();
        }

        private void FindSkuTextEditKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                FindSkuButtonClick(null, null);
            }
        }

        private void SaveCellButtonClick(object sender, System.EventArgs e)
        {
            if (Cell == -1) return;
            var worker = new DataBaseLayers.ReferenceAddressWithCells();

            worker.InsertUpdateReferenceAddressAndCells(addressProductLabelControl.Text, Cell);
            findSkuTextEdit.Text = addressProductLabelControl.Text;

            checkButton1.Checked = false;
            checkButton2.Checked = false;
            checkButton3.Checked = false;
            checkButton4.Checked = false;
            checkButton5.Checked = false;
            checkButton6.Checked = false;
            checkButton7.Checked = false;

            findSkuTextEdit.SendKey(new KeyEventArgs(Keys.Enter));
        }
    }
}