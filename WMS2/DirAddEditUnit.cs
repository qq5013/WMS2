using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WMS.MainApplication
{
    public partial class DirAddEditUnit : DevExpress.XtraEditors.XtraForm
    {
        public int UnitId { get; private set; }
        public string UnitName { get; private set; }
        public decimal SizeOfUnit { get; private set; }
        public decimal DistanceBetweenUnits { get; private set; }
        public bool AddNewRecord { get; private set; }

        public void SetId(int id)
        {
            UnitId = id;
        }

        public void SetAddNewRecord(bool result)
        {
            AddNewRecord = result;
        }

        public void SetData(int id, string name, decimal sizeOfUnit, decimal distanceBetweenUnits)
        {
            UnitId = id;
            UnitName = name;
            SizeOfUnit = sizeOfUnit;
            DistanceBetweenUnits = distanceBetweenUnits;
        }

        public DirAddEditUnit(bool setAddNewRecord)
        {
            InitializeComponent(); 
            SetAddNewRecord(setAddNewRecord);
            RenameLabels();
        }

        private void RenameLabels()
        {
            Text = AddNewRecord ? "Добавление нового типа еденицы деления" : "Изменение еденицы деления";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var command = new SqlCommand("", Globals.GlobalParameters.WmsGlobalSqlConnection);
            if (Globals.GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                Globals.GlobalParameters.WmsGlobalSqlConnection.Open();
            }
            if (AddNewRecord) AddUnit(command); else EditUnit(command);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (nameTextEdit.Text != UnitName || Convert.ToDecimal(sizeOfUnitTextEdit.Text) != SizeOfUnit || Convert.ToDecimal(distanceBetweenUnitsTextEdit.Text) != DistanceBetweenUnits)
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

        private void DirAddEditUnit_Load(object sender, EventArgs e)
        {
            nameTextEdit.Text = UnitName;
            sizeOfUnitTextEdit.Text = SizeOfUnit.ToString(CultureInfo.InvariantCulture);
            distanceBetweenUnitsTextEdit.Text = DistanceBetweenUnits.ToString(CultureInfo.InvariantCulture);
        }

        private void AddUnit(SqlCommand command)
        {
            command.CommandText =
                string.Format(
                    "INSERT INTO Catalog_Units (Name, SizeOfUnit, DistanceBetweenUnits) VALUES ('{0}', {1}, {2})",
                    nameTextEdit.Text, sizeOfUnitTextEdit.Text.Replace(",", "."), distanceBetweenUnitsTextEdit.Text.Replace(",", "."));
            command.ExecuteNonQuery();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void EditUnit(SqlCommand command)
        {
            command.CommandText =
                string.Format(
                    "UPDATE Catalog_Units SET Name = '{0}', SizeOfUnit = {1}, DistanceBetweenUnits = {2} WHERE ID = {3}",
                    nameTextEdit.Text, sizeOfUnitTextEdit.Text.Replace(",", "."), distanceBetweenUnitsTextEdit.Text.Replace(",", "."), UnitId);
            command.ExecuteNonQuery();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}