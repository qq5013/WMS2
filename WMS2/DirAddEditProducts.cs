using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.DataBaseLayers;

namespace WMS.MainApplication
{
    public partial class DirAddEditProducts : XtraForm
    {
        public int ProductId { get; private set; }
        public string NameProduct { get; private set; }
        public string ProductBarCode { get; private set; }
        public decimal ProductDemensionX { get; private set; }
        public decimal ProductDemensionY { get; private set; }
        public decimal ProductDemensionZ { get; private set; }
        public decimal ProductWeight { get; private set; }
        public int ProductMultiplicity { get; set; }
        public int GroupId { get; set; }

        public void SetId(int id)
        {
            ProductId = id;
        }

        public void SetData(int id, string name, string barCode, decimal demensionX, decimal demensionY, decimal demensionZ, decimal weght, int multiplicity)
        {
            ProductId = id;
            NameProduct = name;
            ProductBarCode = barCode;
            ProductDemensionX = demensionX;
            ProductDemensionY = demensionY;
            ProductDemensionZ = demensionZ;
            ProductWeight = weght;
            ProductMultiplicity = multiplicity;
        }
        public DirAddEditProducts()
        {
            InitializeComponent();
            RenameLabels();
        }

        private void RenameLabels()
        {
            Text = "Изменение размеров товаров";
        }

        private void EditProduct(SqlCommand command)
        {
            command.CommandText =
                string.Format(
                    "UPDATE dbo.Catalog_Products SET DimensionX = {0}, DimensionY = {1} , DimensionZ = {2}, [Weight] = {3}, Multiplicity = {4} WHERE ID = {5}",
                    demensionXtextEdit.Text.Replace(",", "."), demensionYtextEdit.Text.Replace(",", "."),
                    demensionZtextEdit.Text.Replace(",", "."), weightTextEdit.Text.Replace(",", "."),
                    multiplicityTextEdit.Text, ProductId);
            command.ExecuteNonQuery();
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            var command = new SqlCommand("", Globals.GlobalParameters.WmsGlobalSqlConnection);
            if (Globals.GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                Globals.GlobalParameters.WmsGlobalSqlConnection.Open();
            }
            EditProduct(command);

            if (groupCheckedListBoxControl.CheckedIndices.Count > 0)
            {
                new DbDirsAddEdit().DeleteReferenceProductWithGroup(ProductId);
                foreach (var checkedIndex in groupCheckedListBoxControl.CheckedIndices)
                {
                    new DbDirsAddEdit().AddReferenceProductWithGroup(ProductId, Convert.ToInt32(groupCheckedListBoxControl.GetItemValue((int)checkedIndex)));
                }
            }

            /*
            if (groupLookUpEdit.EditValue != null)
            {
                new DbDirsAddEdit().AddReferenceProductWithGroup(ProductId, Convert.ToInt32(groupLookUpEdit.EditValue));
            }
             * */

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(demensionXtextEdit.Text.Replace(".", ",")) != ProductDemensionX || Convert.ToDecimal(demensionYtextEdit.Text.Replace(".", ",")) != ProductDemensionY || Convert.ToDecimal(demensionZtextEdit.Text.Replace(".", ",")) != ProductDemensionZ || Convert.ToDecimal(weightTextEdit.Text.Replace(".", ",")) != ProductWeight || Convert.ToInt32(multiplicityTextEdit.Text) != ProductMultiplicity)
            {
                if (XtraMessageBox.Show("Отменить все изменения и выйти?", "Внимание!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    Close();
                }
                else
                {
                    DialogResult = DialogResult.None;
                }
            }
        }

        private void DirAddEditProductsLoad(object sender, EventArgs e)
        {
            catalog_GroupTableAdapter.Fill(wMSDataSet.Catalog_Group);
            //groupLookUpEdit.Properties.BestFit();
            nameTextEdit.Text = NameProduct;
            nameTextEdit.ToolTip = NameProduct;
            barCodeTextEdit.Text = ProductBarCode;
            demensionXtextEdit.Text = ProductDemensionX.ToString(CultureInfo.InvariantCulture);
            demensionYtextEdit.Text = ProductDemensionY.ToString(CultureInfo.InvariantCulture);
            demensionZtextEdit.Text = ProductDemensionZ.ToString(CultureInfo.InvariantCulture);
            weightTextEdit.Text = ProductWeight.ToString(CultureInfo.InvariantCulture);
            multiplicityTextEdit.Text = ProductMultiplicity.ToString(CultureInfo.InvariantCulture);

            var worker = new DbDirsAddEdit();
            /*
            groupLookUpEdit.EditValue =
                   groupLookUpEdit.Properties.GetDataSourceValue(
                       groupLookUpEdit.Properties.Columns["ID"],
                       groupLookUpEdit.Properties.GetDataSourceRowIndex("ID", worker.GetReferenceProductWithGroups(ProductId)));
            */

            List<int> idGroups = worker.GetReferenceProductWithGroups(ProductId);

            if (idGroups.Count > 0)
            {
                if (idGroups[0] == -1)
                    return;
                foreach (object id in idGroups)
                {
                    groupCheckedListBoxControl.SetItemChecked(
                        wMSDataSet.Catalog_Group.Rows.IndexOf(
                            wMSDataSet.Catalog_Group.Select(string.Format("[ID] = {0}", id))[0]), true);
                }    
            }
            
        }
    }
}