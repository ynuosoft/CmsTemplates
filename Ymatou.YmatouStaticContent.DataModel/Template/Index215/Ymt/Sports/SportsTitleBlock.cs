using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Sports
{
    /// <summary>
    /// 运动户外标题
    /// </summary>
    public class SportsTitleBlock : IBlock
    {
        public override int BlcokID
        {
            get { return YmtBlocksEnums.SportsTitleBlock; }
        }

        public override string BlockName
        {
            get { return "运动户外标题"; }
        }

        public override Type ViewModel
        {
            get { return typeof(SportsTitleBlockItemViewModel); }
        }
    }

    public class SportsTitleBlockItem : IBlockItem<SportsTitleBlockItemViewModel>
    {

    }

    public class SportsTitleBlockItemViewModel : IBlockItemViewModel
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
