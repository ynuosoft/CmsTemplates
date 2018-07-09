using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.App.AppEveryoneInTheAround
{
    /// <summary>
    /// 
    /// </summary>
    public class MiddleBannerBlock : IBlock
    {
        public override int BlcokID
        {
            get { return AppEveryoneInTheAroundBlockEnum.MiddleBannerBlock; }
        }
        public override string BlockName
        {
            get { return "腰部Banner"; }
        }

        public override Type ViewModel
        {
            get { return typeof(MiddleBannerBlockItemViewModel); }
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class MiddleBannerBlockItem : IBlockItem<MiddleBannerBlockItemViewModel>
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public class MiddleBannerBlockItemViewModel : IBlockItemViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName(CNName = "Banner图片", Tips = "600px*400px，尽可能不要超过30kb", InputFormat = DisplayNameInputFormat.Image)]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DisplayName(CNName = "Banner标题", InputFormat = DisplayNameInputFormat.String, MaxLength = 10, Tips = "Banner标题，请输入10个汉字以内")]
        public string BannerTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName(CNName = "Banner副标题", InputFormat = DisplayNameInputFormat.String, MaxLength = 10, Tips = "Banner副标题，请输入10个汉字以内")]
        public string BannerSubTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName(CNName = "Banner链接", InputFormat = DisplayNameInputFormat.Link, Tips = "请输入完整的链接，eg:http://www.ymatou.com/")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DisplayName(CNName = "Banner类型", InputFormat = DisplayNameInputFormat.Int, Tips = "商品详情：1，活动详情：2", MaxLength = 1)]
        public string LinkType { get; set; }
    }
}
