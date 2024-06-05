using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;

namespace LHL_Lesson06_Entity_FrameWork.Models
{
    public class LHLCategory
    {
        [Key]
        public int LhlId { get; set; }
        public string LhlCategoryName { get; set; }
        //thuộc tính quan hệ
        public virtual ICollection<LHLBook> LHLBooks { get; set; }
    }
}