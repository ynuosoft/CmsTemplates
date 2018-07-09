using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Beauty
{
    /// <summary>
    /// 美妆个护右边大图商品
    /// </summary>
    public class BeautyRightBlock : IBlock
    {

        public override int BlcokID
        {
            get { return YmtBlocksEnums.BeautyRightBlock; }
        }

        public override string BlockName
        {
            get { return "美妆个护右边大图商品"; }
        }

        public override Type ViewModel
        {
            get { return typeof(BeautyRightBlockItemViewModel); }
        }
    }

    public class BeautyRightBlockItem : IBlockItem<BeautyRightBlockItemViewModel>
    {
    }

    public class BeautyRightBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "商品图片地址", Group = "右边大商品", Tips = "图片尺寸：265×305")]
        public string RightImg { get; set; }
        [DisplayName(CNName = "商品图片链接", Group = "右边大商品", InputFormat = DisplayNameInputFormat.Link)]
        public string RightLink { get; set; }
    }

}
