using aula132_ExercicioProposto.Entities.Enums;
using System;

namespace aula132_ExercicioProposto.Entities
{
    class OrderItem
    {
        //Variables
        public Products Name {  get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        //Constructors
        public OrderItem()
        {
        }
        public OrderItem(Products name, int quantity, double price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        //Operations
        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
