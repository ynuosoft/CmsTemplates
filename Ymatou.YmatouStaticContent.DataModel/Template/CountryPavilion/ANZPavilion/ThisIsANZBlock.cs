using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.CountryPavilion.ANZPavilion
{
    public class ThisIsANZBlock : IBlock
    {
        public override int BlcokID
        {
            get { return ANZPavilionBlockEnum.ThisIsBlock; }
        }

        public override string BlockName
        {
            get { return "最澳洲"; }
        }

        public override Type ViewModel
        {
            get { return typeof(ThisIsANZBlockItemViewModel); }
        }
    }

    public class ThisIsANZBlockBlockItem : IBlockItem<ThisIsANZBlockItemViewModel>
    {

    }

    public class ThisIsANZBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "最澳洲HTML内容", InputFormat = DisplayNameInputFormat.Html)]
        public string ContentHTML { get; set; }
    }
}
