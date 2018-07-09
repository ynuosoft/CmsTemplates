using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    public class AustraliaNewZealandDistrict2BannerBlock : IBlock
    {

        public override int BlcokID
        {
            get { return IndexBlockEnum.AustraliaNewZealandDistrict2Banner; }
        }

        public override string BlockName
        {
            get { return "澳新馆-左下Banner、右上Banner"; }
        }
        public override Type ViewModel
        {
            get
            {
                return typeof(AustraliaNewZealandDistrict2BannerBlockItemViewModel);
            }
        }
    }
    public class AustraliaNewZealandDistrict2BannerBlockItem : IBlockItem<AustraliaNewZealandDistrict2BannerBlockItemViewModel>
    {

    }

    public class AustraliaNewZealandDistrict2BannerBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "左下Banner", Group = "左下Banner", Tips = "图片尺寸：270×135")]
        public string LeftDownImgUrl { get; set; }

        [DisplayName(CNName = "左下Banner链接", Group = "左下Banner")]
        public string LeftDownLinkUrl { get; set; }


        [DisplayName(CNName = "右上Banner", Group = "右上Banner", Tips = "图片尺寸：275×155")]
        public string RightUpImgUrl { get; set; }

        [DisplayName(CNName = "右上Banner链接", Group = "右上Banner")]
        public string RightUpLinkUrl { get; set; }
    }
}
