using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C.Europe
{
    /// <summary>
    /// 欧洲馆左上文字块
    /// </summary>
    public class EuropeLeftUpTextBlock : Baby.BabyLeftUpTextBlock
    {
        public override int BlcokID
        {
            get
            {
                return M2CBlocksEnums.EuropeLeftUpTextBlock;
            }
        }

        public override string BlockName
        {
            get
            {
                return "欧洲馆左上文字块";
            }
        }

        public override Type ViewModel
        {
            get
            {
                return typeof(EuropeLeftUpTextBlockItemViewModel);
            }
        }    
    }

    public class EuropeLeftUpTextBlockItem : IBlockItem<EuropeLeftUpTextBlockItemViewModel>
    {

    }

    public class EuropeLeftUpTextBlockItemViewModel : Baby.BabyLeftUpTextBlockItemViewModel
    {

    }
}
