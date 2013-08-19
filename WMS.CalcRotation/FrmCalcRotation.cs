using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.Globals;

namespace WMS.CalcRotation
{
    public partial class FrmCalcRotation : XtraForm
    {
        private bool _pressedEnter;
        public static DataBaseLayers.CalcRotation Worker = new DataBaseLayers.CalcRotation();
        public FrmCalcRotation()
        {
            InitializeComponent();
            catalog_ProductsTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
            lookUpEdit1.Properties.DisplayMember = "BarCode";
        }

        
        private void FrmCalcRotation_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'wMSDataSet.Catalog_Products' table. You can move, or remove it, as needed.
            this.catalog_ProductsTableAdapter.Fill(this.wMSDataSet.Catalog_Products);

        }

        private void radioGroup1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 0)
            {
                lookUpEdit1.Properties.DisplayMember = "BarCode";
                lookUpEdit1.Focus();
                lookUpEdit1.SelectAll();
            }
            if (radioGroup1.SelectedIndex == 1)
            {
                lookUpEdit1.Properties.DisplayMember = "Description";
                lookUpEdit1.Focus();
                lookUpEdit1.SelectAll();
            }
        }

        private void LookUpEdit1KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        
        {
            if (e.KeyData == Keys.Enter)
            {
                if (manualRotationCheckEdit.CheckState == CheckState.Checked)
                    return;
                _pressedEnter = true;
                if (radioGroup1.SelectedIndex == 0)
                {
                    if (lookUpEdit1.Text == "")
                    return;
                    var dr = wMSDataSet.Catalog_Products.Select(string.Format("Barcode = '{0}'", lookUpEdit1.Text));
                    if (dr.Length > 0)
                    {
                        foreach (DataRow dataRow in dr)
                        {
                            if (wMSDataSet.ProductsForCalc.Select(string.Format("ID = {0}", dataRow["ID"])).Length == 0)
                            {
                                labelControl1.Text = dataRow["Description"].ToString();
                                wMSDataSet.ProductsForCalc.AddProductsForCalcRow(Convert.ToInt64(dataRow["ID"]),
                                                                                 dataRow["Description"].ToString(),
                                                                                 dataRow["BarCode"].ToString());
                            }
                            else
                                XtraMessageBox.Show("Данный товар уже добавлен для посчёта", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        _pressedEnter = false;
                        lookUpEdit1.SelectAll();
                    }
                }
                /*    
                lookUpEdit1.GetColumnValue("ID"),
                                                   lookUpEdit1.GetColumnValue("Description"),
                                                   lookUpEdit1.GetColumnValue("BarCode"));
                 * */
            }
        }

        private void LookUpEdit1EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (manualRotationCheckEdit.CheckState == CheckState.Checked)
                    return;
                if (_pressedEnter)
                {


                    var look = sender as LookUpEdit;
                    labelControl1.Text = string.Format("Товар: {0}", look.GetColumnValue("Description"));

                   wMSDataSet.ProductsForCalc.AddProductsForCalcRow(Convert.ToInt64(look.GetColumnValue("ID")),
                                                                     look.GetColumnValue("Description").ToString(),
                                                                     look.GetColumnValue("BarCode").ToString());
                    _pressedEnter = false;
                    lookUpEdit1.Focus();
                    lookUpEdit1.SelectAll();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.GetType().FullName);
                throw;
            }
            
        }

        private void CalcButtonClick(object sender, EventArgs e)
        {
            DataRow[] dr = wMSDataSet.ProductsForCalc.Select();
            string idProducts = "";
            if (dr.Length != 0)
            {
                if (dr.Length > 1)
                {
                    idProducts = dr.Aggregate(idProducts, (current, dataRow) => current + dataRow[0].ToString() + ",");
                    idProducts = idProducts.Substring(0, idProducts.Length - 1);
                }
                else
                {
                    idProducts = dr[0][0].ToString();
                }

                
                Worker.StartCalc(idProducts, countDayRotationTextEdit.Text, percentMinTextEdit.Text);
                XtraMessageBox.Show("Для выбранных товаров была подсчитана ротация", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                wMSDataSet.ProductsForCalc.Clear();
            }
            else
            {
                XtraMessageBox.Show("Необходимо выбрать хотябы один товар для подсчёта!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void GridControl1KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (gridView1.FocusedRowHandle >= 0)
                {
                    wMSDataSet.ProductsForCalc.Rows.Remove(
                        wMSDataSet.ProductsForCalc.Rows.Find(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colID)));
                }
            }
        }

        private void ProductTextEditKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            var worker = new DataBaseLayers.AddressMigration();
            var result =
                worker.FindSku(productTextEdit.Text.Substring(productTextEdit.Text.Length - 1, 1) == ";"
                                   ? productTextEdit.Text.Substring(0, productTextEdit.Text.Length - 1)
                                   : productTextEdit.Text);

            if (result.IdSku > 0)
            {
                var res = Worker.GetRotationInfo(result.IdSku);
                if (res.Rows.Count > 0)
                {
                    descriptionLabel.Text = res.Rows[0][0].ToString();
                    typeRotationLabel.Text = res.Rows[0][1].ToString();
                    minQtyLabel.Text = res.Rows[0][2].ToString();
                    maxQtyLabel.Text = res.Rows[0][3].ToString();
                    dateCalLabel.Text = res.Rows[0][4].ToString();

                    productTextEdit.Focus();
                    productTextEdit.SelectAll();
                }
                else
                {
                    descriptionLabel.Text = "...";
                    typeRotationLabel.Text = "...";
                    minQtyLabel.Text = "...";
                    maxQtyLabel.Text = "...";
                    dateCalLabel.Text = "...";
                    productTextEdit.Focus();
                    productTextEdit.SelectAll();
                }
            }
            else
            {
                descriptionLabel.Text = "...";
                typeRotationLabel.Text = "...";
                minQtyLabel.Text = "...";
                maxQtyLabel.Text = "...";
                dateCalLabel.Text = "...";
                productTextEdit.Focus();
                productTextEdit.SelectAll();
            }

        }

        private void ManualRotationCheckEditCheckedChanged(object sender, EventArgs e)
        {
            if (manualRotationCheckEdit.CheckState == CheckState.Checked)
            {
                groupControl3.Visible = true;
                calcButton.Enabled = false;
            }
            else
            {
                groupControl3.Visible = false;
                calcButton.Enabled = true;
            }
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            if (maxTextEdit.Text == "")
            {
                XtraMessageBox.Show("Необходимо указать максимальное количество товара", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (minTextEdit.Text == "")
            {
                XtraMessageBox.Show("Необходимо указать минимальное количество товара", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lookUpEdit1.EditValue != null)
            {
                Worker.InsertRotation(lookUpEdit1.EditValue.ToString(), maxTextEdit.Text, minTextEdit.Text);
                XtraMessageBox.Show("Информация была успешна добавлена в базу данных", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}