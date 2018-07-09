using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymatou.StaticContent.DataModel.Template.OverSeaTuan
{
    public class TopLeftBannerBlock : IBlock
    {
        public override int BlcokID
        {
            get { return OverSearTuanBlockEnum.TopLeftBannerBlock; }
        }

        public override string BlockName
        {
            get { return "头部Banner"; }
        }

        public override Type ViewModel
        {
            get { return typeof(TopLeftBannerBlockItemViewModel); }
        }
    }

    public class TopLeftBannerBlockItem : IBlockItem<TopLeftBannerBlockItemViewModel>
    {

    }

    public class TopLeftBannerBlockItemViewModel : IBlockItemViewModel
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
