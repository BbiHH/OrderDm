using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order.Domain
{
    public class Orders
    {
        /// <summary>
        /// 定义带参构造函数
        /// </summary>
        /// <param name="customer"></param>
        public Orders(Customer customer)
        {
            this.Customer = customer;
            this.Date = DateTime.Now;
            this.OrderItems = new List<OrderItem>();
            this.ID = CreateID();
        }

        /// <summary>
        /// 买家信息
        /// </summary>
        public Customer Customer
        {
            get;
        }

        /// <summary>
        /// 订单编号
        /// </summary>
        public string ID
        {
            get; set;
        }

        /// <summary>
        /// 下单日期
        /// </summary>
        public DateTime Date
        {
            get;
        }

        /// <summary>
        /// 所有订单项的集合
        /// </summary>
        public ICollection<OrderItem> OrderItems
        {
            get;
            set;
        }

        /// <summary>
        /// 计算订单金额
        /// </summary>
        public double Total()
        {
            var total = 0.0;
            foreach (var item in OrderItems)
            {
                total += item.SubTotal();
            }
            return total;
        }

        /// <summary>
        /// 生成固定长订单编号
        /// </summary>
        public string CreateID()
        {
            string id = string.Empty;
            id = new Random().Next(10000).ToString().PadLeft(5, '0');
            return id;
        }
    }
}