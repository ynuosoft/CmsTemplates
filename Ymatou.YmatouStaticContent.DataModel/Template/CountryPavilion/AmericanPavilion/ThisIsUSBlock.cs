using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.CountryPavilion.AmericanPavilion
{
    public class ThisIsUSBlock : IBlock
    {
        public override int BlcokID
        {
            get { return AmericanPavilionBlockEnum.ThisIsBlock; }
        }

        public override string BlockName
        {
            get { return "最美国"; }
        }

        public override Type ViewModel
        {
            get { return typeof(ThisIsUSBlockItemViewModel); }
        }
    }

    public class ThisIsUSBlockItem : IBlockItem<ThisIsUSBlockItemViewModel>
    {

    }

    public class ThisIsUSBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "最美国HTML内容",InputFormat=DisplayNameInputFormat.Html)]
        public string ContentHTML { get; set; }
    }
}
