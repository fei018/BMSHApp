using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMSHApp.ViewModel.MediaApiVMs
{
    public class MediaSourceVM
    {
        public List<MediaFolderVM> ApiFolderList { get; private set; } = new();

        public MediaFolderVM FolderVM { get; set; }


        public void GetFolder(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                FolderVM = ApiFolderList.FirstOrDefault(x => x.IsTop);
                if (FolderVM == null)
                {

                }
                FolderVM.ChilderFolders = ApiFolderList.Where(x => x.ParentId == FolderVM.Id).ToList();

                return;
            }

            FolderVM = ApiFolderList.Where(x => x.Id == id).FirstOrDefault();

            if (FolderVM == null)
            {

            }

            FolderVM.ChilderFolders = ApiFolderList.Where(x => x.ParentId == FolderVM.Id).ToList();
        }
    }
}
