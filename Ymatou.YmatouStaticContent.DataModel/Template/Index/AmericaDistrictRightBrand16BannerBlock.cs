using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    public class AmericaDistrictRightBrand16BannerBlock : IBlock
    {
        public override int BlcokID
        {
            get { return IndexBlockEnum.AmericaDistrictRightBrand16Banner; }
        }

        public override string BlockName
        {
            get { return "美国馆-右边16个品牌Banner"; }
        }

        public override Type ViewModel
        {
            get { return typeof(AmericaDistrictRightBrand16BannerBlockItemViewModel); }
        }
    }

    public class AmericaDistrictRightBrand16BannerBlockItem : IBlockItem<AmericaDistrictRightBrand16BannerBlockItemViewModel>
    {

    }

    public class AmericaDistrictRightBrand16BannerBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "品牌图片", InputFormat = DisplayNameInputFormat.Image, Tips = "图片尺寸：90×50")]
        public string ImgUrl { get; set; }

        [DisplayName(CNName = "品牌链接", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl { get; set; }
    }
}
