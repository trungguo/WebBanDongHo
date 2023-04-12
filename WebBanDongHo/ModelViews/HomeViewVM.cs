using System;
using System.Collections.Generic;
using WebBanDongHo.Model;

namespace WebBanDongHo.ModelViews
{
    public class HomeViewVM
    {
        public List<News> TinTucs { get; set; }
        public List<ProductHomeVM> Products { get; set; }
        public QuangCao quangcao { get; set; }
    }
}
