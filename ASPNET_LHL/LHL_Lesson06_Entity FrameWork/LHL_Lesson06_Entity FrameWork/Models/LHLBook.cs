using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LHL_Lesson06_Entity_FrameWork.Models
{
    public class LHLBook
    {
        [Key]
        public int LhlId { get; set; }
        public string LhlBookId { get; set; }
        public string LhlTitle { get; set; }
        public string LhlAuthor { get; set; }
        public int LhlYear { get; set; }
        public string LhlPulisher { get; set; }
        public string LhlPicture { get; set; }
        public int LhlCategoryId { get; set; }
        //thuộc tính quan hệ 
        public virtual LHLCategory LHLCategory { get; set; }
    }
}