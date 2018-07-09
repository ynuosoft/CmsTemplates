using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    /// <summary>
    /// 
    /// </summary>
    public class TopBannerBlock : IBlock
    {
        /// <summary>
        /// 
        /// </summary>
        public override string BlockName
        {
            get { return "大电视墙Banner"; }
        }
        /// <summary>
        /// 
        /// </summary>
        public override int BlcokID
        {
            get { return IndexBlockEnum.TopBanner; }
        }

        /// <summary>
        /// 返回类型
        /// </summary>
        public override Type ViewModel
        {
            get
            {
                return typeof(TopBannerBlockItemViewModel);
            }
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
