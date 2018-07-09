using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymatou.StaticContent.DataModel
{
    /// <summary>
    /// 数据模块
    /// </summary>
    public abstract class IBlock
    {
        /// <summary>
        /// 数据模块编号
        /// </summary>
        public abstract Int32 BlcokID { get; }
        /// <summary>
        /// 数据模块名字          
        /// </summary>
        public abstract string BlockName { get; }
        /// <summary>
        /// 描述
        /// </summary>
        public virtual string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public abstract Type ViewModel { get; }
        /// <summary>
        /// 外部链接
        /// </summary>
        public virtual string ExternalLink { get; set; }
    }
}
