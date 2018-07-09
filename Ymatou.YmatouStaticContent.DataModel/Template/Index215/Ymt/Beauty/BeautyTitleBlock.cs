using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Beauty
{
    /// <summary>
    /// 美妆个护标题
    /// </summary>
    public class BeautyTitleBlock : IBlock
    {

        public override int BlcokID
        {
            get { return YmtBlocksEnums.BeautyTitleBlock; }
        }

        public override string BlockName
        {
            get { return "美妆个护标题"; }
        }

        public override Type ViewModel
        {
            get { return typeof(BeautyTitleBlockItemViewModel); }
        }
    }

    public class BeautyTitleBlockItem : IBlockItem<BeautyTitleBlockItemViewModel>
    {
    }

    public class BeautyTitleBlockItemViewModel : IBlockItemViewModel
    {
        /// <summary>
        /// 中文
        /// </summary>
        [DisplayName(CNName = "中文标题", MaxLength = 25)]
        public string CNTitle { get; set; }

        [DisplayName(CNName = "中文标题链接", InputFormat = DisplayNameInputFormat.Link)]
        public string CNLink { get; set; }

        /// <summary>
        /// 英文
        /// </summary>
        [DisplayName(CNName = "英文标题", MaxLength = 25)]
        public string ENTitle { get; set; }

        [DisplayName(CNName = "英文标题链接", InputFormat = DisplayNameInputFormat.Link)]
        public string ENLink { get; set; }
    }
}
