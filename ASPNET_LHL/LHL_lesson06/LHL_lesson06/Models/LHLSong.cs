using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LHL_lesson06.Models
{
    public class LHLSong
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "LHL: Hãy Nhập Tiêu đề")]
        [DisplayName("Tiêu đề")]
        public string LHLTitle { get; set; }
        [Required(ErrorMessage ="LHL: Hãy Nhập Tác Giả")]
        [DisplayName("Tác Giả")]
        public string LHLAuthor { get; set; }
        [Required(ErrorMessage ="LHL: Hãy Nhập Nghệ Sĩ")]
        [StringLength(50,MinimumLength = 2,ErrorMessage ="LHL: Tên nghệ sĩ có tối thiểu 2 kí tự và tối đa 50 kí tự ")]
        [DisplayName("nghệ sĩ")]
        public string LHLArtist { get; set; }
        [Required(ErrorMessage ="LHL: hãy nhập năm xuất bản")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage ="LHL: nhập nhà xuất bản có 2 kí tự số")]
        [Range(1900,2024,ErrorMessage ="LHL: năm xuất bản trong khoảng năm 1900-2024")]
        [DisplayName("năm xuất bản")]
        public string LHLYearRelease { get; set;}
    }
}