using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Grocery
{
    /// <summary>
    /// 食品保健分类
    /// </summary>
    public class GroceryCategoryBlock : IBlock
    {

        public override int BlcokID
        {
            get { return YmtBlocksEnums.GroceryCategoryBlock; }
        }

        public override string BlockName
        {
            get { return "食品保健分类"; }
        }

        public override Type ViewModel
        {
            get { return typeof(GroceryCategoryBlockItemViewModel); }
        }
    }

    public class GroceryCategoryBlockItem : IBlockItem<GroceryCategoryBlockItemViewModel>
    {
    }

    public class GroceryCategoryBlockItemViewModel : IBlockItemViewModel
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
