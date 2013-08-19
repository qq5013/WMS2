using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.DataBaseLayers;

namespace WMS.AddressMigration
{
    public partial class FrmAddressMigration : XtraForm
    {
        public int FindedSku { get; set; }
        public FrmAddressMigration()
        {
            InitializeComponent();
            asignmentAddressForSkuTableAdapter.Connection.ConnectionString = Globals.GlobalParameters.WmsConnectionString;
            emptyAddressesForPartTableAdapter.Connection.ConnectionString = Globals.GlobalParameters.WmsConnectionString;
        }

        private void FrmAddressMigrationLoad(object sender, System.EventArgs e)
        {
            findSkuTextEdit.Focus();
            splitContainerControl1.Visible = false;
        }

        private void FindSkuTextEditKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            var worker = new DataBaseLayers.AddressMigration();
            var result =
                worker.FindSku(findSkuTextEdit.Text.Substring(findSkuTextEdit.Text.Length - 1, 1) == ";"
                                   ? findSkuTextEdit.Text.Substring(0, findSkuTextEdit.Text.Length - 1)
                                   : findSkuTextEdit.Text);

            if (result.IdSku > 0)
            {
                FindedSku = result.IdSku;
                if (result.FoundSkuBy == FoundSkuBy.Address)
                    asignmentAddressForSkuTableAdapter.FillByAddress(addressMigrationWMSDataSet.AsignmentAddressForSku,
                                                                     worker.FindIdAddressFromCatalog(
                                                                         findSkuTextEdit.Text));
                else
                    asignmentAddressForSkuTableAdapter.FillBySku(addressMigrationWMSDataSet.AsignmentAddressForSku,
                                                                 result.IdSku);
                if (addressMigrationWMSDataSet.AsignmentAddressForSku.Rows.Count <= 0)
                {
                    skuDescriptionLabelControl.Text = "Не найдено на одного адреса для этой партии!";
                    skuDescriptionLabelControl.ForeColor = Color.Red;
                    splitContainerControl1.Visible = false;
                    moveAllQtyButton.Enabled = false;
                    movePartialQtyButton.Enabled = false;
                    cleanAddressButton.Enabled = false;
                }
                else
                {
                    skuDescriptionLabelControl.Text = worker.GetDescriptionForSku(result.IdSku);
                    skuDescriptionLabelControl.ForeColor = Color.Black;
                    splitContainerControl1.Visible = true;
                    addressGridView.FocusedRowHandle = 0;
                    moveAllQtyButton.Enabled = true;
                    movePartialQtyButton.Enabled = true;
                    cleanAddressButton.Enabled = true;
                }
                addressGridView.ExpandAllGroups();
                addressGridView.BestFitColumns();
            }
            else
            {
                skuDescriptionLabelControl.Text = "Не найден тоавр для данного запроса!";
                skuDescriptionLabelControl.ForeColor = Color.Red;
                splitContainerControl1.Visible = false;
                moveAllQtyButton.Enabled = false;
                movePartialQtyButton.Enabled = false;
                cleanAddressButton.Enabled = false;
            }
            findSkuTextEdit.Focus();
            findSkuTextEdit.SelectAll();
            //findSkuTextEdit.Text = "";
        }

