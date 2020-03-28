using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order.Domain
{
    public class OrderItem
    {
        /// <summary>
        /// 带参构造函数
        /// </summary>
        public OrderItem(Orders order, Product product, int count)
        {
            this.Orders = order;
            this.Product = product;
            this.Count = count;
        }

        /// <summary>
        /// 订单项所属订单信息
        /// </summary>
        private Orders _order;

        /// <summary>
        /// 订单项所属订单
        /// </summary>
        public Orders Orders
        {
            get
            {
                return _order;
            }
            set
            {
                _order = value;
                _order.OrderItems.Add(this);
            }
        }

        /// <summary>
        /// 订单项包含的商品信息
        /// </summary>
        public Product Product
        {
            get;
        }

        /// <summary>
        /// 商品数量
        /// </summary>
        public int Count
        {
            get;
        }

        /// <summary>
        /// 计算订单项金额
        /// </summary>
        public double SubTotal()
        {
            var subtotal = 0.0;
            subtotal = Count * Product.Price;
            return subtotal;
        }
    }
}