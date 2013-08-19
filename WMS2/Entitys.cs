using System.Collections.Generic;
using DevExpress.XtraTab;

namespace WMS.MainApplication
{
    public enum TypeOfDir
    {
        Warehouse,
        Street,
        Raft,
        Shelf,
        ShelfSpace
    }

    public enum DirLinks
    {
        ResponsibleForZone,
        Zones,
        Warehouse,
        Street,
        Raft,
        Shelf,
        ShelfSpace,
        Rotation,
        Unit,
        Products,
        Rests,
        Multiplicity,
        GroupProducts
    }
    
    public class MyXtraTabControl : XtraTabControl
    {
        public List<MyXtraTabPage> MyPages = new List<MyXtraTabPage>(); 
        
        public int GetIndexForExistsTab(MyXtraTabControl tabControl, MyXtraTabPage page)
        {
            var result = 0;

            if (tabControl.MyPages != null)
                foreach (var tabPage in tabControl.MyPages)
                {
                    if (tabPage.TypeOfDir != page.TypeOfDir) continue;
                    result = 1;
                }

            return result;
        }

        public int GetIdByDirLinks(MyXtraTabControl tabControl, DirLinks links)
        {
            var index = -1;

            foreach (var page in tabControl.MyPages)
            {
                if (page.TypeOfDir != links) continue;
                index = tabControl.TabPages.IndexOf(page);
            }
            return index < 0 ? -1 : index;
        }
    }
    public class MyXtraTabPage : XtraTabPage
    {
        public DirLinks TypeOfDir { get; set; }
    }
}
