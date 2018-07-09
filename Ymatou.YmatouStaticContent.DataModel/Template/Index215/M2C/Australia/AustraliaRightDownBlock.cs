using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C.Australia
{
    /// <summary>
    /// 澳新馆右下4个商品
    /// </summary>
    public class AustraliaRightDownBlock : Asia.AsiaRightDownBlock
    {
        public override int BlcokID
        {
            get
            {
                return M2CBlocksEnums.AustraliaRightDownBlock;
            }
        }

        public override string BlockName
        {
            get
            {
                return "澳新馆右下4个商品";
            }
        }

        public override Type ViewModel
        {
            get
            {
                return typeof(AustraliaRightDownBlockItemViewModel);
            }
        }
    }

    public class AustraliaRightDownBlockItem : IBlockItem<AustraliaRightDownBlockItemViewModel>
    {

    }

    public class AustraliaRightDownBlockItemViewModel : Asia.AsiaRightDownBlockItemViewModel
    {

    }
}
