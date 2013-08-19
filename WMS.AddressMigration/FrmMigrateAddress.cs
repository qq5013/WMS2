using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WMS.AddressMigration
{
    public partial class FrmMigrateAddress : DevExpress.XtraEditors.XtraForm
    {
        public string DescriptionSku { get; set; }
        public string SeriaSku { get; set; }
        public int AnalisysSku { get; set; }
        public string ExpirationDateSku { get; set; }
        public int PartSku { get; set; }
        public decimal AllowQtyForMigrate { get; set; }
        public decimal QtyForMigrate { get; set; }
        public string AddressFrom { get; set; }
        public string AddressTo { get; set; }

        public int IdAddressFrom { get; set; }
        public int IdAddressTo { get; set; }
        public int IdPartOfProduct { get; set; }
        public bool FromThisPart { get; set; }


        public FrmMigrateAddress(
                string descriptionSku, string seriaSku, int analisysSku, 
                DateTime expirationDateSku, int partSku, decimal allowQtyForMigrate, 
                string addressFrom, string addressTo, int idAddressFrom, int idAddressTo, int idPartOfProduct, bool fromThisPart)
        {
            InitializeComponent();
            DescriptionSku = descriptionSku;
            SeriaSku = seriaSku;
            AnalisysSku = analisysSku;
            ExpirationDateSku = expirationDateSku.ToString("dd.MM.yyyy");
            PartSku = partSku;
            AllowQtyForMigrate = Math.Round(allowQtyForMigrate, 2);
            AddressFrom = addressFrom;
            AddressTo = addressTo;
            IdAddressFrom = idAddressFrom;
            IdAddressTo = idAddressTo;
            IdPartOfProduct = idPartOfProduct;
            FromThisPart = fromThisPart;

            decriptionLabel.Text = DescriptionSku;
            seriaLabel.Text = SeriaSku;
            analisysLabel.Text = AnalisysSku.ToString();
            expirationDateLabel.Text = ExpirationDateSku;
            partLabel.Text = PartSku.ToString();
            allowQtyTextEdit.Text = AllowQtyForMigrate.ToString();
            migrateQtySpinEdit.Value = Math.Round(QtyForMigrate, 2);
            addressFromLabel.Text = AddressFrom;
            addressToLabel.Text = AddressTo;
        }

        private void MigrateQtySpinEditEditValueChanged(object sender, EventArgs e)
        {
            allowQtyTextEdit.Value = AllowQtyForMigrate - migrateQtySpinEdit.Value;
        }

        private void FrmMigrateAddressLoad(object sender, EventArgs e)
        {
            migrateQtySpinEdit.Properties.MinValue = 0;
            migrateQtySpinEdit.Properties.MaxValue = AllowQtyForMigrate;
        }

        private void MoveQtyButtonClick(object sender, EventArgs e)
        {
            migrateQtySpinEdit.Value = AllowQtyForMigrate;
        }

        private void MigrateQtySpinEditEditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            allowQtyTextEdit.Value = AllowQtyForMigrate - migrateQtySpinEdit.Value;
        }

        private void MigarteButtonClick(object sender, EventArgs e)
        {
            if (migrateQtySpinEdit.Value > 0)
            {
                var worker = new DataBaseLayers.AddressMigration();
                worker.MigrateQtyToAnotherAddress(IdPartOfProduct, IdAddressFrom, IdAddressTo, migrateQtySpinEdit.Value,
                                                  AllowQtyForMigrate, FromThisPart);
            }
            Close();
        }
    }
}