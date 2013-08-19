using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.MainApplication;

namespace WMS.MainApplication
{
    public partial class DirAddEditItem : XtraForm
    {
        public int ID { get; private set; }
        public string SqlName { get; private set; }
        public string Description { get; private set; }
        public bool AddNewRecord { get; private set; }
        public TypeOfDir TypeDir { get; private set; }

        private void SetTDir(TypeOfDir tDir)
        {
            TypeDir = tDir;
        }

        public void SetID(int id)
        {
            ID = id;
        }

        public void SetAddNewRecord (bool result)
        {
            AddNewRecord = result;
        }

        public void SetData(int id, string name, string description)
        {
            ID = id;
            SqlName = name;
            Description = description;
        }

        public DirAddEditItem(TypeOfDir tDir, bool setAddNewRecord)
        {
            InitializeComponent();
            SetAddNewRecord(setAddNewRecord);
            SetTDir(tDir);
            RenameLabels();
        }

        private void RenameLabels()
        {
            switch (TypeDir)
            {
                case TypeOfDir.Warehouse:
                    Text = AddNewRecord ? "Добавление нового склада" : "Изменение склада";
                    labelControl1.Text = "Название склада:";
                    labelControl2.Text = "Описание склада:";
                    break;
                case TypeOfDir.Street:
                    Text = AddNewRecord ? "Добавление новой улицы" : "Изменение улицы";
                    labelControl1.Text = "Название улицы:";
                    labelControl2.Text = "Описание улицы:";
                    break;
                case TypeOfDir.Raft:
                    Text = AddNewRecord ? "Добавление нового стеллажа" : "Изменение стеллажа";
                    labelControl1.Text = "Название стеллажа:";
                    labelControl2.Text = "Описание стеллажа:";
                    break;
                case TypeOfDir.ShelfSpace:
                    Text = AddNewRecord ? "Добавление нового места на полке" : "Изменение места на полке";
                    labelControl1.Text = "Название места на полке:";
                    labelControl2.Text = "Описание места на полке:";
                    break;
                default:
                    return;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (nameTextEdit.Text != SqlName || descriptionTextEdit2.Text != Description)
            {
                if (XtraMessageBox.Show("Отменить все изменения и выйти?", "Внимание!", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    Close();
                }
                else
                {
                    DialogResult = DialogResult.None;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("",Globals.GlobalParameters.WmsGlobalSqlConnection);
            if (Globals.GlobalParameters.WmsGlobalSqlConnection.State == ConnectionState.Closed)
            {
                Globals.GlobalParameters.WmsGlobalSqlConnection.Open();
            }

            switch (TypeDir)
            {
                case TypeOfDir.Warehouse: if (AddNewRecord) AddWarehouse(command); else EditWarehouse(command);
                    break;
                case TypeOfDir.Street: if (AddNewRecord) AddStreet(command); else EditStreet(command);
                    break;
                case TypeOfDir.Raft: if (AddNewRecord) AddRaft(command); else EditRaft(command);
                    break;
                case TypeOfDir.ShelfSpace: if (AddNewRecord) AddShelfSpace(command); else EditShelfSpace(command);
                    break;
                default:
                    return;
            }
        }

        private void DirAddEditWarehouse_Load(object sender, EventArgs e)
        {
            nameTextEdit.Text = SqlName;
            descriptionTextEdit2.Text = Description;
        }

        private void AddWarehouse(SqlCommand command)
        {
            command.CommandText =
                string.Format(@"INSERT INTO Catalog_Warehouses (Name, Description) VALUES ('{0}', '{1}')",
                              nameTextEdit.Text, descriptionTextEdit2.Text);
            command.ExecuteNonQuery();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void EditWarehouse(SqlCommand command)
        {
            command.CommandText =
                string.Format(@"UPDATE Catalog_Warehouses SET Name = '{0}', Description = '{1}' WHERE ID = {2}",
                              nameTextEdit.Text, descriptionTextEdit2.Text, ID);
            command.ExecuteNonQuery();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddStreet(SqlCommand command)
        {
            command.CommandText = string.Format(
                @"INSERT INTO Catalog_Streets (Name, Description) VALUES ('{0}', '{1}')", nameTextEdit.Text,
                descriptionTextEdit2.Text);
            command.ExecuteNonQuery();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void EditStreet(SqlCommand command)
        {
            command.CommandText =
                string.Format(@"UPDATE Catalog_Streets SET Name = '{0}', Description = '{1}' WHERE ID = {2}",
                              nameTextEdit.Text, descriptionTextEdit2.Text, ID);
            command.ExecuteNonQuery();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddRaft(SqlCommand command)
        {
            command.CommandText = string.Format(@"INSERT INTO Catalog_Raft (Name, Description) VALUES ('{0}', '{1}')",
                                                nameTextEdit.Text, descriptionTextEdit2.Text);
            command.ExecuteNonQuery();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void EditRaft(SqlCommand command)
        {
            command.CommandText =
                string.Format(@"UPDATE Catalog_Raft SET Name = '{0}', Description = '{1}' WHERE ID = {2}",
                              nameTextEdit.Text, descriptionTextEdit2.Text, ID);
            command.ExecuteNonQuery();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddShelfSpace(SqlCommand command)
        {
            command.CommandText =
                string.Format(@"INSERT INTO Catalog_ShelfSpaces (Name, Description) VALUES ('{0}', '{1}')",
                              nameTextEdit.Text, descriptionTextEdit2.Text);
            command.ExecuteNonQuery();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void EditShelfSpace(SqlCommand command)
        {
            command.CommandText =
                string.Format(@"UPDATE Catalog_ShelfSpaces SET Name = '{0}', Description = '{1}' WHERE ID = {2}",
                              nameTextEdit.Text, descriptionTextEdit2.Text, ID);
            command.ExecuteNonQuery();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}