﻿using BangazonBE;

namespace BangazonBE.Models.cs
    
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int ProductId { get; set; }
        public string StoreName { get; set; }
    }
}
