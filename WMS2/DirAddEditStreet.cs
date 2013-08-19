using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.DataBaseLayers;

namespace WMS.MainApplication
{
    public partial class DirAddEditStreet : XtraForm
    {
        public int Id { get; private set; }
        public string SqlName { get; private set; }
        public string Description { get; private set; }
        public int IdZona { get; set; }
        public bool AddNewRecord { get; private set; }

        public void SetId(int id)
        {
            Id = id;
        }

        public void SetAddNewRecord(bool result)
        {
            AddNewRecord = result;
        }

        public void SetData(int id, string name, string description, int idZona)
        {
            Id = id;
            SqlName = name;
            Description = description;
            IdZona = idZona;
        }
        public DirAddEditStreet(bool setAddNewRecord)
        {
            InitializeComponent();
            SetAddNewRecord(setAddNewRecord);
            Text = AddNewRecord ? "Добавление новой улицы" : "Изменение улицы";
        }

        private void DirAddEditStreetLoad(object sender, EventArgs e)
        {
            catalog_ZonesTableAdapter.Fill(wMSDataSet.Catalog_Zones);
            nameTextEdit.Text = SqlName;
            descriptionTextEdit.Text = Description;
            zonaLookUpEdit.EditValue =
                zonaLookUpEdit.Properties.GetDataSourceValue(
                    zonaLookUpEdit.Properties.Columns["ID"],
                    zonaLookUpEdit.Properties.GetDataSourceRowIndex("ID", IdZona));
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            if (nameTextEdit.Text == SqlName && descriptionTextEdit.Text == Description && zonaLookUpEdit.EditValue == null) return;
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
            if (zonaLookUpEdit.EditValue == null)
            {
                XtraMessageBox.Show("Необходимо указать зону склада!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var worker = new DbDirsAddEdit();

            if (AddNewRecord)
            {
                worker.AddStreet(nameTextEdit.Text, descriptionTextEdit.Text,
                                    Convert.ToInt32(zonaLookUpEdit.EditValue));
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                worker.EditStreet(Id, nameTextEdit.Text, descriptionTextEdit.Text,
                                     Convert.ToInt32(zonaLookUpEdit.EditValue));
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}