using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C.USA
{
    /// <summary>
    /// 美国馆4个Banner大图商品
    /// </summary>
    public class USABannerBlock : Index.AmericaDistrict4BannerBlock
    {
        public override int BlcokID
        {
            get
            {
                return M2CBlocksEnums.USABannerBlock;
            }
        }

        public override string BlockName
        {
            get
            {
                return "美国馆4个Banner大图商品";
            }
        }

        public override Type ViewModel
        {
            get
            {
                return typeof(USABannerBlockItemViewModel);
            }
        }
    }

    public class USABannerBlockItem : IBlockItem<USABannerBlockItemViewModel>
    {
    }

    public class USABannerBlockItemViewModel : Index.AmericaDistrict4BannerBlockItemViewModel
    {

    }
}
