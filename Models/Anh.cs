using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HueCIT.Modules.NhaNhac_CMS.Interface
{
    public class Anh
    {
       public int FileID { get; set; }
        public int TypeID { get; set; }
        public int FolderID { get; set; }
        public string Description { get; set; }
        public DateTime DateCreate { get; set; } = DateTime.Now;
        [Required]
        public string Title { get; set; }
        [Required]
        public string Path { get; set; }
    }
}