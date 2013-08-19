using WMS.Assembly.OnixDataSetTableAdapters;

namespace WMS.Assembly
{
    partial class FrmAssembly
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
            this.topPanel = new DevExpress.XtraEditors.PanelControl();
            this.withoutAssamblyCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.withoutAssamblyButton = new DevExpress.XtraEditors.SimpleButton();
            this.replayPrintNumDocTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.replayPrintCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.printLabelsButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.secondsLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.rangeTimeSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.autoRefreshCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.acceptAssemblySimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.refreshButton = new DevExpress.XtraEditors.SimpleButton();
            this.bodyPanel = new DevExpress.XtraEditors.PanelControl();
            this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.assemblyGridControl = new DevExpress.XtraGrid.GridControl();
            this.getListSborBindingSource = new System.Windows.Forms.BindingSource();
            this.onixDataSet = new WMS.Assembly.OnixDataSet();
            this.assemblyGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colras1005 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colras1007 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colras1015 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpos1002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colschet_ras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltype_ras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colauthor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumNN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.getListSborTableAdapter = new WMS.Assembly.OnixDataSetTableAdapters.GetListSborTableAdapter();
            this.bodyDocTableAdapter = new WMS.Assembly.OnixDataSetTableAdapters.BodyDocTableAdapter();
            this.collectatoriTableAdapter = new WMS.Assembly.OnixDataSetTableAdapters.CollectatoriTableAdapter();
            this.headDocTableAdapter = new WMS.Assembly.OnixDataSetTableAdapters.HeadDocTableAdapter();
            this.rutDocTableAdapter = new WMS.Assembly.OnixDataSetTableAdapters.RutDocTableAdapter();
            this.timer = new System.Windows.Forms.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.topPanel)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.withoutAssamblyCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replayPrintNumDocTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replayPrintCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeTimeSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoRefreshCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyPanel)).BeginInit();
            this.bodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListSborBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onixDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.withoutAssamblyCheckEdit);
            this.topPanel.Controls.Add(this.withoutAssamblyButton);
            this.topPanel.Controls.Add(this.replayPrintNumDocTextEdit);
            this.topPanel.Controls.Add(this.labelControl1);
            this.topPanel.Controls.Add(this.replayPrintCheckEdit);
            this.topPanel.Controls.Add(this.printLabelsButton);
            this.topPanel.Controls.Add(this.simpleButton2);
            this.topPanel.Controls.Add(this.secondsLabelControl);
            this.topPanel.Controls.Add(this.rangeTimeSpinEdit);
            this.topPanel.Controls.Add(this.autoRefreshCheckEdit);
            this.topPanel.Controls.Add(this.simpleButton1);
            this.topPanel.Controls.Add(this.acceptAssemblySimpleButton);
            this.topPanel.Controls.Add(this.refreshButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(950, 70);
            this.topPanel.TabIndex = 0;
            // 
            // withoutAssamblyCheckEdit
            // 
            this.withoutAssamblyCheckEdit.Location = new System.Drawing.Point(638, 5);
            this.withoutAssamblyCheckEdit.Name = "withoutAssamblyCheckEdit";
            this.withoutAssamblyCheckEdit.Properties.Caption = "Без сборки товара";
            this.withoutAssamblyCheckEdit.Size = new System.Drawing.Size(126, 19);
            this.withoutAssamblyCheckEdit.TabIndex = 12;
            this.withoutAssamblyCheckEdit.CheckedChanged += new System.EventHandler(this.WithoutAssamblyCheckEditCheckedChanged);
            // 
            // withoutAssamblyButton
            // 
            this.withoutAssamblyButton.Location = new System.Drawing.Point(640, 31);
            this.withoutAssamblyButton.Name = "withoutAssamblyButton";
            this.withoutAssamblyButton.Size = new System.Drawing.Size(124, 32);
            this.withoutAssamblyButton.TabIndex = 11;
            this.withoutAssamblyButton.Text = "Провести документ \r\nбез печати";
            this.withoutAssamblyButton.Visible = false;
            this.withoutAssamblyButton.Click += new System.EventHandler(this.WithoutAssamblyButtonClick);
            // 
            // replayPrintNumDocTextEdit
            // 
            this.replayPrintNumDocTextEdit.EditValue = "";
            this.replayPrintNumDocTextEdit.Location = new System.Drawing.Point(530, 28);
            this.replayPrintNumDocTextEdit.Name = "replayPrintNumDocTextEdit";
            this.replayPrintNumDocTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.replayPrintNumDocTextEdit.Properties.Appearance.Options.UseFont = true;
            this.replayPrintNumDocTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.replayPrintNumDocTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.replayPrintNumDocTextEdit.Properties.Mask.BeepOnError = true;
            this.replayPrintNumDocTextEdit.Properties.Mask.EditMask = "d";
            this.replayPrintNumDocTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.replayPrintNumDocTextEdit.Size = new System.Drawing.Size(60, 20);
            this.replayPrintNumDocTextEdit.TabIndex = 10;
            this.replayPrintNumDocTextEdit.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(441, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Номер расхода :";
            this.labelControl1.Visible = false;
            // 
            // replayPrintCheckEdit
            // 
            this.replayPrintCheckEdit.Location = new System.Drawing.Point(439, 5);
            this.replayPrintCheckEdit.Name = "replayPrintCheckEdit";
            this.replayPrintCheckEdit.Properties.Caption = "Повторная печать документов";
            this.replayPrintCheckEdit.Size = new System.Drawing.Size(183, 19);
            this.replayPrintCheckEdit.TabIndex = 8;
            this.replayPrintCheckEdit.CheckedChanged += new System.EventHandler(this.ReplayPrintCheckEditCheckedChanged);
            // 
            // printLabelsButton
            // 
            this.printLabelsButton.Location = new System.Drawing.Point(360, 12);
            this.printLabelsButton.Name = "printLabelsButton";
            this.printLabelsButton.Size = new System.Drawing.Size(63, 23);
            this.printLabelsButton.TabIndex = 7;
            this.printLabelsButton.Text = "Этикетки";
            this.printLabelsButton.Click += new System.EventHandler(this.SimpleButton1Click1);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(816, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(122, 23);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Дизайнер";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // secondsLabelControl
            // 
            this.secondsLabelControl.Location = new System.Drawing.Point(177, 38);
            this.secondsLabelControl.Name = "secondsLabelControl";
            this.secondsLabelControl.Size = new System.Drawing.Size(36, 13);
            this.secondsLabelControl.TabIndex = 4;
            this.secondsLabelControl.Text = "секунд";
            this.secondsLabelControl.Visible = false;
            // 
            // rangeTimeSpinEdit
            // 
            this.rangeTimeSpinEdit.EditValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.rangeTimeSpinEdit.Location = new System.Drawing.Point(133, 35);
            this.rangeTimeSpinEdit.Name = "rangeTimeSpinEdit";
            this.rangeTimeSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.rangeTimeSpinEdit.Properties.Mask.EditMask = "d";
            this.rangeTimeSpinEdit.Properties.MaxValue = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.rangeTimeSpinEdit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rangeTimeSpinEdit.Size = new System.Drawing.Size(38, 20);
            this.rangeTimeSpinEdit.TabIndex = 3;
            this.rangeTimeSpinEdit.Visible = false;
            this.rangeTimeSpinEdit.EditValueChanged += new System.EventHandler(this.rangeTimeSpinEdit_EditValueChanged);
            // 
            // autoRefreshCheckEdit
            // 
            this.autoRefreshCheckEdit.Location = new System.Drawing.Point(12, 38);
            this.autoRefreshCheckEdit.Name = "autoRefreshCheckEdit";
            this.autoRefreshCheckEdit.Properties.Caption = "Автообновление";
            this.autoRefreshCheckEdit.Size = new System.Drawing.Size(114, 19);
            this.autoRefreshCheckEdit.TabIndex = 2;
            this.autoRefreshCheckEdit.CheckedChanged += new System.EventHandler(this.AutoRefreshCheckEditCheckedChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(223, 38);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(146, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Отдать на сборку NEW";
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // acceptAssemblySimpleButton
            // 
            this.acceptAssemblySimpleButton.Location = new System.Drawing.Point(223, 12);
            this.acceptAssemblySimpleButton.Name = "acceptAssemblySimpleButton";
            this.acceptAssemblySimpleButton.Size = new System.Drawing.Size(122, 23);
            this.acceptAssemblySimpleButton.TabIndex = 1;
            this.acceptAssemblySimpleButton.Text = "Отдать на сборку";
            this.acceptAssemblySimpleButton.Click += new System.EventHandler(this.AcceptAssemblySimpleButtonClick);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(12, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.Click += new System.EventHandler(this.RefreshButtonClick);
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.marqueeProgressBarControl1);
            this.bodyPanel.Controls.Add(this.assemblyGridControl);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 70);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(950, 480);
            this.bodyPanel.TabIndex = 1;
            // 
            // marqueeProgressBarControl1
            // 
            this.marqueeProgressBarControl1.EditValue = "Выполняется запрос к базе данных ...";
            this.marqueeProgressBarControl1.Location = new System.Drawing.Point(57, 124);
            this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
            this.marqueeProgressBarControl1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.marqueeProgressBarControl1.Properties.MarqueeAnimationSpeed = 10;
            this.marqueeProgressBarControl1.Properties.ShowTitle = true;
            this.marqueeProgressBarControl1.Size = new System.Drawing.Size(612, 18);
            this.marqueeProgressBarControl1.TabIndex = 7;
            this.marqueeProgressBarControl1.Visible = false;
            // 
            // assemblyGridControl
            // 
            this.assemblyGridControl.DataSource = this.getListSborBindingSource;
            this.assemblyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assemblyGridControl.Location = new System.Drawing.Point(2, 2);
            this.assemblyGridControl.MainView = this.assemblyGridView;
            this.assemblyGridControl.Name = "assemblyGridControl";
            this.assemblyGridControl.Size = new System.Drawing.Size(946, 476);
            this.assemblyGridControl.TabIndex = 0;
            this.assemblyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.assemblyGridView});
            // 
            // getListSborBindingSource
            // 
            this.getListSborBindingSource.DataMember = "GetListSbor";
            this.getListSborBindingSource.DataSource = this.onixDataSet;
            // 
            // onixDataSet
            // 
            this.onixDataSet.DataSetName = "OnixDataSet";
            this.onixDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assemblyGridView
            // 
            this.assemblyGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_doc,
            this.colras1005,
            this.colras1007,
            this.colras1015,
            this.colpos1002,
            this.colschet_ras,
            this.coltype_ras,
            this.colcomm,
            this.colauthor,
            this.colNumNN});
            this.assemblyGridView.GridControl = this.assemblyGridControl;
            this.assemblyGridView.Name = "assemblyGridView";
            this.assemblyGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.assemblyGridView.OptionsBehavior.Editable = false;
            this.assemblyGridView.OptionsView.ColumnAutoWidth = false;
            this.assemblyGridView.OptionsView.ShowAutoFilterRow = true;
            this.assemblyGridView.OptionsView.ShowFooter = true;
            this.assemblyGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colid_doc
            // 
            this.colid_doc.FieldName = "id_doc";
            this.colid_doc.Name = "colid_doc";
            // 
            // colras1005
            // 
            this.colras1005.Caption = "Номер расхода";
            this.colras1005.FieldName = "ras1005";
            this.colras1005.Name = "colras1005";
            this.colras1005.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colras1005.Visible = true;
            this.colras1005.VisibleIndex = 0;
            this.colras1005.Width = 88;
            // 
            // colras1007
            // 
            this.colras1007.Caption = "Дата расхода";
            this.colras1007.DisplayFormat.FormatString = "G";
            this.colras1007.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colras1007.FieldName = "ras1007";
            this.colras1007.Name = "colras1007";
            this.colras1007.Visible = true;
            this.colras1007.VisibleIndex = 1;
            this.colras1007.Width = 120;
            // 
            // colras1015
            // 
            this.colras1015.Caption = "Сумма";
            this.colras1015.DisplayFormat.FormatString = "f";
            this.colras1015.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colras1015.FieldName = "ras1015";
            this.colras1015.Name = "colras1015";
            this.colras1015.Visible = true;
            this.colras1015.VisibleIndex = 2;
            this.colras1015.Width = 82;
            // 
            // colpos1002
            // 
            this.colpos1002.Caption = "Покупатель";
            this.colpos1002.FieldName = "pos1002";
            this.colpos1002.Name = "colpos1002";
            this.colpos1002.Visible = true;
            this.colpos1002.VisibleIndex = 3;
            this.colpos1002.Width = 302;
            // 
            // colschet_ras
            // 
            this.colschet_ras.Caption = "Тип счёта";
            this.colschet_ras.FieldName = "schet_ras";
            this.colschet_ras.Name = "colschet_ras";
            this.colschet_ras.Visible = true;
            this.colschet_ras.VisibleIndex = 4;
            this.colschet_ras.Width = 92;
            // 
            // coltype_ras
            // 
            this.coltype_ras.Caption = "Тип расхода";
            this.coltype_ras.FieldName = "type_ras";
            this.coltype_ras.Name = "coltype_ras";
            this.coltype_ras.Visible = true;
            this.coltype_ras.VisibleIndex = 5;
            this.coltype_ras.Width = 121;
            // 
            // colcomm
            // 
            this.colcomm.Caption = "Комментарий";
            this.colcomm.FieldName = "comm";
            this.colcomm.Name = "colcomm";
            this.colcomm.Visible = true;
            this.colcomm.VisibleIndex = 6;
            this.colcomm.Width = 136;
            // 
            // colauthor
            // 
            this.colauthor.Caption = "Автор документа";
            this.colauthor.FieldName = "author";
            this.colauthor.Name = "colauthor";
            this.colauthor.Visible = true;
            this.colauthor.VisibleIndex = 7;
            this.colauthor.Width = 122;
            // 
            // colNumNN
            // 
            this.colNumNN.Caption = "Номер НН";
            this.colNumNN.FieldName = "NumNN";
            this.colNumNN.Name = "colNumNN";
            this.colNumNN.Visible = true;
            this.colNumNN.VisibleIndex = 8;
            this.colNumNN.Width = 60;
            // 
            // getListSborTableAdapter
            // 
            this.getListSborTableAdapter.ClearBeforeFill = true;
            // 
            // bodyDocTableAdapter
            // 
            this.bodyDocTableAdapter.ClearBeforeFill = true;
            // 
            // collectatoriTableAdapter
            // 
            this.collectatoriTableAdapter.ClearBeforeFill = true;
            // 
            // headDocTableAdapter
            // 
            this.headDocTableAdapter.ClearBeforeFill = true;
            // 
            // rutDocTableAdapter
            // 
            this.rutDocTableAdapter.ClearBeforeFill = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmAssembly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "FrmAssembly";
            this.Text = "FrmAssembly";
            this.Load += new System.EventHandler(this.FrmAssemblyLoad);
            ((System.ComponentModel.ISupportInitialize)(this.topPanel)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.withoutAssamblyCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replayPrintNumDocTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replayPrintCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeTimeSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoRefreshCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyPanel)).EndInit();
            this.bodyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListSborBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onixDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl topPanel;
        private DevExpress.XtraEditors.PanelControl bodyPanel;
        private DevExpress.XtraGrid.GridControl assemblyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView assemblyGridView;
        private OnixDataSet onixDataSet;
        private System.Windows.Forms.BindingSource getListSborBindingSource;
        private OnixDataSetTableAdapters.GetListSborTableAdapter getListSborTableAdapter;

        private System.Windows.Forms.BindingSource collectatoriBindingSource;
        private OnixDataSetTableAdapters.CollectatoriTableAdapter collectatoriTableAdapter;

        private System.Windows.Forms.BindingSource bodyDocBindingSource;
        private OnixDataSetTableAdapters.BodyDocTableAdapter bodyDocTableAdapter;

        private System.Windows.Forms.BindingSource headDocBindingSource;
        private OnixDataSetTableAdapters.HeadDocTableAdapter headDocTableAdapter;

        private System.Windows.Forms.BindingSource rutDocBindingSource;
        private OnixDataSetTableAdapters.RutDocTableAdapter rutDocTableAdapter;
        
        private DevExpress.XtraGrid.Columns.GridColumn colid_doc;
        private DevExpress.XtraGrid.Columns.GridColumn colras1005;
        private DevExpress.XtraGrid.Columns.GridColumn colras1007;
        private DevExpress.XtraGrid.Columns.GridColumn colras1015;
        private DevExpress.XtraGrid.Columns.GridColumn colpos1002;
        private DevExpress.XtraGrid.Columns.GridColumn colschet_ras;
        private DevExpress.XtraGrid.Columns.GridColumn coltype_ras;
        private DevExpress.XtraGrid.Columns.GridColumn colcomm;
        private DevExpress.XtraGrid.Columns.GridColumn colauthor;
        private DevExpress.XtraGrid.Columns.GridColumn colNumNN;
        private DevExpress.XtraEditors.SimpleButton refreshButton;
        private DevExpress.XtraEditors.SimpleButton acceptAssemblySimpleButton;
        private DevExpress.XtraEditors.LabelControl secondsLabelControl;
        private DevExpress.XtraEditors.SpinEdit rangeTimeSpinEdit;
        private DevExpress.XtraEditors.CheckEdit autoRefreshCheckEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBarControl1;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraEditors.SimpleButton printLabelsButton;
        private DevExpress.XtraEditors.TextEdit replayPrintNumDocTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit replayPrintCheckEdit;
        private DevExpress.XtraEditors.CheckEdit withoutAssamblyCheckEdit;
        private DevExpress.XtraEditors.SimpleButton withoutAssamblyButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;


    }
}
