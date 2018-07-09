using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C.Baby
{
    /// <summary>
    /// 
    /// </summary>
    public class BabyTitleBlock : IBlock
    {
        public override int BlcokID
        {
            get { return M2CBlocksEnums.BabyTitleBlock; }
        }

        public override string BlockName
        {
            get { return "母婴馆标题和链接"; }
        }

        public override Type ViewModel
        {
            get { return typeof(BabyTitleBlockItemViewModel); }
        }
    }

    public class BabyTitleBlockItem:IBlockItem<BabyTitleBlockItemViewModel>
    {
    }

    public class BabyTitleBlockItemViewModel : IBlockItemViewModel
    {
        /// <summary>
        /// 中文
        /// </summary>
        [DisplayName(CNName = "中文标题", MaxLength = 10)]
        public string CNTitle { get; set; }

        [DisplayName(CNName = "中文标题链接", InputFormat = DisplayNameInputFormat.Link)]
        public string CNLink { get; set; }

        /// <summary>
        /// 英文
        /// </summary>
        [DisplayName(CNName = "英文标题", MaxLength = 25)]
        public string ENTitle { get; set; }
    }
}
