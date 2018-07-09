using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Top
{
    /// <summary>
    /// 网站首页大电视墙
    /// </summary>
    public class TopBannerBlock : IBlock
    {

        public override int BlcokID
        {
            get { return YmtBlocksEnums.TopBannerBlock; }
        }

        public override string BlockName
        {
            get { return "网站首页大电视墙"; }
        }

        public override Type ViewModel
        {
            get { return typeof(TopBannerBlockItemViewMode); }
        }
    }

    public class TopBannerBlockItem : IBlockItem<TopBannerBlockItemViewMode>
    {

    }

    public class TopBannerBlockItemViewMode : IBlockItemViewModel
    {
        /// <summary>
        /// 背景图片
        /// </summary>
        [DisplayName(CNName = "背景图片", InputFormat = DisplayNameInputFormat.Image, Tips = "图片尺寸：1×300")]
        public string BackgroudImgUrl { get; set; }
        /// <summary>
        /// 图片地址
        /// </summary>
        [DisplayName(CNName = "图片地址", InputFormat = DisplayNameInputFormat.Image, Tips = "图片尺寸：1190×300")]
        public string ImgUrl { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
        [DisplayName(CNName = "链接地址", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl { get; set; }
    }
}
