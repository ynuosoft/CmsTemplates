using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C.Asia
{
    /// <summary>
    /// 亚洲馆左上文字块
    /// </summary>
    public class AsiaLeftUpTextBlock : IBlock
    {

        public override int BlcokID
        {
            get { return M2CBlocksEnums.AsiaLeftUpTextBlock; }
        }

        public override string BlockName
        {
            get { return "亚洲馆左上文字块"; }
        }

        public override Type ViewModel
        {
            get { return typeof(AsiaLeftUpTextBlockItemViewModel); }
        }
    }

    public class AsiaLeftUpTextBlockItem : IBlockItem<AsiaLeftUpTextBlockItemViewModel>
    {
    }

    public class AsiaLeftUpTextBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "文字标题", MaxLength = 24)]
        public string Title { get; set; }
        [DisplayName(CNName = "链接地址", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl { get; set; }
    }
}
