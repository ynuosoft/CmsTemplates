using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C.Banner
{
    /// <summary>
    /// M2C频道首页大电视墙
    /// </summary>
    public class TopBannerBlock : IBlock
    {
        public override int BlcokID
        {
            get
            {
                return M2CBlocksEnums.TopBannerBlock;
            }
        }

        public override string BlockName
        {
            get
            {
                return "M2C频道首页大电视墙";
            }
        }

        public override Type ViewModel
        {
            get
            {
                return typeof(TopBannerBlockItemViewModel);
            }
        }
    }

    public class TopBannerBlockItem : IBlockItem<TopBannerBlockItemViewModel>
    {
    }

    public class TopBannerBlockItemViewModel : Ymt.Top.TopBannerBlockItemViewMode
    {
    }
}
