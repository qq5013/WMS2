using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WMS.AddressAsignment;
using WMS.AddressMigration;
using WMS.Administration;
using WMS.DataBaseLayers;
using WMS.Globals;
using WMS.MenuBuilder;
using WMS.Assembly;
using WMS.CreateAddress;
using WMS.AddressReplenishment;
using WMS.CalcRotation;
using WMS.PrintLabels;
using WMS.CheckAddress;

namespace WMS.MainApplication
{
    public partial class MobFrmMain : DevExpress.XtraEditors.XtraForm
    {
        public MobFrmMain()
        {
            InitializeComponent();
        }

        private void ModesButtonClick(object sender, EventArgs e)
        {
            MainTabControl.SelectedTabPage = modesXtraTabPage;
        }

        private void DirectoryesButtonClick(object sender, EventArgs e)
        {
            MainTabControl.SelectedTabPage = directoryesTabPage;
        }

        private void DocsButtonClick(object sender, EventArgs e)
        {
            MainTabControl.SelectedTabPage = docsTabPage;
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            MainTabControl.SelectedTabPage = mainXtraTabPage;
        }

        private void DirBackButtonClick(object sender, EventArgs e)
        {
            MainTabControl.SelectedTabPage = mainXtraTabPage;
        }

        private void DocsBackButtonClick(object sender, EventArgs e)
        {
            MainTabControl.SelectedTabPage = mainXtraTabPage;
        }

        private void AddressAssignmentButtonClick(object sender, EventArgs e)
        {
            Close();

        }
    }
}