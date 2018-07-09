using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C.Australia
{
    /// <summary>
    /// 澳新馆左上文字块
    /// </summary>
    public class AustraliaLeftUpTextBlock : Asia.AsiaLeftUpTextBlock
    {
        public override int BlcokID
        {
            get
            {
                return M2CBlocksEnums.AustraliaLeftUpTextBlock;
            }
        }

        public override string BlockName
        {
            get
            {
                return "澳新馆左上文字块";
            }
        }

        public override Type ViewModel
        {
            get
            {
                return typeof(AustraliaLeftUpTextBlockItemViewModel);
            }
        }
    }

    public class AustraliaLeftUpTextBlockItem : IBlockItem<AustraliaLeftUpTextBlockItemViewModel>
    {

    }

    public class AustraliaLeftUpTextBlockItemViewModel : Asia.AsiaLeftUpTextBlockItemViewModel
    {

    }
}
