using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using WMS.Globals;
using WMS.MenuBuilder;

namespace WMS.Administration
{
    public partial class FrmAdministration : XtraForm
    {
        public List<ChangesMenu> InitStateMenus = new List<ChangesMenu>();
        
        
        public FrmAdministration()
        {
            InitializeComponent();
            usersTableAdapter.Connection.ConnectionString = GlobalParameters.WmsConnectionString;
            groupUsersTableAdapter.Connection.ConnectionString = GlobalParameters.WmsConnectionString;
            userPermissionsTableAdapter.Connection.ConnectionString = GlobalParameters.WmsConnectionString;
            listUserSessionsTableAdapter.Connection = GlobalParameters.WmsGlobalSqlConnection;
        }

        private void FrmAdministrationLoad(object sender, System.EventArgs e)
        {
            IntializeMenuItems();
            usersTabPage.Controls.Clear();
            menuPermitionsTabPage.Controls.Clear();
            //groupUsersTabPage.Controls.Add(splitContainerControl);
            groupUsersTabPage.Controls.Add(bottomPanelControl);
            groupUsersTabPage.Controls.Add(bodyPanelControl);
            splitContainerControl.Panel1.Controls.Add(gridControlGroupUsers);
            splitContainerControl.Panel2.Controls.Add(gridControlUsers);
            gridControlGroupUsers.BringToFront();
            gridControlUsers.BringToFront();
            groupUsersTableAdapter.Fill(wMSDataSet.GroupUsers);
            labelLeft.Text = "Группы";
            labelRight.Text = "Пользователи в группе";
            addButton.Text = "Добавить группу";
            editButton.Text = "Изменить группу";
            deleteButton.Text = "Удалить группу";
        }

        private void GroupUserGridViewFocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (TabControl.SelectedTabPage == groupUsersTabPage)
            {
                if (groupUserGridView.FocusedRowHandle >= 0)
                    usersTableAdapter.FillByGroupId(wMSDataSet.Users,
                                                    Convert.ToInt32(
                                                        groupUserGridView.GetRowCellValue(
                                                            groupUserGridView.FocusedRowHandle, colGroupUserID)));
            }
            if (TabControl.SelectedTabPage == menuPermitionsTabPage)
            {
                if (groupUserGridView.FocusedRowHandle >= 0)
                FillUserPermitionsTree(Convert.ToInt32(
                    groupUserGridView.GetRowCellValue(
                        groupUserGridView.FocusedRowHandle, colGroupUserID)));
            }
        }

