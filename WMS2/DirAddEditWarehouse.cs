using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.DataBaseLayers;

namespace WMS.MainApplication
{
    public partial class DirAddEditWarehouse : XtraForm
    {
        public int Id { get; private set; }
        public string SqlName { get; private set; }
        public string Description { get; private set; }
        public int IdTypeOfDistribution { get; set; }
        public bool AddNewRecord { get; private set; }
        
        public void SetId(int id)
        {
            Id = id;
        }

        public void SetAddNewRecord(bool result)
        {
            AddNewRecord = result;
        }

        public void SetData(int id, string name, string description, int idTypeOfDistribution)
        {
            Id = id;
            SqlName = name;
            Description = description;
            IdTypeOfDistribution = idTypeOfDistribution;
        }

        public DirAddEditWarehouse(bool setAddNewRecord)
        {
            InitializeComponent();
            SetAddNewRecord(setAddNewRecord);
            Text = AddNewRecord ? "Добавление нового склада" : "Изменение склада";
        }

        private void DirAddEditWarehouseLoad(object sender, EventArgs e)
        {
            catalog_TypeOfDistributionWarehousesTableAdapter.Fill(wMSDataSet.Catalog_TypeOfDistributionWarehouses);
            nameTextEdit.Text = SqlName;
            descriptionTextEdit.Text = Description;
            typeOfDistributionLookUpEdit.EditValue =
                typeOfDistributionLookUpEdit.Properties.GetDataSourceValue(
                    typeOfDistributionLookUpEdit.Properties.Columns["ID"],
                    typeOfDistributionLookUpEdit.Properties.GetDataSourceRowIndex("ID", IdTypeOfDistribution));
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            if (nameTextEdit.Text == SqlName && descriptionTextEdit.Text == Description) return;
            if (
                XtraMessageBox.Show("Отменить все изменения и выйти?", "Внимание!", MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Close();
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            if (typeOfDistributionLookUpEdit.EditValue == null)
            {
                XtraMessageBox.Show("Необходимо указать тип дистрибуции склада!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            var worker = new DbDirsAddEdit();

            if (AddNewRecord)
            {
                worker.AddWarehouse(nameTextEdit.Text, descriptionTextEdit.Text,
                                    (int) typeOfDistributionLookUpEdit.EditValue);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                worker.EditWarehouse(Id, nameTextEdit.Text, descriptionTextEdit.Text,
                                     (int) typeOfDistributionLookUpEdit.EditValue);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}