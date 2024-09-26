﻿namespace domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        //Many-to-Many
        public List<Product>? Products { get; set; }
    }
}