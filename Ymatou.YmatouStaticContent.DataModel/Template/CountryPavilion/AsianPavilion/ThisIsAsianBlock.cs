using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.CountryPavilion.AsianPavilion
{
    public class ThisIsAsianBlock : IBlock
    {
        public override int BlcokID
        {
            get { return AsianPavilionBlockEnum.ThisIsBlock; }
        }

        public override string BlockName
        {
            get { return "最亚洲"; }
        }

        public override Type ViewModel
        {
            get { return typeof(ThisIsAsianBlockItemViewModel); }
        }
    }

    public class ThisIsAsianBlockBlockItem : IBlockItem<ThisIsAsianBlockItemViewModel>
    {

    }

    public class ThisIsAsianBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "最亚洲HTML内容", InputFormat = DisplayNameInputFormat.Html)]
        public string ContentHTML { get; set; }
    }
}
