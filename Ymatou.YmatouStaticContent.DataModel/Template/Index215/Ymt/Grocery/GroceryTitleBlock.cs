using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Grocery
{
    /// <summary>
    /// 食品保健标题
    /// </summary>
    public class GroceryTitleBlock : IBlock
    {
        public override int BlcokID
        {
            get { return YmtBlocksEnums.GroceryTitleBlock; }
        }

        public override string BlockName
        {
            get { return "食品保健标题"; }
        }

        public override Type ViewModel
        {
            get { return typeof(GroceryTitleBlockItemViewModel); }
        }
    }

    public class GroceryTitleBlockItem : IBlockItem<GroceryTitleBlockItemViewModel>
    {
    }
    

    public class GroceryTitleBlockItemViewModel : IBlockItemViewModel
    {
        /// <summary>
        /// 中文
        /// </summary>
        [DisplayName(CNName = "中文标题", MaxLength = 25)]
        public string CNTitle { get; set; }

        [DisplayName(CNName = "中文标题链接", InputFormat = DisplayNameInputFormat.Link)]
        public string CNLink { get; set; }

        /// <summary>
        /// 英文
        /// </summary>
        [DisplayName(CNName = "英文标题", MaxLength = 25)]
        public string ENTitle { get; set; }

        [DisplayName(CNName = "英文标题链接", InputFormat = DisplayNameInputFormat.Link)]
        public string ENLink { get; set; }
    }
}
