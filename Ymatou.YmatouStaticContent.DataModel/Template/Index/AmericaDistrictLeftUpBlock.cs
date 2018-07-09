using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    public class AmericaDistrictLeftUpBlock : IBlock
    {
        public override int BlcokID
        {
            get { return IndexBlockEnum.AmericaDistrictLeftUp; }
        }
        public override string BlockName
        {
            get { return "美国馆-左上文字"; }
        }

        public override Type ViewModel
        {
            get { return typeof(AmericaDistrictLeftUpBlockItemViewModel); }
        }
    }

    public class AmericaDistrictLeftUpBlockItem : IBlockItem<AmericaDistrictLeftUpBlockItemViewModel>
    {

    }

    public class AmericaDistrictLeftUpBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "文字标题",MaxLength=24)]
        public string Title { get; set; }
        [DisplayName(CNName = "链接地址", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl { get; set; }
    }
}
