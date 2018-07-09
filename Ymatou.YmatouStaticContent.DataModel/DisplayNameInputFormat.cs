using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel
{
    /// <summary>
    /// 前端数据输入类型
    /// </summary>
    public enum DisplayNameInputFormat : int
    {
        /// <summary>
        /// 值类型
        /// </summary>
        Int = 1,
        /// <summary>
        /// 日期格式
        /// </summary>
        DateTime = 2,
        /// <summary>
        /// 文件类型
        /// </summary>
        File = 3,
        /// <summary>
        /// 图片类型
        /// </summary>
        Image = 4,
        /// <summary>
        /// 数值类型
        /// </summary>
        Decimal = 5,
        /// <summary>
        /// 字符串类型
        /// </summary>
        String = 6,
        /// <summary>
        /// 富文本类型
        /// </summary>
        Html = 7,
        /// <summary>
        /// http链接类型
        /// </summary>
        Link = 8,
        /// <summary>
        /// 年
        /// </summary>
        Year = 10,
        /// <summary>
        /// 月份
        /// </summary>
        Month = 11,
        /// <summary>
        /// 周
        /// </summary>
        Week = 12,
        /// <summary>
        ///颜色 
        /// </summary>
        Color=20,
        /// <summary>
        /// 下拉菜单
        /// </summary>
        Select=30,
    }
}
