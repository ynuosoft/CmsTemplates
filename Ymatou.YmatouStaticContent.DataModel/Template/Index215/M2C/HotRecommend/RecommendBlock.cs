using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C.HotRecommend
{
    /// <summary>
    /// 人气商品
    /// </summary>
    public class RecommendBlock : Ymt.HotRecommend.RecommendBlock
    {
        public override int BlcokID
        {
            get
            {
                return M2CBlocksEnums.RecommendBlock;
            }
        }

        public override string BlockName
        {
            get
            {
                return "人气商品";
            }
        }

        public override Type ViewModel
        {
            get
            {
                return typeof(RecommendBlockItemViewModel);
            }
        }

        public override string ExternalLink
        {
            get
            {
                return "/Admin/CMSAdmin/AddM2CPopularProducts";
            }
            set
            {
                base.ExternalLink = value;
            }
        }
    }

    public class RecommendBlockItem : IBlockItem<RecommendBlockItemViewModel>
    {

    }

    public class RecommendBlockItemViewModel : Ymt.HotRecommend.RecommendBlockItemViewModel
    {

    }
}