        private void TabControlTabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TabControlSelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (TabControl.SelectedTabPage == usersTabPage)
            {
                groupUsersTabPage.Controls.Clear();
                menuPermitionsTabPage.Controls.Clear();
                treeList1.Visible = false;gridControlUsers.Visible = true;
                deleteButton.Visible = true;
                editButton.Visible = true;
                usersTabPage.Controls.Add(bottomPanelControl);
                usersTabPage.Controls.Add(bodyPanelControl);
                splitContainerControl.Panel1.Controls.Add(gridControlUsers);
                splitContainerControl.Panel2.Controls.Add(gridControlGroupUsers);
                gridControlGroupUsers.BringToFront();
                gridControlUsers.BringToFront();
                usersTableAdapter.Fill(wMSDataSet.Users);
                labelLeft.Text = "Пользователи";
                labelRight.Text = "Привязка к группам";
                addButton.Text = "Добавить пользователя";
                editButton.Text = "Изменить пользователя";
                deleteButton.Text = "Удалить пользователя";

            }
            if (TabControl.SelectedTabPage == groupUsersTabPage)
            {
                usersTabPage.Controls.Clear();
                menuPermitionsTabPage.Controls.Clear();
                treeList1.Visible = false;
                gridControlUsers.Visible = true;
                deleteButton.Visible = true;
                editButton.Visible = true;
                //groupUsersTabPage.Controls.Add(splitContainerControl);
                groupUsersTabPage.Controls.Add(bottomPanelControl);
                groupUsersTabPage.Controls.Add(bodyPanelControl);
                splitContainerControl.Panel1.Controls.Add(gridControlGroupUsers);
                splitContainerControl.Panel2.Controls.Add(gridControlUsers);
                gridControlGroupUsers.BringToFront();
                gridControlUsers.BringToFront();
                groupUsersTableAdapter.Fill(wMSDataSet.GroupUsers);
                labelLeft.Text = "Группы";
                labelRight.Text = "Пользователи в группе";
                addButton.Text = "Добавить группу";
                editButton.Text = "Изменить группу";
                deleteButton.Text = "Удалить группу";
            }
            if (TabControl.SelectedTabPage == menuPermitionsTabPage)
            {
                usersTabPage.Controls.Clear();
                groupUsersTabPage.Controls.Clear();
                menuPermitionsTabPage.Controls.Add(bottomPanelControl);
                addButton.Text = "Сохранить";
                deleteButton.Visible = false;
                editButton.Visible = false;
                menuPermitionsTabPage.Controls.Add(bodyPanelControl);
                splitContainerControl.Panel1.Controls.Add(gridControlGroupUsers);
                splitContainerControl.Panel2.Controls.Add(treeList1);
                gridControlGroupUsers.BringToFront();
                treeList1.Visible = true;
                gridControlUsers.Visible = false;
                treeList1.Dock = DockStyle.Fill;
                treeList1.BringToFront();
                groupUsersTableAdapter.Fill(wMSDataSet.GroupUsers);
                labelLeft.Text = "Группы";
                labelRight.Text = "Разрешённые пункты меню";
            }
            if (TabControl.SelectedTabPage == sendMessagesToUsersTabPage)
            {
                listUserSessionsTableAdapter.Fill(wMSDataSet.ListUserSessions, ObjectsForMainApplication.SessionId);
            }
        }

        private void UsersGridViewFocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (TabControl.SelectedTabPage == usersTabPage)
            {
                if (usersGridView.FocusedRowHandle >= 0)
                    groupUsersTableAdapter.FillByUserId(wMSDataSet.GroupUsers, Convert.ToInt32(usersGridView.GetRowCellValue(usersGridView.FocusedRowHandle, colUserID)));
            }
        }

        private void treeList1_BeforeCheckNode(object sender, CheckNodeEventArgs e)
        {
           
        }

        private void treeList1_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
        }

        private void treeList1_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            if (e.Node.CheckState == CheckState.Checked)
            {
                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
            }
            else
            {
                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Regular);
            }
        }

        private void TreeList1AfterCheckNode(object sender, NodeEventArgs e)
        {
            var mBuilder = new AppMainMenu();
            if (e.Node.CheckState == CheckState.Unchecked)
            {
                bool allChilUncheched = true;
                e.Node.Expanded = true;

                
                if (e.Node.ParentNode != null)
                {
                    foreach (TreeListNode childForThisParenNode in e.Node.ParentNode.Nodes)
                    {
                        if (childForThisParenNode.CheckState != CheckState.Unchecked)
                            allChilUncheched = false;
                    }
                    if (allChilUncheched)
                    {
                        e.Node.ParentNode.Checked = false;
                    //    mBuilder.SetStateMenuItem(
                    //Convert.ToInt32(groupUserGridView.GetRowCellValue(groupUserGridView.FocusedRowHandle, colGroupUserID)),
                    //Convert.ToInt32(e.Node.ParentNode.GetValue("idMenu")), Convert.ToInt32(e.Node.GetValue("idMenu")),
                    //e.Node.ParentNode.Checked);
                    }
                }
                else
                {
                    //mBuilder.SetStateMenuItem(
                    //Convert.ToInt32(groupUserGridView.GetRowCellValue(groupUserGridView.FocusedRowHandle, colGroupUserID)),
                    //Convert.ToInt32(e.Node.GetValue("idMenu")), Convert.ToInt32(e.Node.GetValue("idMenu")),
                    //e.Node.Checked);
                }
                foreach(TreeListNode child in e.Node.Nodes)
                {
                    child.Checked = false;
                    //mBuilder.SetStateMenuItem(
                    //Convert.ToInt32(groupUserGridView.GetRowCellValue(groupUserGridView.FocusedRowHandle, colGroupUserID)),
                    //Convert.ToInt32(child.ParentNode.GetValue("idMenu")), Convert.ToInt32(child.GetValue("idMenu")),
                    //e.Node.ParentNode.Checked);
                }
            }
            else
            {
                e.Node.Expanded = true;
                if (e.Node.ParentNode != null)
                {
                    e.Node.ParentNode.Checked = true;
                //mBuilder.SetStateMenuItem(
                //    Convert.ToInt32(groupUserGridView.GetRowCellValue(groupUserGridView.FocusedRowHandle, colGroupUserID)),
                //    Convert.ToInt32(e.Node.ParentNode.GetValue("idMenu")), Convert.ToInt32(e.Node.GetValue("idMenu")),
                //    e.Node.ParentNode.Checked);
            }
            foreach (TreeListNode child in e.Node.Nodes)
                {
                    child.Checked = true;
                    //mBuilder.SetStateMenuItem(
                    //Convert.ToInt32(groupUserGridView.GetRowCellValue(groupUserGridView.FocusedRowHandle, colGroupUserID)),
                    //Convert.ToInt32(child.ParentNode.GetValue("idMenu")), Convert.ToInt32(child.GetValue("idMenu")),
                    //e.Node.ParentNode.Checked);
                }
            }

        }
        public void FillUserPermitionsTree(int idGroup)
        {
            userPermissionsTableAdapter.Fill(wMSDataSet.UserPermissions, idGroup);

            
            
            DataTable dt = userPermissionsTableAdapter.GetData(idGroup);
            InitStateMenus.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (TreeListNode nod in treeList1.Nodes)
                {
                    DataRow[] result = dt.Select(string.Format("ID_Menu = {0}", nod.GetValue("idMenu")));
                    if (result.Length > 0)
                    {
                        nod.Checked = Convert.ToBoolean(result[0]["State"]);
                        InitStateMenus.Add(new ChangesMenu
                                               {
                                                   IdMenu = Convert.ToInt32(result[0]["ID_Menu"]),
                                                   IdParentMenu = Convert.ToInt32(result[0]["ID_ParentMenu"]),
                                                   State = Convert.ToBoolean(result[0]["State"])
                                               });
                    }
                    else
                    {
                        nod.Checked = false;
                        InitStateMenus.Add(new ChangesMenu
                        {
                            IdMenu = Convert.ToInt32(nod.GetValue("idMenu")),
                            IdParentMenu = Convert.ToInt32(nod.GetValue("idMenu")),
                            State = nod.Checked
                        });
                    }
                    foreach (TreeListNode childNod in nod.Nodes)
                    {
                        DataRow[] childResult = dt.Select(string.Format("ID_Menu = {0}", childNod.GetValue("idMenu")));
                        if (childResult.Length > 0)
                        {
                            childNod.Checked = Convert.ToBoolean(childResult[0]["State"]);
                            InitStateMenus.Add(new ChangesMenu
                                                   {
                                                       IdMenu = Convert.ToInt32(childResult[0]["ID_Menu"]),
                                                       IdParentMenu = Convert.ToInt32(childResult[0]["ID_ParentMenu"]),
                                                       State = Convert.ToBoolean(childResult[0]["State"])
                                                   });
                        }
                        else
                        {
                            childNod.Checked = false;
                            InitStateMenus.Add(new ChangesMenu
                            {
                                IdMenu = Convert.ToInt32(childNod.GetValue("idMenu")),
                                IdParentMenu = Convert.ToInt32(nod.GetValue("idMenu")),
                                State = childNod.Checked
                            });
                        }
                    }
                }
            }
            else
            {
                foreach (TreeListNode nod in treeList1.Nodes)
                {
                    nod.Checked = false;
                    foreach (TreeListNode childNod in nod.Nodes)
                    {
                        childNod.Checked = false;
                    }
                }
                foreach (TreeListNode parentNode in treeList1.Nodes)
                {
                    InitStateMenus.Add(new ChangesMenu
                                           {
                                               IdMenu = Convert.ToInt32(parentNode.GetValue("idMenu")),
                                               IdParentMenu = Convert.ToInt32(parentNode.GetValue("idMenu")),
                                               State = parentNode.Checked
                                           });

                    foreach (TreeListNode childNod in parentNode.Nodes)
                    {
                        InitStateMenus.Add(new ChangesMenu
                                               {
                                                   IdMenu = Convert.ToInt32(childNod.GetValue("idMenu")),
                                                   IdParentMenu = Convert.ToInt32(parentNode.GetValue("idMenu")),
                                                   State = childNod.Checked
                                               });
                    }
                }
            }
            

            treeList1.ExpandAll();
        }

        public void IntializeMenuItems()
        {
            var myMenu = GlobalParameters.MainMenuGlobal;


            List<TreeListNode> parentMenuNodes = new List<TreeListNode>();
            TreeListNode childMenuNode = null;
            foreach (BarSubItemLink barSubItemLink in myMenu.ItemLinks)
            {
                parentMenuNodes.Add(treeList1.AppendNode(null, null));
                parentMenuNodes[parentMenuNodes.Count - 1].SetValue("nameMenu", barSubItemLink.Caption);
                parentMenuNodes[parentMenuNodes.Count - 1].SetValue("idMenu", barSubItemLink.ItemId);
                foreach (BarButtonItemLink barButtonItemLink in barSubItemLink.VisibleLinks)
                {
                    childMenuNode = treeList1.AppendNode(null, parentMenuNodes[parentMenuNodes.Count - 1]);
                    childMenuNode.SetValue("nameMenu", barButtonItemLink.Caption);
                    childMenuNode.SetValue("idMenu", barButtonItemLink.ItemId);
                }
            }
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            
            var changeStateMenus = new List<ChangesMenu>();
            AppMainMenu mBuilder = new AppMainMenu();
            bool menuChanged = false;
            
            if (TabControl.SelectedTabPage == menuPermitionsTabPage)
            {
                foreach (TreeListNode parentNode in treeList1.Nodes)
                {
                    changeStateMenus.Add(new ChangesMenu
                                           {
                                               IdMenu = Convert.ToInt32(parentNode.GetValue("idMenu")),
                                               IdParentMenu = Convert.ToInt32(parentNode.GetValue("idMenu")),
                                               State = parentNode.Checked
                                           });

                    foreach (TreeListNode childNod in parentNode.Nodes)
                    {
                        changeStateMenus.Add(new ChangesMenu
                                               {
                                                   IdMenu = Convert.ToInt32(childNod.GetValue("idMenu")),
                                                   IdParentMenu = Convert.ToInt32(parentNode.GetValue("idMenu")),
                                                   State = childNod.Checked
                                               });
                    }
                }

                for (int i = 0; i < InitStateMenus.Count; i++)
                {
                    if (InitStateMenus[i].State != changeStateMenus[i].State)
                    {
                        mBuilder.SetStateMenuItem(
                            Convert.ToInt32(groupUserGridView.GetRowCellValue(groupUserGridView.FocusedRowHandle, colGroupUserID)),
                            changeStateMenus[i].IdParentMenu, changeStateMenus[i].IdMenu, changeStateMenus[i].State);
                        menuChanged = true;
                    }
                }
                if (menuChanged)
                {
                    InitStateMenus.Clear();
                    InitStateMenus = changeStateMenus;
                }

            }
            if (TabControl.SelectedTabPage == groupUsersTabPage)
            {
                var frm = new FrmAddEditUserGroup(true);
                frm.ShowDialog();
                groupUsersTableAdapter.Fill(wMSDataSet.GroupUsers);
            }
            if (TabControl.SelectedTabPage == usersTabPage)
            {
                var frm = new FrmAddEditUser(true);
                frm.ShowDialog();
                usersTableAdapter.Fill(wMSDataSet.Users);
            }
        }

        private void EditButtonClick(object sender, EventArgs e)
        {
            if (TabControl.SelectedTabPage == groupUsersTabPage)
            {
                var frm = new FrmAddEditUserGroup(false);
                List<int> idAsignmentUsers = new List<int>();
                foreach(DataRow row in wMSDataSet.Users.Rows)
                {
                    idAsignmentUsers.Add(Convert.ToInt32(row["ID"]));
                }
                frm.SetData(
                    Convert.ToInt32(groupUserGridView.GetRowCellValue(groupUserGridView.FocusedRowHandle, colGroupUserID)),
                    groupUserGridView.GetRowCellValue(groupUserGridView.FocusedRowHandle, colGroupUserName).ToString(),
                    groupUserGridView.GetRowCellValue(groupUserGridView.FocusedRowHandle, colGroupUserDescription).ToString(),
                    idAsignmentUsers);
                frm.ShowDialog();
                groupUsersTableAdapter.Fill(wMSDataSet.GroupUsers);
            }
            if (TabControl.SelectedTabPage == usersTabPage)
            {
                var frm = new FrmAddEditUser(false);
                int idGroupAdd = 0;
                if (wMSDataSet.GroupUsers.Rows.Count > 0)
                {
                    idGroupAdd = Convert.ToInt32(wMSDataSet.GroupUsers.Rows[0]["ID"]);
                }
                frm.SetData(Convert.ToInt32(usersGridView.GetRowCellValue(usersGridView.FocusedRowHandle, colUserID)),
                            usersGridView.GetRowCellValue(usersGridView.FocusedRowHandle, colUserLogin).ToString(),
                            usersGridView.GetRowCellValue(usersGridView.FocusedRowHandle, colUserFirstName).ToString(),
                            usersGridView.GetRowCellValue(usersGridView.FocusedRowHandle, colUserLastName).ToString(),
                            ConvertStringToBool(usersGridView.GetRowCellValue(usersGridView.FocusedRowHandle,
                                                                            colUserActive).ToString()),idGroupAdd);
                frm.ShowDialog();
                usersTableAdapter.Fill(wMSDataSet.Users);
            }

        }

        internal bool ConvertStringToBool(string input)
        {
            switch (input)
            {
                case "Да":
                return true;
                case "Нет":
                    return false;
                default:
                    return false;
            }
        }

        private void userSessionsListGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        public void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void SendButtonClick(object sender, EventArgs e)
        {
            DataRow[] dr = wMSDataSet.ListUserSessions.Select("Checked = true");
            if (dr.LongLength > 0)
            {
                var worker = new DataBaseLayers.Administration();

                var listSessionsId = new List<Guid>((int)dr.LongLength);
                listSessionsId.AddRange(from dataRow in dr
                                        where (Guid) dataRow["ID_Session"] != ObjectsForMainApplication.SessionId
                                        select (Guid) dataRow["ID_Session"]);

                foreach (Guid guid in listSessionsId)
                {
                    worker.SendMessage(guid, captionMessageTextEdit.Text, bodyMessageMemoEdit.Text,
                                       iconTypeMessageRadioGroup.Properties.Items[
                                           iconTypeMessageRadioGroup.SelectedIndex].Value.ToString());
                }

                XtraMessageBox.Show("Сообщение отправлено!", "Уведомление", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                captionMessageTextEdit.Text = "";
                captionMessageTextEdit.Focus();
                bodyMessageMemoEdit.Text = "";
            }
            else
            {
                XtraMessageBox.Show("Необходмо указать пользователей", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SendAllСheckEditCheckStateChanged(object sender, EventArgs e)
        {
            if (sendAllСheckEdit.CheckState == CheckState.Checked)
            {
                DataRow[] rows = wMSDataSet.ListUserSessions.Select();

                foreach (DataRow dataRow in rows)
                {
                    dataRow["Checked"] = true;
                }
            }
            else
            {
                DataRow[] rows = wMSDataSet.ListUserSessions.Select();

                foreach (DataRow dataRow in rows)
                {
                    dataRow["Checked"] = false;
                }
            }
        }
    }
}