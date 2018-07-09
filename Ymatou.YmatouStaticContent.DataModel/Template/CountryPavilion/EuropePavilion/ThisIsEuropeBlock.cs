using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.CountryPavilion.EuropePavilion
{
    public class ThisIsEuropeBlock : IBlock
    {
        public override int BlcokID
        {
            get { return EuropePavilionBlockEnum.ThisIsBlock; }
        }

        public override string BlockName
        {
            get { return "最欧洲"; }
        }

        public override Type ViewModel
        {
            get { return typeof(ThisIsEuropeBlockItemViewModel); }
        }
    }

    public class ThisIsEuropeBlockBlockItem : IBlockItem<ThisIsEuropeBlockItemViewModel>
    {

    }

    public class ThisIsEuropeBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "最欧洲HTML内容", InputFormat = DisplayNameInputFormat.Html)]
        public string ContentHTML { get; set; }
    }
}
