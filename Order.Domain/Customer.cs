using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order.Domain
{
    public class Customer
    {
        /// <summary>
        /// 买家地址
        /// </summary>
        public string Address
        {
            get; set;
        }

        /// <summary>
        /// 买家姓名
        /// </summary>
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// 买家电话
        /// </summary>
        public string Tel
        {
            get; set;
        }
    }
}