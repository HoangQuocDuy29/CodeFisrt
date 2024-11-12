using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace Code_First_Real.Models
{
    public class Diem
    {
        [Key,Column(Order =0)]
        public int Masv { get; set; }
        [Key,Column(Order =1)]
        public string TenMH { get; set; }
        public float DiemThi { get; set; }

        public virtual SinhVien SinhVien { get; set; } //Liên kết tới bảng SinhVien

    }
}