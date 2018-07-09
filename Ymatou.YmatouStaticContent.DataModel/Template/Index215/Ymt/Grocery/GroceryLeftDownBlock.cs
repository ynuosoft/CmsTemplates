using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Grocery
{
    /// <summary>
    /// 食品保健左下商品
    /// </summary>
    public class GroceryLeftDownBlock : IBlock
    {

        public override int BlcokID
        {
            get { return YmtBlocksEnums.GroceryLeftDownBlock; }
        }

        public override string BlockName
        {
            get { return "食品保健左下商品"; }
        }

        public override Type ViewModel
        {
            get { return typeof(GroceryLeftDownBlockItemViewModel); }
        }
    }

    public class GroceryLeftDownBlockItem : IBlockItem<GroceryLeftDownBlockItemViewModel>
    {   
    }


    public class GroceryLeftDownBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "商品图片", Group = "左下商品", Tips = "图片尺寸：279×148")]
        public string LeftDownImg { get; set; }

        [DisplayName(CNName = "商品链接", Group = "左下商品", InputFormat = DisplayNameInputFormat.Link)]
        public string LeftDownLink { get; set; }
    }
}
