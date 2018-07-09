using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymatou.StaticContent.DataModel.Template.WapIndex
{
    public class TopBannerBlock : IBlock
    {
        public override int BlcokID
        {
            get { return WapIndexBlockEnum.TopBanner; }
        }

        public override string BlockName
        {
            get { return "头部Banner"; }
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
        [DisplayName(CNName = "图片地址")]
        public string ImgUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName(CNName = "链接地址")]
        public string LinkUrl { get; set; }
    }
}
