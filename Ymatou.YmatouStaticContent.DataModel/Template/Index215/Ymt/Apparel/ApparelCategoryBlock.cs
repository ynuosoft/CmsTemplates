using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Apparel
{
    /// <summary>
    /// 服饰鞋包分类板块
    /// </summary>
    public class ApparelCategoryBlock : IBlock
    {
        /// <summary>
        /// 
        /// </summary>
        public override int BlcokID
        {
            get { return YmtBlocksEnums.ApparelCategoryBlock; }
        }

        /// <summary>
        /// 
        /// </summary>
        public override string BlockName
        {
            get { return "服饰鞋包分类板块"; }
        }

        /// <summary>
        /// 服饰鞋包分类板块组件
        /// </summary>
        public override Type ViewModel
        {
            get { return typeof(ApparelCategoryBlockItemViewModel); }
        }
    }

    public class ApparelCategoryBlockItem : IBlockItem<ApparelCategoryBlockItemViewModel>
    {

    }

    public class ApparelCategoryBlockItemViewModel : IBlockItemViewModel
    {
        /// <summary>
        /// 分类标题
        /// </summary>
        [DisplayName(CNName = "分类标题", MaxLength = 25)]
        public string Title { get; set; }

        /// <summary>
        /// 链接地址
        /// </summary>
        [DisplayName(CNName = "链接地址", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl { get; set; }
    }
}
