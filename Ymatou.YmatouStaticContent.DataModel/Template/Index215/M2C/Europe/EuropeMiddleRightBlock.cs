using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C.Europe
{
    /// <summary>
    /// 欧洲馆左中右中两个图片商品
    /// </summary>
    public class EuropeMiddleRightBlock : Baby.BabyMiddleRightBlock
    {
        public override int BlcokID
        {
            get
            {
                return M2CBlocksEnums.EuropeMiddleRightBlock;
            }
        }

        public override string BlockName
        {
            get
            {
                return "欧洲馆左中右中两个图片商品";
            }
        }

        public override Type ViewModel
        {
            get
            {
                return typeof(EuropeMiddleRightBlockItemViewModel);
            }
        }
    }

    public class EuropeMiddleRightBlockItem : IBlockItem<EuropeMiddleRightBlockItemViewModel>
    {

    }

    public class EuropeMiddleRightBlockItemViewModel : Baby.BabyMiddleRightBlockItemViewModel
    {

    }
}
