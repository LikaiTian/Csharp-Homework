using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    [Serializable]
    public class OrderDetails
    {
        //商品明细
        public string GoodsName { get; set; }
        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("the price must be >= 0!");
                price = value;
            }
        }
        public int Amount { get; set; }
        //构造函数
        public OrderDetails() { }
        public OrderDetails(string goodsName,double price,int amount)
        {
            GoodsName = goodsName;
            Price = price;
            Amount = amount;
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
                   GoodsName == details.GoodsName &&
                   Price == details.Price &&
                   Amount == details.Amount;
        }

        public override int GetHashCode()
        {
            int hashCode = 699930381;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodsName);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            hashCode = hashCode * -1521134295 + Amount.GetHashCode();
            return hashCode;
        }
        public override string ToString()
        {
            return "GoodsName:" + GoodsName + "\tPrice:" + Price + "\tAmount:" + Amount;
        }
    }
}
