using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Grocery
{
    /// <summary>
    /// 食品保健右边大图商品
    /// </summary>
    public class GroceryRightBlock : IBlock
    {

        public override int BlcokID
        {
            get { return YmtBlocksEnums.GroceryRightBlock; }
        }

        public override string BlockName
        {
            get { return "食品保健右边大图商品"; }
        }

        public override Type ViewModel
        {
            get { return typeof(GroceryRightBlockItemViewModel); }
        }
    }

    public class GroceryRightBlockItem : IBlockItem<GroceryRightBlockItemViewModel>
    {
    }

    public class GroceryRightBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "商品图片地址", Group = "右边大商品", Tips = "图片尺寸：265×305")]
        public string RightImg { get; set; }
        [DisplayName(CNName = "商品图片链接", Group = "右边大商品", InputFormat = DisplayNameInputFormat.Link)]
        public string RightLink { get; set; }
    }
}
