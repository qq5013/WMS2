using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.Globals;

namespace WMS.Administration
{
    public partial class FrmAddEditUserGroup : DevExpress.XtraEditors.XtraForm
    {
        public int IdGroup { get; private set; }
        public string NameGroup { get; private set; }
        public string DescriptionGroup { get; private set; }
        public List<int> IdAsigmnetsUsers = new List<int>();
        public bool AddNewRecord { get; private set; }

        public void SetID(int id)
        {
            IdGroup = id;
        }

        public void SetAddNewRecord(bool result)
        {
            AddNewRecord = result;
        }

        public void SetData(int idGroup, string nameGroup, string descriptionGroup, List<int> idAsignmentsUsers)
        {
            IdGroup = idGroup;
            NameGroup =nameGroup;
            DescriptionGroup = descriptionGroup;
            IdAsigmnetsUsers = idAsignmentsUsers;
        }

        public FrmAddEditUserGroup(bool setAddNewRecord)
        {
            InitializeComponent();
            SetAddNewRecord(setAddNewRecord);
            usersTableAdapter.Connection.ConnectionString = GlobalParameters.WmsConnectionString;
        }
        
        private void RenameLabels()
        {
            Text = AddNewRecord ? "Добавление новой группы" : string.Format("Изменение группы [{0}]", NameGroup);
        }

        private void FrmAddEditUserGroupLoad(object sender, EventArgs e)
        {
            RenameLabels();
            if (AddNewRecord)
            {
                usersTableAdapter.FillFreeUsers(wMSDataSet.Users);        
            }
            else
            {
                usersTableAdapter.FillFreeAndAsignmentUsers(wMSDataSet.Users, IdGroup);
                foreach (DataRow row in wMSDataSet.Users.Rows)
                {
                    foreach (int idAsigmnetsUser in IdAsigmnetsUsers)
                    {
                        if (Convert.ToInt32(row["ID"]) == idAsigmnetsUser)
                        {
                            row["Checked"] = true;
                        }
                    }    
                }
            }
            
            nameTextEdit.Text = NameGroup;
            descriptionTextEdit.Text = DescriptionGroup;
        }


        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            var worker = new DataBaseLayers.Administration();
            if (AddNewRecord)
            {
                List<int> idUsers = new List<int>();

                foreach (DataRow row in wMSDataSet.Users.Rows)
                {
                    if ((bool)row["Checked"])
                    {
                        idUsers.Add(Convert.ToInt32(row["ID"]));
                    }
                }
                if (idUsers.Count > 0)
                {
                    worker.AddNewUserGroup(nameTextEdit.Text, descriptionTextEdit.Text, idUsers);
                }
                else
                {
                    worker.AddNewUserGroup(nameTextEdit.Text, descriptionTextEdit.Text);
                }    
            }
            else
            {
                List<int> idUsersForAdd = new List<int>();
                List<int> idUsersForRemove = new List<int>();
                
                DataRow[] rowsRemove = wMSDataSet.Users.Select("Checked = false");
                foreach (DataRow rowRemove in rowsRemove)
                {
                    foreach (int asigmnetsUser in IdAsigmnetsUsers)
                    {
                        if (asigmnetsUser == Convert.ToInt32(rowRemove["ID"]))
                        {
                            idUsersForRemove.Add(Convert.ToInt32(rowRemove["ID"]));
                        }
                    }
                }
                DataRow[] rowsAdd = wMSDataSet.Users.Select("Checked = true");
                foreach (DataRow rowAdd in rowsAdd)
                {
                    idUsersForAdd.Add(Convert.ToInt32(rowAdd["ID"]));
                }
                if (idUsersForAdd.Count > 0 || idUsersForRemove.Count > 0)
                {
                    worker.EditUserGroup(IdGroup,NameGroup,DescriptionGroup,idUsersForAdd,idUsersForRemove);
                }
            }
            Close();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            if (nameTextEdit.Text != NameGroup || descriptionTextEdit.Text != DescriptionGroup)
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
    }
}