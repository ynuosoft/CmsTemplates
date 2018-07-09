using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Apparel
{
    public class ApparelTitleBlock : IBlock
    {
        /// <summary>
        /// 
        /// </summary>
        public override int BlcokID
        {
            get { return YmtBlocksEnums.ApparelTitleBlock; }
        }

        /// <summary>
        /// 
        /// </summary>
        public override string BlockName
        {
            get { return "服饰鞋包的标题"; }
        }

        /// <summary>
        /// 
        /// </summary>
        public override Type ViewModel
        {
            get { return typeof(ApparelTitleBlockItemViewModel); }
        }
    }

    public class ApparelTitleBlockItem : IBlockItem<ApparelTitleBlockItemViewModel>
    {

    }

    public class ApparelTitleBlockItemViewModel : IBlockItemViewModel
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
