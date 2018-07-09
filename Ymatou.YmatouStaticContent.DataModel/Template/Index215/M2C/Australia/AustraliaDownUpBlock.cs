using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C.Australia
{
    public class AustraliaDownUpBlock : Asia.AsiaDownUpBlock
    {
        public override int BlcokID
        {
            get { return M2CBlocksEnums.AustraliaDownUpBlock; }
        }

        public override string BlockName
        {
            get
            {
                return "澳新馆左下右上两个图片商品";
            }
        }

        public override Type ViewModel
        {
            get
            {
                return typeof(AustraliaDownUpBlockItemViewModel);
            }
        }
    }

    public class AustraliaDownUpBlockItem : IBlockItem<AustraliaDownUpBlockItemViewModel>
    {

    }

    public class AustraliaDownUpBlockItemViewModel : Asia.AsiaDownUpBlockItemViewModel
    {

    }
}
