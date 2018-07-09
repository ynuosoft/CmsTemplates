using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Maternity
{
    /// <summary>
    /// 母婴标题
    /// </summary>
    public class MaternityTitleBlock : IBlock
    {

        /// <summary>
        /// 
        /// </summary>
        public override int BlcokID
        {
            get { return YmtBlocksEnums.MaternityTitleBlock; }
        }

        /// <summary>
        /// 
        /// </summary>
        public override string BlockName
        {
            get { return "母婴标题"; }
        }

        /// <summary>
        /// 
        /// </summary>
        public override Type ViewModel
        {
            get { return typeof(MaternityTitleBlockItemViewModel); }
        }
    }

    public class MaternityTitleBlockItem : IBlockItem<MaternityTitleBlockItemViewModel>
    {
    }

    public class MaternityTitleBlockItemViewModel : IBlockItemViewModel
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
