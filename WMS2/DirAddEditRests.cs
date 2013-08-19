using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.DataBaseLayers;
using WMS.Globals;

namespace WMS.MainApplication
{
    public partial class DirAddEditRests : DevExpress.XtraEditors.XtraForm
    {
        public int Id { get; private set; }
        public string Description { get; private set; }
        public bool AddNewRecord { get; private set; }

        public DirAddEditRests(bool setAddNewRecord)
        {
            InitializeComponent();
            SetAddNewRecord(setAddNewRecord);
            RenameLabels();
        }

        public void SetAddNewRecord(bool result)
        {
            AddNewRecord = result;
        }

        public void SetData(int id, string description)
        {
            Id = id;
            Description = description;
        }

        private void RenameLabels()
        {
            Text = AddNewRecord ? "Добавление нового типа остатков" : "Изменение типа остатков";
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            if (nameTextEdit.Text != Description)
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

        private void SaveButtonClick(object sender, EventArgs e)
        {
            var worker = new DbDirsAddEdit();
            try
            {
                if (AddNewRecord)
                    worker.AddTypeOfRest(nameTextEdit.Text);
                else
                    worker.EditTypeOfRest(Id, nameTextEdit.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(ee.Message);                
                throw;
            }
            
        }

        private void DirAddEditRestsLoad(object sender, EventArgs e)
        {
            nameTextEdit.Text = Description;
        }
    }
}