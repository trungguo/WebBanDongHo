using System;
using System.Collections.Generic;
using WebBanDongHo.Model;

namespace WebBanDongHo.ModelViews
{
    public class ProductHomeVM
    {
        public Category category { get; set; }
        public List<Product> lsProducts { get; set; }
    }
}
