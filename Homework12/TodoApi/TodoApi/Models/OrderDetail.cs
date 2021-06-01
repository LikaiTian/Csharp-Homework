using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class OrderDetail
    {
        [Key]
        public int GoodId { get; set; }
        public string GoodsName { get; set; }
        public int UnitPrice { get; set; }
        public int Amount { get; set; }
        public Order order { get; set; }
        [ForeignKey("order")]
        public long Id { get; set; }
        [NotMapped]
        public int SumPrice { get => UnitPrice * Amount; }
    }
}
