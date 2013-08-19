using System;
using System.Data;
using DevExpress.XtraEditors;
using WMS.DataBaseLayers;
using System.Security.Cryptography;
using WMS.Globals;

namespace WMS.Administration
{
    public partial class FrmAddEditUser : XtraForm
    {
        public int IdUser { get; set; }
        public string LoginUser { get; set; }
        public string PasswordUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool ActiveUser { get; set; }
        public bool NewPass { get; set; }
        public bool AddNewRecord { get; set; }
        public int IdGroupAdd { get; set; }

        public void SetAddNewRecord(bool result)
        {
            AddNewRecord = result;
        }

        public void SetData(int idUser, string loginUser, string firstName, string lastName, bool activeUser, int idGroupAdd)
        {
            IdUser = idUser;
            LoginUser = loginUser;
            FirstName = firstName;
            LastName = lastName;
            ActiveUser = activeUser;
            IdGroupAdd = idGroupAdd;
        }
        
        private void RenameLabels()
        {
            Text = AddNewRecord ? "Добавление нового пользователя" : string.Format("Изменение пользователя [{0}]", LoginUser);
            
        }


        public FrmAddEditUser(bool setAddNewRecord)
        {
            InitializeComponent();
            SetAddNewRecord(setAddNewRecord);
            groupUsersTableAdapter.Connection.ConnectionString = GlobalParameters.WmsConnectionString;

        }

        private void FrmAddEditUserLoad(object sender, EventArgs e)
        {
            loginTextEdit.Text = LoginUser;
            passwordTextEdit.Text = AddNewRecord ? "" : "password :)";

            firstNameTextEdit.Text = FirstName;
            lastNameTextEdit.Text = LastName;
            activeCheckEdit.Checked = ActiveUser;
            passwordTextEdit.Enabled = AddNewRecord;
            newPasswordCheckEdit.Visible = true;

            
            groupUsersTableAdapter.Fill(wMSDataSet.GroupUsers);

            foreach (DataRow row in wMSDataSet.GroupUsers.Rows)
            {
                if (Convert.ToInt32(row["ID"]) == IdGroupAdd)
                {
                    row["Checked"] = true;
                }
            }

            RenameLabels();
        }

        private void GroupUsersGridViewCellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }

        private void GroupUsersGridViewCellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                foreach (DataRow row in wMSDataSet.GroupUsers.Rows)
                {
                    if (Convert.ToInt32(row["ID"]) != Convert.ToInt32(groupUsersGridView.GetRowCellValue(e.RowHandle, colUserGroupID)))
                        row["Checked"] = false;
                    else
                        IdGroupAdd = Convert.ToInt32(row["ID"]);
                }    
            }
            
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            var worker = new DataBaseLayers.Administration();
            if (AddNewRecord)
            {
                if (IdGroupAdd != 0)
                    worker.AddNewUser(loginTextEdit.Text, Globals.Encription.CalculateMd5Hash(passwordTextEdit.Text),
                                      firstNameTextEdit.Text, lastNameTextEdit.Text, activeCheckEdit.Checked, IdGroupAdd);
                else
                    worker.AddNewUser(loginTextEdit.Text, Globals.Encription.CalculateMd5Hash(passwordTextEdit.Text),
                                      firstNameTextEdit.Text, lastNameTextEdit.Text, activeCheckEdit.Checked);   
            }
            else
            {
                if (wMSDataSet.GroupUsers.Select("Checked = true").Length == 0)
                    IdGroupAdd = 0;
                if (newPasswordCheckEdit.Checked)
                    worker.EditUser(IdUser, loginTextEdit.Text,
                                    Globals.Encription.CalculateMd5Hash(passwordTextEdit.Text), firstNameTextEdit.Text,
                                    lastNameTextEdit.Text, activeCheckEdit.Checked, IdGroupAdd);
                else
                    worker.EditUser(IdUser, loginTextEdit.Text, "", firstNameTextEdit.Text, lastNameTextEdit.Text,
                                    activeCheckEdit.Checked, IdGroupAdd);
            }
            Close();

        }

        private void NewPasswordCheckEditCheckedChanged(object sender, EventArgs e)
        {
            passwordTextEdit.Enabled = newPasswordCheckEdit.Checked;
            passwordTextEdit.Text = newPasswordCheckEdit.Checked ? "" : "password :)";
        }
    }
}