﻿namespace FurniNest_Backend.DTOs.CartDTOs
{
    public class CartItemViewDTO
    {
        public string? Name { get; set; }

        public string? Brand { get; set; }

        public int Rating { get; set; }

        public string? Category { get; set; }

        public string? Image { get; set; }

        public int Quantity { get; set; }
        public Decimal Price { get; set; }

        public int TotalPrice { get; set; }




    }
}
