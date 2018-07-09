using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Banner
{
    /// <summary>
    /// 左下部分4个平铺图片
    /// </summary>
    public class LeftDownBannerBlock : IBlock
    {

        public override int BlcokID
        {
            get { return YmtBlocksEnums.LeftDownBannerBlock; }
        }

        public override string BlockName
        {
            get { return "左下部分4个平铺图片"; }
        }

        public override Type ViewModel
        {
            get { return typeof(LeftDownBannerBlockItemViewModel); }
        }
    }

    public class LeftDownBannerBlockItem : IBlockItem<LeftDownBannerBlockItemViewModel>
    {
    }

    public class LeftDownBannerBlockItemViewModel : IBlockItemViewModel
    {
        /// <summary>
        /// 图片地址
        /// </summary>
        [DisplayName(CNName = "图片地址", InputFormat = DisplayNameInputFormat.Image, Tips = "图片尺寸：192×172")]
        public string ImgUrl { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
        [DisplayName(CNName = "链接地址", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl { get; set; }
    }
}
