using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.Globals;
using WMS.DataBaseLayers;

namespace WMS.AddressAsignment
{
    public partial class FrmEnterQtyForPartOnAddress : DevExpress.XtraEditors.XtraForm
    {
        public string Description { get; set; }
        public string Seria { get; set; }
        public string ExpDate { get; set; }
        public int AllowQty { get; set; }
        public int IdPartRow { get; set; }
        public string Address { get; set; }
        public bool CheckEqual { get; set; }
        public decimal OnixQty { get; set; }


        public FrmEnterQtyForPartOnAddress(string description, string seria, string expDate, int allowQty, int idPartRow, string address, bool checkEqual, decimal onixQty)
        {
            InitializeComponent();
            Description = description;
            Seria = seria;
            ExpDate = Convert.ToDateTime(expDate).ToString("dd.MM.yyyy");
            AllowQty = allowQty;
            IdPartRow = idPartRow;
            Address = address;
            CheckEqual = checkEqual;
            OnixQty = onixQty;
        }

        private void CheckForMaxValue()
        {
            return;
            if (!CheckEqual) return;
            if (numTextEdit.Text == "") return;
            var equal = Convert.ToInt64(numTextEdit.Text);
            if (equal <= AllowQty) return;
            numTextEdit.Text = AllowQty.ToString();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            numTextEdit.Text = numTextEdit.Text + "1";
            CheckForMaxValue();
        }

        private void Button2Click(object sender, EventArgs e)
        {
            numTextEdit.Text = numTextEdit.Text + "2";
            CheckForMaxValue();
        }

        private void Button3Click(object sender, EventArgs e)
        {
            numTextEdit.Text = numTextEdit.Text + "3";
            CheckForMaxValue();
        }

        private void Button4Click(object sender, EventArgs e)
        {
            numTextEdit.Text = numTextEdit.Text + "4";
            CheckForMaxValue();
        }

        private void Button5Click(object sender, EventArgs e)
        {
            numTextEdit.Text = numTextEdit.Text + "5";
            CheckForMaxValue();
        }

        private void Button6Click(object sender, EventArgs e)
        {
            numTextEdit.Text = numTextEdit.Text + "6";
            CheckForMaxValue();
        }

        private void Button7Click(object sender, EventArgs e)
        {
            numTextEdit.Text = numTextEdit.Text + "7";
            CheckForMaxValue();
        }

        private void Button8Click(object sender, EventArgs e)
        {
            numTextEdit.Text = numTextEdit.Text + "8";
            CheckForMaxValue();
        }

        private void Button9Click(object sender, EventArgs e)
        {
            numTextEdit.Text = numTextEdit.Text + "9";
            CheckForMaxValue();
        }

        private void Button0Click(object sender, EventArgs e)
        {
            if (numTextEdit.Text != "")
            {
                numTextEdit.Text = numTextEdit.Text + "0";
                CheckForMaxValue();
            }
        }

        private void Button00Click(object sender, EventArgs e)
        {
            if (numTextEdit.Text != "")
            {
                numTextEdit.Text = numTextEdit.Text + "00";
                CheckForMaxValue();
            }
        }

        private void ButtonCClick(object sender, EventArgs e)
        {
            numTextEdit.Text = "";
        }

        private void ButtonBackClick(object sender, EventArgs e)
        {
            if (numTextEdit.Text != "")
            {
                numTextEdit.Text = numTextEdit.Text.Substring(0, numTextEdit.Text.Length - 1);
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void AcceptButtonClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Address) && IdPartRow != 0)
            {
                if (Convert.ToInt32(!string.IsNullOrEmpty(numTextEdit.Text)) > 0)
                {
                    var worker = new CheckAddress();
                    worker.CheckQtyAddress(Address, IdPartRow);
                    worker.UpdateQtyOnCheckedAddress(Address, IdPartRow, Convert.ToDecimal(numTextEdit.Text), OnixQty);    
                }
                else
                {
                    XtraMessageBox.Show("Необходимо указать реальное количество товара", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
            }
            Close();
        }

        private void FrmEnterQtyForPartOnAddressLoad(object sender, EventArgs e)
        {
            descriptionLabelControl.Text = Description;
            seriaLabelControl.Text = Seria;
            expDateLabelControl.Text = ExpDate;
            allowQtyLabelControl.Text = AllowQty.ToString();
            idPartRowLabelControl.Text = IdPartRow.ToString();
            addressLabelControl.Text = Address;
        }
    }
}