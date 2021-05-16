﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{

    /**
     **/
    [Serializable]
    public class OrderDetail {

    [Key]
    public int DetialId { get; set; }

    public Goods GoodsItem { get; set; }
    
    public String GoodsName { get => GoodsItem!=null? this.GoodsItem.Name:""; }

    public double UnitPrice { get => GoodsItem != null ? this.GoodsItem.Price : 0.0; }


    public uint Quantity { get; set; }

    public OrderDetail() { }

    public OrderDetail(int DetialId, Goods goods, uint quantity) {
      this.DetialId = DetialId;
      this.GoodsItem = goods;
      this.Quantity = quantity;
    }

    public double TotalPrice {
      get => GoodsItem==null?0.0: GoodsItem.Price * Quantity;
    }

    public override bool Equals(object obj) {
      var item = obj as OrderDetail;
      return item != null &&
             GoodsName == item.GoodsName;
    }

        public override int GetHashCode()
        {
            int hashCode = -1587058945;
            hashCode = hashCode * -1521134295 + DetialId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Goods>.Default.GetHashCode(GoodsItem);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodsName);
            hashCode = hashCode * -1521134295 + UnitPrice.GetHashCode();
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            hashCode = hashCode * -1521134295 + TotalPrice.GetHashCode();
            return hashCode;
        }
    }
}
