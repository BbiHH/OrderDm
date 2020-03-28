using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order.Domain
{
    public class Product
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// 商品价格
        /// </summary>
        public double Price
        {
            get; set;
        }
    }
}