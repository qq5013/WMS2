using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WMS.MainApplication
{
    public partial class DirAddEditItem2 : DevExpress.XtraEditors.XtraForm
    {
        public int ShelfID { get; private set; }
        public string ShelfName { get; private set; }
        public string ShelfDescription { get; private set; }
        public decimal ShelfHeight { get; private set; }
        public decimal ShelfDeph { get; private set; }
        public string ID_TypeOfRotation { get; private set; }
        public bool AddNewRecord { get; private set; }

        public void SetID(int id)
        {
            ShelfID = id;
        }

        public void SetAddNewRecord(bool result)
        {
            AddNewRecord = result;
        }

        public void SetData(int id, string name, string description, decimal height, decimal deph, string id_typeOfRotation)
        {
            ShelfID = id;
            ShelfName = name;
            ShelfDescription = description;
            ShelfHeight = height;
            ShelfDeph = deph;
            ID_TypeOfRotation = id_typeOfRotation;
        }

        public DirAddEditItem2(bool setAddNewRecord)
        {
            InitializeComponent();
            SetAddNewRecord(setAddNewRecord);
            RenameLabels();
        }

        private void RenameLabels()
        {
            Text = AddNewRecord ? "Добавление новой полки" : "Изменение полки";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (nameTextEdit.Text != ShelfName || descriptionTextEdit.Text != ShelfDescription || Convert.ToDecimal(heightTextEdit.Text) != ShelfHeight || Convert.ToDecimal(dephTextEdit.Text) != ShelfDeph || rotationLookUpEdit.Text != ID_TypeOfRotation)
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

        private void DirAddEditItem2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wMSDataSet.Catalog_RotationsProduct". При необходимости она может быть перемещена или удалена.
            this.catalog_RotationsProductTableAdapter.Fill(this.wMSDataSet.Catalog_RotationsProduct);
            
            nameTextEdit.Text = ShelfName;
            descriptionTextEdit.Text = ShelfDescription;
            heightTextEdit.Text = ShelfHeight.ToString();
            dephTextEdit.Text = ShelfDeph.ToString();
            rotationLookUpEdit.EditValue = rotationLookUpEdit.Properties.GetDataSourceValue(rotationLookUpEdit.Properties.Columns["ID"], rotationLookUpEdit.Properties.GetDataSourceRowIndex("Name", ID_TypeOfRotation));
            
        }


       
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (rotationLookUpEdit.EditValue == null)
            {
                XtraMessageBox.Show("Необходимо указать тип ротации!","Внимание!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            SqlCommand command = new SqlCommand("", Globals.GlobalParameters.WmsGlobalSqlConnection);
            if (Globals.GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                Globals.GlobalParameters.WmsGlobalSqlConnection.Open();
            }
            if (AddNewRecord) AddShelf(command); else EditShelf(command);
        }

        private void AddShelf(SqlCommand command)
        {
            command.CommandText =
                string.Format(
                    "INSERT INTO Catalog_Shelfs (Name, Description, Height, Deph, ID_TypeOfRotation) VALUES ('{0}', '{1}', {2}, {3}, {4})",
                    nameTextEdit.Text, descriptionTextEdit.Text, heightTextEdit.Text.Replace(",","."), dephTextEdit.Text.Replace(",","."),
                    rotationLookUpEdit.EditValue);
            command.ExecuteNonQuery();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void EditShelf(SqlCommand command)
        {
            command.CommandText =
                string.Format(
                    "UPDATE Catalog_Shelfs SET Name = '{0}', Description = '{1}', Height = {2}, Deph = {3}, ID_TypeOfRotation = {4} WHERE ID = {5}",
                    nameTextEdit.Text, descriptionTextEdit.Text, heightTextEdit.Text.Replace(",", "."),
                    dephTextEdit.Text.Replace(",","."), rotationLookUpEdit.EditValue, ShelfID);
            command.ExecuteNonQuery();
            DialogResult = DialogResult.OK;
            Close();
        }

    }
}