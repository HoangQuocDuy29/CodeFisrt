using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Code_First_Real.Models
{
    public class DataInli : DropCreateDatabaseIfModelChanges<QLSVDataContext>
    {
        protected override void Seed(QLSVDataContext context)
        {
            //SinhVien
            context.SinhViens.Add(new SinhVien()
            {
                Masv = 1,
                Hoten = "Hoàng Quốc Duy",
                Namsinh = 2003,
                Gioitinh = "Nam",
                Email = "quocduy@gmail.com"
            });
            context.SaveChanges();
            //Diem
            context.diems.Add(new Diem()
            {
                Masv = 1,
                TenMH = "Excel",
                DiemThi = 8
            });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}