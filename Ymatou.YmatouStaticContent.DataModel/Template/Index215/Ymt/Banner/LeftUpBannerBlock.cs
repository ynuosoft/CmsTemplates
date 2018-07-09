using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Banner
{
    /// <summary>
    /// 左上部分5帧广告位
    /// </summary>
    public class LeftUpBannerBlock : IBlock
    {
        /// <summary>
        /// 左上部分5帧广告位
        /// </summary>
        public override int BlcokID
        {
            get { return YmtBlocksEnums.LeftUpBannerBlock; }
        }

        public override string BlockName
        {
            get { return "左上部分5帧广告位"; }
        }

        public override Type ViewModel
        {
            get { return typeof(LeftUpBannerBlockItemViewModel); }
        }
    }

    public class LeftUpBannerBlockItem : IBlockItem<LeftUpBannerBlockItemViewModel>
    {
    }

    public class LeftUpBannerBlockItemViewModel : IBlockItemViewModel
    {
        /// <summary>
        /// 背景图片
        /// </summary>
        [DisplayName(CNName = "背景图片", InputFormat = DisplayNameInputFormat.Image, Tips = "图片尺寸：1×240")]
        public string BackgroudImgUrl { get; set; }
        /// <summary>
        /// 图片地址
        /// </summary>
        [DisplayName(CNName = "图片地址", InputFormat = DisplayNameInputFormat.Image, Tips = "图片尺寸：750×240")]
        public string ImgUrl { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
        [DisplayName(CNName = "链接地址", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl { get; set; }
    }
}
