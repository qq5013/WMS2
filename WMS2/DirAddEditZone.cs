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
    public partial class DirAddEditZone : XtraForm
    {
        public int Id { get; private set; }
        public string SqlName { get; private set; }
        public string Description { get; private set; }
        public bool AddNewRecord { get; private set; }

        public void SetAddNewRecord(bool result)
        {
            AddNewRecord = result;
        }

        public void SetData(int id, string name, string description)
        {
            Id = id;
            SqlName = name;
            Description = description;
        }

        public DirAddEditZone(bool setAddNewRecord)
        {
            InitializeComponent();
            SetAddNewRecord(setAddNewRecord);
            Text = AddNewRecord ? "Добавление новой зоны склада" : "Изменение зоны склада";
        }

        private void DirAddEditZoneLoad(object sender, EventArgs e)
        {
            nameTextEdit.Text = SqlName;
            descriptionTextEdit.Text = Description;
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
            var worker = new DbDirsAddEdit();
            if (AddNewRecord)
            {
                worker.AddZone(nameTextEdit.Text, descriptionTextEdit.Text);
                DialogResult = DialogResult.OK;
                Close();

            }
            else
            {
                worker.EditZone(Id, nameTextEdit.Text, descriptionTextEdit.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}