using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.HomeGoods
{
    public class HomeGoodsLeftDownBlock : IBlock
    {
        /// <summary>
        /// 居家日用左下商品
        /// </summary>
        public override int BlcokID
        {
            get { return YmtBlocksEnums.HomeGoodsLeftDownBlock; }
        }

        public override string BlockName
        {
            get { return "居家日用左下商品"; }
        }

        public override Type ViewModel
        {
            get { return typeof(HomeGoodsLeftDownBlockItemViewModel); }
        }
    }

    public class HomeGoodsLeftDownBlockItem : IBlockItem<HomeGoodsLeftDownBlockItemViewModel>
    {
    }

    public class HomeGoodsLeftDownBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "商品图片", Group = "左下商品", Tips = "图片尺寸：279×148")]
        public string LeftDownImg { get; set; }

        [DisplayName(CNName = "商品链接", Group = "左下商品", InputFormat = DisplayNameInputFormat.Link)]
        public string LeftDownLink { get; set; }
    }
}
