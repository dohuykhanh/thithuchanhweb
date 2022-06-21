using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dohuykhanh.Models
{
    public class Giohang
    {
        Model1 data = new Model1();

        [Display(Name = "Ma lich")]
        public String malich { get; set; }
        [Display(Name = "Ma phim")]
        public int maphim { get; set; }
        
        [Display(Name = "Giá bán")]
        public Double gia { get; set; }
        [Display(Name = "Số lượng")]
        public int iSoluong { get; set; }
        [Display(Name = "Thành tiền")]
        public Double dThanhtien
        {
            get { return iSoluong * gia; }
        }
        public Giohang(int maphim)
        {
            this.maphim = maphim;
            LichChieu rubik = data.LichChieux.Single(n => n.maphim == maphim);
            malich = rubik.malich;
            
            gia = double.Parse(rubik.gia.ToString());
            iSoluong = 1;

        }
    }
}