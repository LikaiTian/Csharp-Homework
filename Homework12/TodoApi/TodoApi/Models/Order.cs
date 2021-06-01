using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class Order
    {
        [Key]
        public long Id { get; set; }
        public string CustomerName { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        [NotMapped]
        public int OrderPrice
        {
            get
            {
                int sum = 0;
                if (OrderDetails != null)
                    OrderDetails.ForEach(o => sum += o.SumPrice);
                return sum;
            }
        }
    }
}
