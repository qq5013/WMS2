using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace WMS.MainApplication
{
    public partial class Glavnaia : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Glavnaia()
        {
            InitializeComponent();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            DirMainFrm frm = new DirMainFrm();
            frm.Show(Owner);
        }
    }
}