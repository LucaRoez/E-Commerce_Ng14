﻿namespace ECommerceApi.Models
{
    public class Image : ModelBase
    {
        public long? Id { get; set; }
        public string Src { get; set; }
        public string Alt { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
