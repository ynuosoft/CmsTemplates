using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ymatou.StaticContent.DataModel
{
    /// <summary>
    /// 模板基类
    /// </summary>
    public abstract class ITemplate
    {
        #region //公共字段
        /// <summary>
        /// 模板编号
        /// </summary>
        public abstract TemplateEnum TemplateID { get; }
        /// <summary>
        /// 模板名称
        /// </summary>
        public abstract string TemplateName { get; }
        /// <summary>
        /// 模板描述
        /// </summary>
        public string Descption { get; set; }
        /// <summary>
        /// 预览地址
        /// </summary>
        public abstract string ViewUrl { get; }
        /// <summary>
        /// 对应可视化编辑地址
        /// </summary>
        public virtual string EditViewUrl { get; set; }

        #endregion
        public abstract IDictionary<int, IBlock> ListTemplateBlock { get; }
        /// <summary>
        /// 添加模块
        /// </summary>
        public abstract void AddTemplateBlock();

    }
}
