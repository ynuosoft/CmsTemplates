using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.CountryPavilion.AmericanPavilion
{
    public class BrandLogoBlock : IBlock
    {
        public override int BlcokID
        {
            get { return AmericanPavilionBlockEnum.BrandLogoBlock; }
        }

        public override string BlockName
        {
            get { return "美国品牌LOGO"; }
        }

        public override Type ViewModel
        {
            get { return typeof(BrandLogoBlockItemViewModel); }
        }

        public override string ExternalLink
        {
            get
            {
                return base.ExternalLink;
            }
            set
            {
                base.ExternalLink = value;
            }
        }
    }

    public class BrandLogoBlockItem : IBlockItem<BrandLogoBlockItemViewModel>
    {

    }

    public class BrandLogoBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "品牌名称", Group = "1")]
        public string BrandName { get; set; }

        [DisplayName(CNName = "品牌LOGO图片链接地址", Group = "2")]
        public string BrandLogoPicUrl { get; set; }

        [DisplayName(CNName = "品牌LOGO跳转链接", Group = "2")]
        public string BrandLogoLink { get; set; }
    }
}
