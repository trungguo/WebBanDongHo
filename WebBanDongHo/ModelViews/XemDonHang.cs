﻿using System;
using System.Collections.Generic;
using WebBanDongHo.Model;

namespace WebBanDongHo.ModelViews
{
    public class XemDonHang
    {
        public Order DonHang { get; set; }
        public List<OrderDetail> ChiTietDonHang { get; set; }
    }
}
