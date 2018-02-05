﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由EntityGen生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Savory.Repository.ConfigDB.Entity
{
    /// <summary>
    /// 应用表
    /// </summary>
    [Table("App")]
    public partial class AppEntity
    {

        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// AppID
        /// </summary>
        public int AppId { get; set; }

        /// <summary>
        /// 应用名
        /// </summary>
        [Required]
        [StringLength(500)]
        public string Name { get; set; }

        /// <summary>
        /// 1: deleted, 0: normal
        /// </summary>
        public int DataStatus { get; set; }

        /// <summary>
        /// 创建人邮箱前缀
        /// </summary>
        [Required]
        [StringLength(32)]
        public string CreateBy { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 最后修改人邮箱前缀
        /// </summary>
        [Required]
        [StringLength(32)]
        public string LastUpdateBy { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime LastUpdateTime { get; set; }
    }
}