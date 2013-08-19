namespace WMS.Assembly
{
    partial class FrmCollectator
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.collectGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.collectatoriBindingSource = new System.Windows.Forms.BindingSource();
            this.onixDataSet = new WMS.Assembly.OnixDataSet();
            this.collectGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCLT1001 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLT1002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcnt_doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.selectButton = new DevExpress.XtraEditors.SimpleButton();
            this.commMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.collectatoriTableAdapter = new WMS.Assembly.OnixDataSetTableAdapters.CollectatoriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collectGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectatoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onixDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectGridLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commMemoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.collectGridLookUpEdit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(292, 59);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Сборщик";
            // 
            // collectGridLookUpEdit
            // 
            this.collectGridLookUpEdit.Location = new System.Drawing.Point(7, 28);
            this.collectGridLookUpEdit.Name = "collectGridLookUpEdit";
            this.collectGridLookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.collectGridLookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.collectGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.collectGridLookUpEdit.Properties.DataSource = this.collectatoriBindingSource;
            this.collectGridLookUpEdit.Properties.DisplayMember = "CLT1002";
            this.collectGridLookUpEdit.Properties.NullText = "[Выберите сборщика]";
            this.collectGridLookUpEdit.Properties.ValueMember = "CLT1001";
            this.collectGridLookUpEdit.Properties.View = this.collectGridLookUpEditView;
            this.collectGridLookUpEdit.Size = new System.Drawing.Size(277, 23);
            this.collectGridLookUpEdit.TabIndex = 1;
            this.collectGridLookUpEdit.Popup += new System.EventHandler(this.gridLookUpEdit1_Popup);
            this.collectGridLookUpEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridLookUpEdit1_KeyPress);
            // 
            // collectatoriBindingSource
            // 
            this.collectatoriBindingSource.DataMember = "Collectatori";
            this.collectatoriBindingSource.DataSource = this.onixDataSet;
            // 
            // onixDataSet
            // 
            this.onixDataSet.DataSetName = "OnixDataSet";
            this.onixDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // collectGridLookUpEditView
            // 
            this.collectGridLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCLT1001,
            this.colCLT1002,
            this.colcnt_doc});
            this.collectGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.collectGridLookUpEditView.Name = "collectGridLookUpEditView";
            this.collectGridLookUpEditView.OptionsBehavior.AllowIncrementalSearch = true;
            this.collectGridLookUpEditView.OptionsBehavior.Editable = false;
            this.collectGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.collectGridLookUpEditView.OptionsView.ShowAutoFilterRow = true;
            this.collectGridLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // colCLT1001
            // 
            this.colCLT1001.FieldName = "CLT1001";
            this.colCLT1001.Name = "colCLT1001";
            this.colCLT1001.OptionsColumn.ReadOnly = true;
            // 
            // colCLT1002
            // 
            this.colCLT1002.Caption = "Сборщик";
            this.colCLT1002.FieldName = "CLT1002";
            this.colCLT1002.Name = "colCLT1002";
            this.colCLT1002.Visible = true;
            this.colCLT1002.VisibleIndex = 0;
            // 
            // colcnt_doc
            // 
            this.colcnt_doc.Caption = "Кол-во заказов";
            this.colcnt_doc.FieldName = "cnt_doc";
            this.colcnt_doc.Name = "colcnt_doc";
            this.colcnt_doc.OptionsColumn.ReadOnly = true;
            this.colcnt_doc.Visible = true;
            this.colcnt_doc.VisibleIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.selectButton);
            this.groupControl2.Controls.Add(this.commMemoEdit);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 59);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(292, 214);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Комментарий";
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(7, 186);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(280, 23);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Выбрать";
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // commMemoEdit
            // 
            this.commMemoEdit.Location = new System.Drawing.Point(5, 25);
            this.commMemoEdit.Name = "commMemoEdit";
            this.commMemoEdit.Size = new System.Drawing.Size(282, 157);
            this.commMemoEdit.TabIndex = 0;
            // 
            // collectatoriTableAdapter
            // 
            this.collectatoriTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCollectator
            // 
            this.AcceptButton = this.selectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCollectator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор сборщика";
            this.Load += new System.EventHandler(this.FrmCollectator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.collectGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectatoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onixDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectGridLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commMemoEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.MemoEdit commMemoEdit;
        private OnixDataSet onixDataSet;
        private System.Windows.Forms.BindingSource collectatoriBindingSource;
        private OnixDataSetTableAdapters.CollectatoriTableAdapter collectatoriTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit collectGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView collectGridLookUpEditView;
        private DevExpress.XtraGrid.Columns.GridColumn colCLT1001;
        private DevExpress.XtraGrid.Columns.GridColumn colCLT1002;
        private DevExpress.XtraGrid.Columns.GridColumn colcnt_doc;
        private DevExpress.XtraEditors.SimpleButton selectButton;
    }
}