using aula132_ExercicioProposto.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula132_ExercicioProposto.Entities
{
    class Order
    {
        //Variables
        public Status OrderStatus { get; set; }

        public List<OrderItem> Items { get; set;} = new List<OrderItem>();

        //Constructors
        public Order()
        {
        }
        public Order(Status orderStatus)
        {
            OrderStatus = orderStatus;
        }
        
        //Operations
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double totalVelue = 0;
            foreach (OrderItem order in Items)
            {
                totalVelue += order.SubTotal();
            }
            return totalVelue;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + DateTime.Now);
            sb.AppendLine("Order status: " + Status.PendingPayment);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}

