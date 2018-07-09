using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymatou.StaticContent.DataModel
{
    /// <summary>
    /// 数据模块，具体的项
    /// </summary>
    public  class IBlockItem<T> where T : IBlockItemViewModel
    {
        /// <summary>
        /// 模板编号
        /// </summary>
        public Int32 TemplateID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Int32 BlockID { get; set; }
        /// <summary>
        /// 数据项编号
        /// </summary>
        public Int32 BlockItemID { get; set; }
        /// <summary>
        /// 内容 json格式
        /// </summary>
        public String Content { get; set; }
        /// <summary>
        /// 内容备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime AddTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Action { get; set; }
        /// <summary>
        /// 显示的模型
        /// 一个数据项 一个模型
        /// </summary>
        public  T ViewModel { get; set; }
    }
}
