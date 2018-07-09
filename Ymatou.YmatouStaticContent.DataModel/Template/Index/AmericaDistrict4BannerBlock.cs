using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    /// <summary>
    /// 
    /// </summary>
    public class AmericaDistrict4BannerBlock : IBlock
    {
        public override int BlcokID
        {
            get { return IndexBlockEnum.AmericaDistrict4Banner; }
        }

        public override string BlockName
        {
            get { return "美国馆-左下Banner、左中上Banner、右中上Banner、右中下Banner"; }
        }

        public override Type ViewModel
        {
            get { return typeof(AmericaDistrict4BannerBlockItemViewModel); }
        }
    }

    public class AmericaDistrict4BannerBlockItem : IBlockItem<AmericaDistrict4BannerBlockItemViewModel>
    {

    }

    public class AmericaDistrict4BannerBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "左下Banner", Group = "左下Banner", Tips = "图片尺寸：270×315")]
        public string LeftDownImg { get; set; }
        [DisplayName(CNName = "左下Banner链接", Group = "左下Banner", InputFormat = DisplayNameInputFormat.Link)]
        public string LeftDownLink { get; set; }
        
        //
        [DisplayName(CNName = "左中上Banner", Group = "左中上Banner", Tips = "图片尺寸：275×155")]
        public string LeftMiddleUpImg { get; set; }
        [DisplayName(CNName = "左中上Banner链接", Group = "左中上Banner", InputFormat = DisplayNameInputFormat.Link)]
        public string LeftMiddleUpLink { get; set; }
        
        //
        [DisplayName(CNName = "右中上Banner", Group = "右中上Banner", Tips = "图片尺寸：375×235")]
        public string RightMiddleUpImg { get; set; }
        [DisplayName(CNName = "右中上Banner链接", Group = "右中上Banner", InputFormat = DisplayNameInputFormat.Link)]
        public string RightMiddleUpLink { get; set; }
        
        //
        [DisplayName(CNName = "右中下Banner", Group = "右中下Banner", Tips = "图片尺寸：375×235")]
        public string RightMiddleDownImg { get; set; }
        [DisplayName(CNName = "右中下Banner链接", Group = "右中下Banner", InputFormat = DisplayNameInputFormat.Link)]
        public string RightMiddleDownLink { get; set; }

       
    }
}
