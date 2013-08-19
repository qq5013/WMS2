namespace WMS.Administration
{
    partial class FrmAddEditUserGroup
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
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.descriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.topPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.bottomPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.wMSDataSet = new WMS.Administration.WMSDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource();
            this.usersTableAdapter = new WMS.Administration.WMSDataSetTableAdapters.UsersTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.freeUsersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Checked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.codFreeUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreeUserLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreeUserFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreeUserLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreeUserActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPanelControl)).BeginInit();
            this.topPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPanelControl)).BeginInit();
            this.bottomPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeUsersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.Location = new System.Drawing.Point(130, 16);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(128, 20);
            this.nameTextEdit.TabIndex = 0;
            // 
            // descriptionTextEdit
            // 
            this.descriptionTextEdit.Location = new System.Drawing.Point(130, 51);
            this.descriptionTextEdit.Name = "descriptionTextEdit";
            this.descriptionTextEdit.Size = new System.Drawing.Size(240, 20);
            this.descriptionTextEdit.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Название группы :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Описание группы :";
            // 
            // topPanelControl
            // 
            this.topPanelControl.Controls.Add(this.labelControl3);
            this.topPanelControl.Controls.Add(this.nameTextEdit);
            this.topPanelControl.Controls.Add(this.labelControl2);
            this.topPanelControl.Controls.Add(this.descriptionTextEdit);
            this.topPanelControl.Controls.Add(this.labelControl1);
            this.topPanelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanelControl.Location = new System.Drawing.Point(0, 0);
            this.topPanelControl.Name = "topPanelControl";
            this.topPanelControl.Size = new System.Drawing.Size(397, 102);
            this.topPanelControl.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(79, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(220, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Свободные пользователи для этой группы";
            // 
            // bottomPanelControl
            // 
            this.bottomPanelControl.Controls.Add(this.cancelButton);
            this.bottomPanelControl.Controls.Add(this.saveButton);
            this.bottomPanelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanelControl.Location = new System.Drawing.Point(0, 270);
            this.bottomPanelControl.Name = "bottomPanelControl";
            this.bottomPanelControl.Size = new System.Drawing.Size(397, 38);
            this.bottomPanelControl.TabIndex = 5;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(253, 7);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(129, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 7);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(133, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.wMSDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.usersBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 102);
            this.gridControl1.MainView = this.freeUsersGridView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(397, 168);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.freeUsersGridView});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // freeUsersGridView
            // 
            this.freeUsersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Checked,
            this.codFreeUserID,
            this.colFreeUserLogin,
            this.colFreeUserFirstName,
            this.colFreeUserLastName,
            this.colFreeUserActive});
            this.freeUsersGridView.GridControl = this.gridControl1;
            this.freeUsersGridView.Name = "freeUsersGridView";
            this.freeUsersGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.freeUsersGridView.OptionsSelection.MultiSelect = true;
            this.freeUsersGridView.OptionsView.ColumnAutoWidth = false;
            this.freeUsersGridView.OptionsView.ShowAutoFilterRow = true;
            this.freeUsersGridView.OptionsView.ShowGroupPanel = false;
            this.freeUsersGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFreeUserLogin, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // Checked
            // 
            this.Checked.Caption = " ";
            this.Checked.FieldName = "Checked";
            this.Checked.Name = "Checked";
            this.Checked.Visible = true;
            this.Checked.VisibleIndex = 0;
            this.Checked.Width = 20;
            // 
            // codFreeUserID
            // 
            this.codFreeUserID.Caption = "Код";
            this.codFreeUserID.FieldName = "ID";
            this.codFreeUserID.Name = "codFreeUserID";
            this.codFreeUserID.OptionsColumn.AllowEdit = false;
            this.codFreeUserID.Width = 45;
            // 
            // colFreeUserLogin
            // 
            this.colFreeUserLogin.Caption = "Логин";
            this.colFreeUserLogin.FieldName = "Login";
            this.colFreeUserLogin.Name = "colFreeUserLogin";
            this.colFreeUserLogin.OptionsColumn.AllowEdit = false;
            this.colFreeUserLogin.Visible = true;
            this.colFreeUserLogin.VisibleIndex = 1;
            // 
            // colFreeUserFirstName
            // 
            this.colFreeUserFirstName.Caption = "Имя";
            this.colFreeUserFirstName.FieldName = "FirstName";
            this.colFreeUserFirstName.Name = "colFreeUserFirstName";
            this.colFreeUserFirstName.OptionsColumn.AllowEdit = false;
            this.colFreeUserFirstName.Visible = true;
            this.colFreeUserFirstName.VisibleIndex = 2;
            this.colFreeUserFirstName.Width = 101;
            // 
            // colFreeUserLastName
            // 
            this.colFreeUserLastName.Caption = "Фамилия";
            this.colFreeUserLastName.FieldName = "LastName";
            this.colFreeUserLastName.Name = "colFreeUserLastName";
            this.colFreeUserLastName.OptionsColumn.AllowEdit = false;
            this.colFreeUserLastName.Visible = true;
            this.colFreeUserLastName.VisibleIndex = 3;
            this.colFreeUserLastName.Width = 105;
            // 
            // colFreeUserActive
            // 
            this.colFreeUserActive.Caption = "Активен";
            this.colFreeUserActive.FieldName = "Active";
            this.colFreeUserActive.Name = "colFreeUserActive";
            this.colFreeUserActive.OptionsColumn.AllowEdit = false;
            this.colFreeUserActive.OptionsColumn.ReadOnly = true;
            this.colFreeUserActive.Visible = true;
            this.colFreeUserActive.VisibleIndex = 4;
            this.colFreeUserActive.Width = 53;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // FrmAddEditUserGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 308);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.bottomPanelControl);
            this.Controls.Add(this.topPanelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddEditUserGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAddEditUserGroup";
            this.Load += new System.EventHandler(this.FrmAddEditUserGroupLoad);
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPanelControl)).EndInit();
            this.topPanelControl.ResumeLayout(false);
            this.topPanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPanelControl)).EndInit();
            this.bottomPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeUsersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit descriptionTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl topPanelControl;
        private DevExpress.XtraEditors.PanelControl bottomPanelControl;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private WMSDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView freeUsersGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colFreeUserLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colFreeUserFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colFreeUserLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colFreeUserActive;
        private DevExpress.XtraGrid.Columns.GridColumn codFreeUserID;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Checked;
    }
}