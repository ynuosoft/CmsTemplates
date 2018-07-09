using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Beauty
{
    /// <summary>
    /// 美妆个护中间两个商品
    /// </summary>
    public class BeautyMiddleBlock : IBlock
    {

        public override int BlcokID
        {
            get { return YmtBlocksEnums.BeautyMiddleBlock; }
        }

        public override string BlockName
        {
            get { return "美妆个护中间两个商品"; }
        }

        public override Type ViewModel
        {
            get { return typeof(BeautyMiddleBlockItemViewModel); }
        }
    }

    public class BeautyMiddleBlockItem : IBlockItem<BeautyMiddleBlockItemViewModel>
    {
    }

    public class BeautyMiddleBlockItemViewModel : IBlockItemViewModel
    {
        /// <summary>
        /// 商品1
        /// </summary>
        [DisplayName(CNName = "图片", Tips = "图片尺寸：120×120")]
        public string ImgUrl { get; set; }

        [DisplayName(CNName = "商品标题", MaxLength = 10)]
        public string Title { get; set; }

        [DisplayName(CNName = "商品价格", MaxLength = 10)]
        public string Price { get; set; }

        [DisplayName(CNName = "图片链接", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl { get; set; }
    }
}
