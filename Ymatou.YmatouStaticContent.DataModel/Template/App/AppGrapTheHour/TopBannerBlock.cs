using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.App.AppGrapTheHour
{
    /// <summary>
    /// 
    /// </summary>
    public class TopBannerBlock : IBlock
    {
        public override int BlcokID
        {
            get { return AppGrapTheHourBlockEnum.TopBannerBlock; }
        }
        public override string BlockName
        {
            get { return "顶部大Banner"; }
        }

        public override Type ViewModel
        {
            get { return typeof(TopBannerBlockItemViewModel); }
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class TopBannerBlockItem : IBlockItem<TopBannerBlockItemViewModel>
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public class TopBannerBlockItemViewModel : IBlockItemViewModel
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
        [DisplayName(CNName = "Banner链接", InputFormat = DisplayNameInputFormat.Link, Tips = "请输入完整的链接，eg:http://www.ymatou.com/")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DisplayName(CNName = "Banner类型", InputFormat = DisplayNameInputFormat.Int, Tips = "商品详情：1，活动详情：2", MaxLength = 1)]
        public string LinkType { get; set; }
    }

}
