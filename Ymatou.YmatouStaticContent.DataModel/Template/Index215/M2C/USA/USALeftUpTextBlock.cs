using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C.USA
{
    /// <summary>
    /// 美国馆左上文字块
    /// </summary>
    public class USALeftUpTextBlock : Index.AmericaDistrictLeftUpBlock
    {
        public override int BlcokID
        {
            get
            {
                return M2CBlocksEnums.USALeftUpTextBlock;
            }
        }

        public override string BlockName
        {
            get
            {
                return "美国馆左上文字块";
            }
        }

        public override Type ViewModel
        {
            get
            {
                return typeof(USALeftUpTextBlockItemViewModel);
            }
        }
    }

    public class USALeftUpTextBlockItem : IBlockItem<USALeftUpTextBlockItemViewModel>
    {

    }

    public class USALeftUpTextBlockItemViewModel : Index.AmericaDistrictLeftUpBlockItemViewModel
    {
    }
}
