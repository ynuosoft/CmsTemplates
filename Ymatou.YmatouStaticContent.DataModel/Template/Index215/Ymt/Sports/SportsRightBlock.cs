using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Sports
{
    /// <summary>
    /// 运动户外右边大图商品
    /// </summary>
    public class SportsRightBlock : IBlock
    {
        public override int BlcokID
        {
            get { return YmtBlocksEnums.SportsRightBlock; }
        }

        public override string BlockName
        {
            get { return "运动户外右边大图商品"; }
        }

        public override Type ViewModel
        {
            get { return typeof(SportsRightBlockItemViewModel); }
        }
    }

    public class SportsRightBlockItem : IBlockItem<SportsRightBlockItemViewModel>
    {

    }

    public class SportsRightBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "商品图片地址", Group = "右边大商品", Tips = "图片尺寸：265×305")]
        public string RightImg { get; set; }
        [DisplayName(CNName = "商品图片链接", Group = "右边大商品", InputFormat = DisplayNameInputFormat.Link)]
        public string RightLink { get; set; }
    }
}
