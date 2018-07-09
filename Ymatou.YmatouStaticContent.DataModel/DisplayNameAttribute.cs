using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymatou.StaticContent.DataModel
{
    /// <summary>
    /// 显示中文名称
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DisplayNameAttribute : Attribute
    {
        /// <summary>
        /// 中文显示名
        /// </summary>
        public String CNName { get; set; } 
        /// <summary>
        /// 信息提示
        /// </summary>
        public string Tips { get; set; }
        /// <summary>
        /// 是否必须，不能为空
        /// </summary>
        public Boolean Must { get; set; }
        /// <summary>
        /// 分组
        /// </summary>
        public string Group { get; set; }
        /// <summary>
        /// 默认输入框的数据
        /// </summary>
        public string DefaultInputValue { get; set; }
        /// <summary>
        /// 数据格式，前端要求验证的
        /// </summary>
        private DisplayNameInputFormat inputFormat = DisplayNameInputFormat.String;
        /// <summary>
        /// 
        /// </summary>
        public DisplayNameInputFormat InputFormat
        {
            get { return inputFormat; }
            set { inputFormat = value; }
        }
        /// <summary>
        /// 数据最大长度KB
        /// </summary>
        private int maxLength = 512;
        /// <summary>
        /// 数据最大长度
        /// </summary>
        public int MaxLength
        {
            get { return maxLength; }
            set { maxLength = value; }
        }

        /// <summary>
        /// 下拉菜单使用数据源
        /// </summary>
        public Dictionary<string, string> KeyValues
        { 
            get;
            set;
        }
    }
  

}
