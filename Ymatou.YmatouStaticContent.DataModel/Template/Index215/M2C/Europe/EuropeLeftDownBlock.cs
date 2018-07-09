using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C.Europe
{
    /// <summary>
    /// 欧洲馆左下两个商品
    /// </summary>
    public class EuropeLeftDownBlock : Baby.BabyLeftDownBlock
    {
        public override int BlcokID
        {
            get
            {
                return M2CBlocksEnums.EuropeLeftDownBlock;
            }
        }

        public override string BlockName
        {
            get
            {
                return "欧洲馆左下两个商品";
            }
        }

        public override Type ViewModel
        {
            get
            {
                return typeof(EuropeLeftDownBlockItemViewModel);
            }
        }
    }

    public class EuropeLeftDownBlockItem : IBlockItem<EuropeLeftDownBlockItemViewModel>
    {
    }

    public class EuropeLeftDownBlockItemViewModel : Baby.BabyLeftDownBlockItemViewModel
    {
    }
}
