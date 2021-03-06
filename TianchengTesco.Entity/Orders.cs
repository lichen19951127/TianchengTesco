﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TianchengTesco.Entity
{
    /// <summary>
    /// 订单表
    /// </summary>
   public class Orders
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 商品ID
        /// </summary>
        public int GId { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Nums { get; set; }
        /// <summary>
        /// 购买时间
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// 购买人
        /// </summary>
        public int UId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        [NotMapped]
        public string GName { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        [NotMapped]
        public decimal Price { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        [NotMapped]
        public string Img { get; set; }
        /// <summary>
        /// 店铺
        /// </summary>
        [NotMapped]
        public int SId { get; set; }
        /// <summary>
        /// 购买人
        /// </summary>
        [NotMapped]
        public string UName { get; set; }
        /// <summary>
        /// 购买人手机号
        /// </summary>
        [NotMapped]
        public string Phone { get; set; }
        /// <summary>
        /// 购买人地址
        /// </summary>
        [NotMapped]
        public string Address { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        [NotMapped]
        public string SName { get; set; }
    }
}
