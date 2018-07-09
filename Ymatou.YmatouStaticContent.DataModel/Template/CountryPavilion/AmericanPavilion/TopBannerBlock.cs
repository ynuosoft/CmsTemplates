using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.CountryPavilion.AmericanPavilion
{
    public class TopBannerBlock : IBlock
    {
        public override int BlcokID
        {
            get { return AmericanPavilionBlockEnum.TopBannerBlock; }
        }

        public override string BlockName
        {
            get { return "头部Banner电视墙"; }
        }

        public override Type ViewModel
        {
            get { return typeof(TopBannerBlockItemViewModel); }
        }
    }

    public class TopBannerBlockItem : IBlockItem<TopBannerBlockItemViewModel>
    {

    }

    public class TopBannerBlockItemViewModel : IBlockItemViewModel
    {
        /// <summary>
        /// 背景图片地址
        /// </summary>
        [DisplayName(CNName = "背景图片地址")]
        public string BackgroudImgUrl { get; set; }
        /// <summary>
        /// Banner图片地址
        /// </summary>
        [DisplayName(CNName = "Banner图片地址")]
        public string ImgUrl { get; set; }
        /// <summary>
        /// 链接跳转地址
        /// </summary>
        [DisplayName(CNName = "链接跳转地址")]
        public string LinkUrl { get; set; }
    }
}
