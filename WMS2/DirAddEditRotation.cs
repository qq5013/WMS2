using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WMS.MainApplication
{
    public partial class DirAddEditRotation : DevExpress.XtraEditors.XtraForm
    {
        public int RotationID { get; private set; }
        public string RotationName { get; private set; }
        public decimal RotationMin { get; private set; }
        public decimal RotationMax { get; private set; }
        public bool AddNewRecord { get; private set; }

        public void SetID(int id)
        {
            RotationID = id;
        }

        public void SetAddNewRecord(bool result)
        {
            AddNewRecord = result;
        }

        public void SetData(int id, string name, decimal min, decimal max)
        {
            RotationID = id;
            RotationName = name;
            RotationMin = min;
            RotationMax = max;
        }

        public DirAddEditRotation(bool setAddNewRecord)
        {
            InitializeComponent();
            SetAddNewRecord(setAddNewRecord);
            RenameLabels();
        }

        private void RenameLabels()
        {
            Text = AddNewRecord ? "Добавление нового типа ротации" : "Изменение типа ротации";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (nameTextEdit.Text != RotationName || Convert.ToDecimal(minTextEdit.Text) != RotationMin || Convert.ToDecimal(maxTextEdit.Text) != RotationMax)
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

        private void DirAddEditRotation_Load(object sender, EventArgs e)
        {
            nameTextEdit.Text = RotationName;
            minTextEdit.Text = RotationMin.ToString();
            maxTextEdit.Text = RotationMax.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("", Globals.GlobalParameters.WmsGlobalSqlConnection);
            if (Globals.GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                Globals.GlobalParameters.WmsGlobalSqlConnection.Open();
            }
            if (AddNewRecord) AddRotation(command); else EditRotation(command);
        }


        private void AddRotation(SqlCommand command)
        {
            command.CommandText =
                string.Format(
                    "INSERT INTO Catalog_RotationsProduct (Name, MinQty, MaxQty) VALUES ('{0}', {1}, {2})",
                    nameTextEdit.Text, minTextEdit.Text.Replace(",", "."), maxTextEdit.Text.Replace(",", "."));
            command.ExecuteNonQuery();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void EditRotation(SqlCommand command)
        {
            command.CommandText =
                string.Format(
                    "UPDATE Catalog_RotationsProduct SET Name = '{0}', MinQty = {1}, MaxQty = {2} WHERE ID = {3}",
                    nameTextEdit.Text, minTextEdit.Text.Replace(",", "."), maxTextEdit.Text.Replace(",", "."), RotationID);
            command.ExecuteNonQuery();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}