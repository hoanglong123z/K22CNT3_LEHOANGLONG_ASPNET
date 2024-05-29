using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LHL_Lab05.Models
{
    public class LHLMember
    {
        // cách 1 và cách 2 ta sử dụng khai báo thuộc tính như sau
        //public int? Id { get; set; }
        //public string UserName { get; set; }
        //public string FullName { get; set; }
        //public string PassWord { get; set; }
        //public int? Age { get; set; }
        //public string Email { get; set; }

        // cách 3 
        [Required(ErrorMessage = "Hãy Nhập Số")]
        [DataType(DataType.Currency)]
        public int? ID { get; set; }
        [Required(ErrorMessage = "Hãy Nhập Tên Đăng Nhập")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Họ Và Tên")]
        public string FullName { get; set; }
        [Required(ErrorMessage ="Hãy Nhập Mật Khẩu")]
        [DataType(DataType.Currency)]
        public string PassWord { get; set; }
        [Required(ErrorMessage ="Hãy Nhập Tuổi")]
        [Range(18, 50, ErrorMessage = "Tuổi từ 18 -> 50")]
        public int? Age { get; set; }
        [Required(ErrorMessage ="Hãy Nhập Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-0.-]+\[A-Za-z]{2,4}",
            ErrorMessage ="Email phải đúng định dạng")]
        public string Email { get; set; }

    }
}