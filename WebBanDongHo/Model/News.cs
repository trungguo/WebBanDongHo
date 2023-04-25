﻿using System;
using System.Collections.Generic;

namespace WebBanDongHo.Model
{
    public partial class News
    {
        public int PostId { get; set; }
        public string? Title { get; set; }
        public string? ShortContents { get; set; }
        public string? Contents { get; set; }
        public string? Thumb { get; set; }
        public bool Published { get; set; }
        public string? Alias { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Author { get; set; }
        public int? AcountId { get; set; }
        public string? Tags { get; set; }
        public int? CatId { get; set; }
        public bool? IsHot { get; set; }
        public bool? IsNewfeed { get; set; }
        public string? MetaKey { get; set; }
        public string? MetaDesc { get; set; }
        public int? Views { get; set; }
    }
}
