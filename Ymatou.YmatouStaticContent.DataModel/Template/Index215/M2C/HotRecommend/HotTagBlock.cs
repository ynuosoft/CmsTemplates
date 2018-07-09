using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C.HotRecommend
{
    /// <summary>
    /// 热门标签
    /// </summary>
    public class HotTagBlock :Ymt.HotRecommend.HotTagBlock
    {
        public override int BlcokID
        {
            get
            {
                return M2CBlocksEnums.HotTagBlock;
            }
        }

        public override string BlockName
        {
            get
            {
                return "热门标签";
            }
        }

        public override Type ViewModel
        {
            get
            {
                return typeof(HotTagBlockItemViewModel);
            }
        }
    }

    public class HotTagBlockItem : IBlockItem<HotTagBlockItemViewModel>
    {

    }

    public class HotTagBlockItemViewModel : Ymt.HotRecommend.HotTagBlockItemViewModel
    {

    }
}