        private void AddressGridViewFocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (addressGridView.FocusedRowHandle >= 0)
            {
                emptyAddressesForPartTableAdapter.Fill(addressMigrationWMSDataSet.EmptyAddressesForPart,
                                                       Convert.ToInt32(
                                                           addressGridView.GetRowCellValue(
                                                               addressGridView.FocusedRowHandle,
                                                               colAddressMIgrationID_PartRow)),
                                                       addressGridView.GetRowCellValue(
                                                           addressGridView.FocusedRowHandle, colAddressMIgrationAddress)
                                                           .ToString(), FindedSku,
                                                       addressGridView.GetRowCellValue(
                                                           addressGridView.FocusedRowHandle, colAddressMIgrationSeries).
                                                           ToString(),
                                                       Convert.ToInt32(
                                                           addressGridView.GetRowCellValue(
                                                               addressGridView.FocusedRowHandle,
                                                               colAddressMIgrationAnalysis)),
                                                       Convert.ToDateTime(
                                                           addressGridView.GetRowCellValue(
                                                               addressGridView.FocusedRowHandle,
                                                               colAddressMIgrationExpirationDate)));
                freeAddressGridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
                freeAddressGridView.BestFitColumns();
                freeAddressGridControl.Visible = true;
            }
        }

        private void MovePartialQtyButtonClick(object sender, EventArgs e)
        {
            if (addressGridView.FocusedRowHandle < 0)
            {
                XtraMessageBox.Show("Необходимо указать какую \nпартию нужно переместить!", "Внимание!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            findSkuTextEdit.Focus();
            if (freeAddressGridView.FocusedRowHandle < 0) 
            {
                XtraMessageBox.Show("Необходимо указать, на какой адрес \nнужно переместить партию!", "Внимание!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var handlerFrom = addressGridView.FocusedRowHandle;
            var handlerTo = freeAddressGridView.FocusedRowHandle;
            var frm = new FrmMigrateAddress(
                skuDescriptionLabelControl.Text,
                addressGridView.GetRowCellValue(handlerFrom, colAddressMIgrationSeries).ToString(),
                Convert.ToInt32(addressGridView.GetRowCellValue(handlerFrom, colAddressMIgrationAnalysis)),
                Convert.ToDateTime(addressGridView.GetRowCellValue(handlerFrom, colAddressMIgrationExpirationDate)),
                Convert.ToInt32(addressGridView.GetRowCellValue(handlerFrom, colAddressMIgrationID_PartRow)),
                Convert.ToDecimal(addressGridView.GetRowCellValue(handlerFrom, colAddressMIgrationQtyAddress)),
                addressGridView.GetRowCellValue(handlerFrom, colAddressMIgrationAddress).ToString(),
                freeAddressGridView.GetRowCellValue(handlerTo, colFreeAddressStringAddress).ToString(),
                Convert.ToInt32(addressGridView.GetRowCellValue(handlerFrom, colAddressMigrationIDAddress)),
                Convert.ToInt32(freeAddressGridView.GetRowCellValue(handlerTo, colFreeAddresslID)),
                Convert.ToInt32(addressGridView.GetRowCellValue(handlerFrom, colAddressMIgrationIdPartOfProduct)),
                Convert.ToBoolean(freeAddressGridView.GetRowCellValue(handlerTo, colFreeAddressFromThisPart)));
            frm.ShowDialog();

            findSkuTextEdit.Text = FindedSku.ToString();
            findSkuTextEdit.SendKey(new KeyEventArgs(Keys.Enter));

        }

        private void MoveAllQtyButtonClick(object sender, EventArgs e)
        {
            if (addressGridView.FocusedRowHandle < 0)
            {
                XtraMessageBox.Show("Необходимо указать какую \nпартию нужно переместить!", "Внимание!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            findSkuTextEdit.Focus();
            if (freeAddressGridView.FocusedRowHandle < 0)
            {
                XtraMessageBox.Show("Необходимо указать, на какой адрес \nнужно переместить партию!", "Внимание!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            findSkuTextEdit.Focus();
            var handlerFrom = addressGridView.FocusedRowHandle;
            var handlerTo = freeAddressGridView.FocusedRowHandle;
            if (XtraMessageBox.Show(
                        string.Format("Будет перемещено всё количество товара {0} шт. \nс адреса {1} \nна адрес {2} \nВы желаете продолжить?", 
                        Math.Round(Convert.ToDecimal(addressGridView.GetRowCellValue(handlerFrom, colAddressMIgrationQtyAddress)),2), 
                        addressGridView.GetRowCellValue(handlerFrom, colAddressMIgrationAddress), 
                        freeAddressGridView.GetRowCellValue(handlerTo, colFreeAddressStringAddress)), 
                    "Внимание!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                var worker = new DataBaseLayers.AddressMigration();
                worker.MigrateQtyToAnotherAddress(
                    Convert.ToInt32(addressGridView.GetRowCellValue(handlerFrom, colAddressMIgrationIdPartOfProduct)),
                    Convert.ToInt32(addressGridView.GetRowCellValue(handlerFrom, colAddressMigrationIDAddress)),
                    Convert.ToInt32(freeAddressGridView.GetRowCellValue(handlerTo, colFreeAddresslID)),
                    Convert.ToDecimal(addressGridView.GetRowCellValue(handlerFrom, colAddressMIgrationQtyAddress)),
                    Convert.ToDecimal(addressGridView.GetRowCellValue(handlerFrom, colAddressMIgrationQtyAddress)),
                    Convert.ToBoolean(freeAddressGridView.GetRowCellValue(handlerTo, colFreeAddressFromThisPart)));
                findSkuTextEdit.Text = FindedSku.ToString();
                findSkuTextEdit.SendKey(new KeyEventArgs(Keys.Enter));
            }
            findSkuTextEdit.Focus();

        }

        private void CleanAddressButtonClick(object sender, EventArgs e)
        {
            if (addressGridView.FocusedRowHandle >= 0)
            {
                if (XtraMessageBox.Show(string.Format("Вы действительно хотите очистить адрес - {0}", addressGridView.GetRowCellValue(addressGridView.FocusedRowHandle, colAddressMIgrationAddress)), "Внимание !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var worker = new DataBaseLayers.AddressMigration();
                    worker.CleanAddress(
                        Convert.ToInt32(addressGridView.GetRowCellValue(addressGridView.FocusedRowHandle,
                                                                        colAddressMigrationIDAddress)),
                        Convert.ToInt32(addressGridView.GetRowCellValue(addressGridView.FocusedRowHandle,
                                                                        colAddressMIgrationID_PartRow)),
                        Convert.ToDateTime(addressGridView.GetRowCellValue(addressGridView.FocusedRowHandle,
                                                                           colAddressMIgrationExpirationDate)));
                }
                findSkuTextEdit.Focus();
            }
        }
    }
}