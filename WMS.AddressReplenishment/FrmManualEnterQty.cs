using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WMS.AddressReplenishment
{
    public partial class FrmManualEnterQty : XtraForm
    {
        public string Description { get; set; }
        public string Seria { get; set; }
        public string ExpDate { get; set; }
        public string Rotation { get; set; }
        public string RestByPart { get; set; }
        public string RestAllDep { get; set; }

        public FrmManualEnterQty(string description, string seria, string expDate, string rotation, string restByPart, string restAllDep)
        {
            InitializeComponent();
            Description = description;
            Seria = seria;
            ExpDate = expDate;
            Rotation = rotation;
            RestByPart = restByPart;
            RestAllDep = restAllDep;
        }

        private void Button1Click(object sender, EventArgs e)
        {
            numTextEdit.Text = numTextEdit.Text + "1";
        }

        private void Button2Click(object sender, EventArgs e)
        {
            numTextEdit.Text = numTextEdit.Text + "2";
        }

        private void Button3Click(object sender, EventArgs e)
        {
            numTextEdit.Text = numTextEdit.Text + "3";
        }

        private void Button4Click(object sender, EventArgs e)
        {
            numTextEdit.Text = numTextEdit.Text + "4";
        }

        private void Button5Click(object sender, EventArgs e)
        {
            numTextEdit.Text = numTextEdit.Text + "5";
        }

        private void Button6Click(object sender, EventArgs e)
        {
            numTextEdit.Text = numTextEdit.Text + "6";
        }

        private void Button7Click(object sender, EventArgs e)
        {
            numTextEdit.Text = numTextEdit.Text + "7";
        }

        private void Button8Click(object sender, EventArgs e)
        {
            numTextEdit.Text = numTextEdit.Text + "8";
        }

        private void Button9Click(object sender, EventArgs e)
        {
            numTextEdit.Text = numTextEdit.Text + "9";
        }

        private void Button0Click(object sender, EventArgs e)
        {
            if (numTextEdit.Text != "")
            {
                numTextEdit.Text = numTextEdit.Text + "0";
            }
        }

        private void Button00Click(object sender, EventArgs e)
        {
            if (numTextEdit.Text != "")
            {
                numTextEdit.Text = numTextEdit.Text + "00";
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

        private void FrmManualEnterQtyLoad(object sender, EventArgs e)
        {
            descriptionLabelControl.Text = Description;
            seriaLabelControl.Text = Seria;
            expDateLabelControl.Text = ExpDate;
            rotationLabelControl.Text = Rotation;
            restByPartLabelControl.Text = RestByPart;
            restAllDepLabelControl.Text = RestAllDep;
        }

        private void AcceptButtonClick(object sender, EventArgs e)
        {
            if (numTextEdit.Text != "" && numTextEdit.Text != "0")
            {
                FrmManualAddressReplenishment.QtyForReplenishment = Convert.ToDecimal(numTextEdit.Text);
                Close();
            }
        }
    }
}