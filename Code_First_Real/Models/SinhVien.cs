using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Code_First_Real.Models
{
    public class SinhVien
    {
        [Key]
        public int Masv { get; set; }
        public string Hoten { get; set;}

        public int Namsinh { get; set;}
        public string Gioitinh { get; set;} 
        public string Email { get; set;}

        public virtual ICollection<Diem> Diem { get; set;} //Cũng liên kết lại với bảng Diem
    }
}