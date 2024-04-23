using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMSHApp.ViewModel.MediaApiVMs
{
    public class MediaFolderVM
    {
        public string Id { get; set; }

        public string ParentId { get; set; }

        public bool IsTop { get; set; }

        public List<MediaFileVM> Files { get; set; } = new();

        public string FolderName { get; set; }

        /// <summary>
        /// 系統FullPath
        /// </summary>
        public string SysFullPath { get; set; }

        /// <summary>
        /// 系統父路徑
        /// </summary>
        public string SysParentPath { get; set; }

        /// <summary>
        /// 取掉設置的根路徑的 相對路徑, 已編碼, 放在html List頁面裡
        /// </summary>
        public string RelativeEncodePath { get; set; }

        public List<MediaFolderVM> ChilderFolders { get; set; } = new();

    }
}
