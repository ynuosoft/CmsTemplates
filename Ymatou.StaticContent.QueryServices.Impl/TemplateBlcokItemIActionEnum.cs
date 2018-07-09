using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.QueryServices.Impl
{
    /// <summary>
    /// Cms信息状态
    /// </summary>
    public class TemplateBlcokItemIActionEnum
    {
        private TemplateBlcokItemIActionEnum()
        {

        }
        public static Dictionary<int, string> Items;

        static TemplateBlcokItemIActionEnum()
        {
            Items = new Dictionary<int, string>();

            Items.Add(NewAdded, "新添加");
            Items.Add(PreView, "预览");
            Items.Add(Apply, "发布");
            Items.Add(Forbidden, "禁用");
        }
       
        /// <summary>
        /// 新创建
        /// </summary>
        public const int NewAdded = 0;
        /// <summary>
        ///预览
        /// </summary>
        public const int PreView = 2;
        /// <summary>
        ///发布
        /// </summary>
        public const int Apply = 1;
        /// <summary>
        /// 禁用
        /// </summary>
        public const int Forbidden = 99;  


    }
}
