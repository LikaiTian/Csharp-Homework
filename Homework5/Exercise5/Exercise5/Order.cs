using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Order
    {
        public string ID { get; set; }
        public Customer Customer = new Customer("DefaultName",20,"男");
        public DateTime OrderTime { get; set; }
        public double TotalAmount { get; set; }
        public string Address { get; set; }
        public List<OrderDetails> List=new List<OrderDetails>();


        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   ID == order.ID &&
                   EqualityComparer<Customer>.Default.Equals(Customer, order.Customer) &&
                   OrderTime == order.OrderTime &&
                   TotalAmount == order.TotalAmount &&
                   Address == order.Address &&
                   EqualityComparer<List<OrderDetails>>.Default.Equals(List, order.List);
        }

        public override int GetHashCode()
        {
            int hashCode = 1874009916;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
            hashCode = hashCode * -1521134295 + EqualityComparer<Customer>.Default.GetHashCode(Customer);
            hashCode = hashCode * -1521134295 + OrderTime.GetHashCode();
            hashCode = hashCode * -1521134295 + TotalAmount.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetails>>.Default.GetHashCode(List);
            return hashCode;
        }

        public override string ToString()
        {
            String s="";
            foreach(OrderDetails o in List)
            {
                s += o.ToString()+"\n";
            }
            return "ID:" + ID + "\n" +
                "Customer:" + Customer + "\n" +
                "OrderTime:" + OrderTime + "\n" +
                "TotalAmount:" + TotalAmount + "\n" +
                "Address:" + Address + "\n" + 
                s;
        }
    }
}
