using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Beauty
{
    /// <summary>
    /// 美妆个护左下商品
    /// </summary>
    public class BeautyLeftDownBlock : IBlock
    {

        public override int BlcokID
        {
            get { return YmtBlocksEnums.BeautyLeftDownBlock; }
        }

        public override string BlockName
        {
            get { return "美妆个护左下商品"; }
        }

        public override Type ViewModel
        {
            get { return typeof(BeautyLeftDownBlockItemViewModel); }
        }
    }

    public class BeautyLeftDownBlockItem : IBlockItem<BeautyLeftDownBlockItemViewModel>
    {
    }

    public class BeautyLeftDownBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "商品图片", Group = "左下商品", Tips = "图片尺寸：279×148")]
        public string LeftDownImg { get; set; }

        [DisplayName(CNName = "商品链接", Group = "左下商品", InputFormat = DisplayNameInputFormat.Link)]
        public string LeftDownLink { get; set; }
    }
}
