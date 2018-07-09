using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C.USA
{
    /// <summary>
    /// 美国馆右边16个品牌
    /// </summary>
    public class USARightBrandBlock : Index.AmericaDistrictRightBrand16BannerBlock
    {
        public override int BlcokID
        {
            get
            {
                return M2CBlocksEnums.USARightBrandBlock;
            }
        }

        public override string BlockName
        {
            get
            {
                return "美国馆右边16个品牌";
            }
        }

        public override Type ViewModel
        {
            get
            {
                return typeof(USARightBrandBlockItemViewModel);
            }
        }
    }

    public class USARightBrandBlockItem : IBlockItem<USARightBrandBlockItemViewModel>
    {
    }

    public class USARightBrandBlockItemViewModel : Index.AmericaDistrictRightBrand16BannerBlockItemViewModel
    {
    }
}
