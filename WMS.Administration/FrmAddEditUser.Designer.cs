namespace WMS.Administration
{
    partial class FrmAddEditUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.firstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.activeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.newPasswordCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.bottomPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.topPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.bodyPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.groupUsersBindingSource = new System.Windows.Forms.BindingSource();
            this.wMSDataSet = new WMS.Administration.WMSDataSet();
            this.groupUsersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserGroupID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserGroupDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Checked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.groupUsersTableAdapter = new WMS.Administration.WMSDataSetTableAdapters.GroupUsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPanelControl)).BeginInit();
            this.bottomPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topPanelControl)).BeginInit();
            this.topPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bodyPanelControl)).BeginInit();
            this.bodyPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupUsersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginTextEdit
            // 
            this.loginTextEdit.Location = new System.Drawing.Point(82, 12);
            this.loginTextEdit.Name = "loginTextEdit";
            this.loginTextEdit.Size = new System.Drawing.Size(100, 20);
            this.loginTextEdit.TabIndex = 0;
            // 
            // passwordTextEdit
            // 
            this.passwordTextEdit.Location = new System.Drawing.Point(82, 38);
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.Properties.PasswordChar = '*';
            this.passwordTextEdit.Size = new System.Drawing.Size(100, 20);
            this.passwordTextEdit.TabIndex = 1;
            // 
            // firstNameTextEdit
            // 
            this.firstNameTextEdit.Location = new System.Drawing.Point(254, 12);
            this.firstNameTextEdit.Name = "firstNameTextEdit";
            this.firstNameTextEdit.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextEdit.TabIndex = 2;
            // 
            // lastNameTextEdit
            // 
            this.lastNameTextEdit.Location = new System.Drawing.Point(254, 38);
            this.lastNameTextEdit.Name = "lastNameTextEdit";
            this.lastNameTextEdit.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextEdit.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Логин :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Пароль :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(222, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Имя :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(197, 41);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Фамилия :";
            // 
            // activeCheckEdit
            // 
            this.activeCheckEdit.Location = new System.Drawing.Point(252, 64);
            this.activeCheckEdit.Name = "activeCheckEdit";
            this.activeCheckEdit.Properties.Caption = "Активен";
            this.activeCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.activeCheckEdit.TabIndex = 9;
            // 
            // newPasswordCheckEdit
            // 
            this.newPasswordCheckEdit.Location = new System.Drawing.Point(81, 64);
            this.newPasswordCheckEdit.Name = "newPasswordCheckEdit";
            this.newPasswordCheckEdit.Properties.Caption = "Новый пароль";
            this.newPasswordCheckEdit.Size = new System.Drawing.Size(101, 19);
            this.newPasswordCheckEdit.TabIndex = 10;
            this.newPasswordCheckEdit.Visible = false;
            this.newPasswordCheckEdit.CheckedChanged += new System.EventHandler(this.NewPasswordCheckEditCheckedChanged);
            // 
            // bottomPanelControl
            // 
            this.bottomPanelControl.Controls.Add(this.cancelButton);
            this.bottomPanelControl.Controls.Add(this.saveButton);
            this.bottomPanelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanelControl.Location = new System.Drawing.Point(0, 340);
            this.bottomPanelControl.Name = "bottomPanelControl";
            this.bottomPanelControl.Size = new System.Drawing.Size(417, 34);
            this.bottomPanelControl.TabIndex = 11;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(239, 6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(165, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отменить";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(167, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // topPanelControl
            // 
            this.topPanelControl.Controls.Add(this.labelControl5);
            this.topPanelControl.Controls.Add(this.loginTextEdit);
            this.topPanelControl.Controls.Add(this.passwordTextEdit);
            this.topPanelControl.Controls.Add(this.newPasswordCheckEdit);
            this.topPanelControl.Controls.Add(this.firstNameTextEdit);
            this.topPanelControl.Controls.Add(this.activeCheckEdit);
            this.topPanelControl.Controls.Add(this.lastNameTextEdit);
            this.topPanelControl.Controls.Add(this.labelControl4);
            this.topPanelControl.Controls.Add(this.labelControl1);
            this.topPanelControl.Controls.Add(this.labelControl3);
            this.topPanelControl.Controls.Add(this.labelControl2);
            this.topPanelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanelControl.Location = new System.Drawing.Point(0, 0);
            this.topPanelControl.Name = "topPanelControl";
            this.topPanelControl.Size = new System.Drawing.Size(417, 109);
            this.topPanelControl.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(89, 89);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(238, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Возможные группы для данного пользователя";
            // 
            // bodyPanelControl
            // 
            this.bodyPanelControl.Controls.Add(this.gridControl1);
            this.bodyPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanelControl.Location = new System.Drawing.Point(0, 109);
            this.bodyPanelControl.Name = "bodyPanelControl";
            this.bodyPanelControl.Size = new System.Drawing.Size(417, 231);
            this.bodyPanelControl.TabIndex = 13;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.groupUsersBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.groupUsersGridView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(413, 227);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.groupUsersGridView});
            // 
            // groupUsersBindingSource
            // 
            this.groupUsersBindingSource.DataMember = "GroupUsers";
            this.groupUsersBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupUsersGridView
            // 
            this.groupUsersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserGroupID,
            this.colUserGroupName,
            this.colUserGroupDescription,
            this.Checked});
            this.groupUsersGridView.GridControl = this.gridControl1;
            this.groupUsersGridView.Name = "groupUsersGridView";
            this.groupUsersGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.groupUsersGridView.OptionsView.ColumnAutoWidth = false;
            this.groupUsersGridView.OptionsView.ShowAutoFilterRow = true;
            this.groupUsersGridView.OptionsView.ShowGroupPanel = false;
            this.groupUsersGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.GroupUsersGridViewCellValueChanged);
            this.groupUsersGridView.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.GroupUsersGridViewCellValueChanging);
            // 
            // colUserGroupID
            // 
            this.colUserGroupID.FieldName = "ID";
            this.colUserGroupID.Name = "colUserGroupID";
            this.colUserGroupID.OptionsColumn.ReadOnly = true;
            // 
            // colUserGroupName
            // 
            this.colUserGroupName.Caption = "Название группы";
            this.colUserGroupName.FieldName = "Name";
            this.colUserGroupName.Name = "colUserGroupName";
            this.colUserGroupName.OptionsColumn.AllowEdit = false;
            this.colUserGroupName.Visible = true;
            this.colUserGroupName.VisibleIndex = 1;
            this.colUserGroupName.Width = 99;
            // 
            // colUserGroupDescription
            // 
            this.colUserGroupDescription.Caption = "Описание группы";
            this.colUserGroupDescription.FieldName = "Description";
            this.colUserGroupDescription.Name = "colUserGroupDescription";
            this.colUserGroupDescription.OptionsColumn.AllowEdit = false;
            this.colUserGroupDescription.Visible = true;
            this.colUserGroupDescription.VisibleIndex = 2;
            this.colUserGroupDescription.Width = 154;
            // 
            // Checked
            // 
            this.Checked.Caption = " ";
            this.Checked.FieldName = "Checked";
            this.Checked.Name = "Checked";
            this.Checked.OptionsColumn.AllowIncrementalSearch = false;
            this.Checked.Visible = true;
            this.Checked.VisibleIndex = 0;
            this.Checked.Width = 20;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // groupUsersTableAdapter
            // 
            this.groupUsersTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 374);
            this.Controls.Add(this.bodyPanelControl);
            this.Controls.Add(this.topPanelControl);
            this.Controls.Add(this.bottomPanelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAddEditUser";
            this.Load += new System.EventHandler(this.FrmAddEditUserLoad);
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPanelControl)).EndInit();
            this.bottomPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topPanelControl)).EndInit();
            this.topPanelControl.ResumeLayout(false);
            this.topPanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bodyPanelControl)).EndInit();
            this.bodyPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupUsersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit loginTextEdit;
        private DevExpress.XtraEditors.TextEdit passwordTextEdit;
        private DevExpress.XtraEditors.TextEdit firstNameTextEdit;
        private DevExpress.XtraEditors.TextEdit lastNameTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit activeCheckEdit;
        private DevExpress.XtraEditors.CheckEdit newPasswordCheckEdit;
        private DevExpress.XtraEditors.PanelControl bottomPanelControl;
        private DevExpress.XtraEditors.PanelControl topPanelControl;
        private DevExpress.XtraEditors.PanelControl bodyPanelControl;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView groupUsersGridView;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource groupUsersBindingSource;
        private WMSDataSetTableAdapters.GroupUsersTableAdapter groupUsersTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colUserGroupID;
        private DevExpress.XtraGrid.Columns.GridColumn colUserGroupName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserGroupDescription;
        private DevExpress.XtraGrid.Columns.GridColumn Checked;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
    }
}