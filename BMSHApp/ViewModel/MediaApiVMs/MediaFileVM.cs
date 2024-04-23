using BMSHMedia.ViewModel.MediaVMs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMSHApp.ViewModel.MediaApiVMs
{
    public class MediaFileVM
    {
        [Display(Name = "文件名")]
        //[Required(ErrorMessage = "Validate.{0}required")]
        public string FileName { get; set; }

        [Display(Name = "文件Full名")]
        //[Required(ErrorMessage = "Validate.{0}required")]
        public string FileFullName { get; set; }

        [Display(Name = "文件擴展名")]
        //[Required(ErrorMessage = "Validate.{0}required")]
        public string FileExtention { get; set; }

        /// <summary>
        /// 相對父路徑, 不包含根路徑
        /// </summary>
        [Display(Name = "相對父路徑")]
        //[Required(ErrorMessage = "Validate.{0}required")]
        public string FileRelativeParentPath { get; set; }

        [Display(Name = "媒體文件類別")]
        //[Required(ErrorMessage = "Validate.{0}required")]
        public MediaFileTypeEnum FileType { get; set; }

        public string MineType { get; set; }

        public string Url { get; set; }
    }
}
