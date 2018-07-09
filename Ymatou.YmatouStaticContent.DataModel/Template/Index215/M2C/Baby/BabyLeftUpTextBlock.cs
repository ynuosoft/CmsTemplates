using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C.Baby
{
    /// <summary>
    /// 母婴馆左上文字块
    /// </summary>
    public class BabyLeftUpTextBlock : Asia.AsiaLeftUpTextBlock
    {
        public override int BlcokID
        {
            get
            {
                return M2CBlocksEnums.BabyLeftUpTextBlock;
            }
        }

        public override string BlockName
        {
            get
            {
                return "母婴馆左上文字块";
            }
        }

        public override Type ViewModel
        {
            get
            {
                return typeof(BabyLeftUpTextBlockItemViewModel);
            }
        }
    }

    public class BabyLeftUpTextBlockItem : IBlockItem<BabyLeftUpTextBlockItemViewModel>
    {

    }

    public class BabyLeftUpTextBlockItemViewModel : Asia.AsiaLeftUpTextBlockItemViewModel
    {

    }
}
