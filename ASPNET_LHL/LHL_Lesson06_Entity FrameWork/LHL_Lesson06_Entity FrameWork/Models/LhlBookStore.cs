using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LHL_Lesson06_Entity_FrameWork.Models
{
    public class LhlBookStore:DbContext
    {
        public LhlBookStore():base("LhlBookStoreConnectionStrings") { }

        //khai báo các thuộc tính tương ứng với các bảng trong cơ sở dữ liệu
        public DbSet<LHLCategory> LHLCategories { get; set; }
        public DbSet<LHLBook> LHLCBooks { get; set;}
    }
}