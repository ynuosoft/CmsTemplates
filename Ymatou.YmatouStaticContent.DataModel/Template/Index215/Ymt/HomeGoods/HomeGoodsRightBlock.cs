using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.HomeGoods
{
    /// <summary>
    /// 居家日用右边商品
    /// </summary>
    public class HomeGoodsRightBlock : IBlock
    {

        public override int BlcokID
        {
            get { return YmtBlocksEnums.HomeGoodsRightBlock; }
        }

        public override string BlockName
        {
            get { return "居家日用右边商品"; }
        }

        public override Type ViewModel
        {
            get { return typeof(HomeGoodsRightBlockItemViewModel); }
        }
    }

    public class HomeGoodsRightBlockItem : IBlockItem<HomeGoodsRightBlockItemViewModel>
    {
    }


    public class HomeGoodsRightBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "商品图片地址", Group = "右边大商品", Tips = "图片尺寸：265×305")]
        public string RightImg { get; set; }
        [DisplayName(CNName = "商品图片链接", Group = "右边大商品", InputFormat = DisplayNameInputFormat.Link)]
        public string RightLink { get; set; }
    }
}
