using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Beauty
{
    /// <summary>
    /// 美妆个护分类
    /// </summary>
    public class BeautyCategoryBlock : IBlock
    {
        public override int BlcokID
        {
            get { return YmtBlocksEnums.BeautyCategoryBlock; }
        }

        public override string BlockName
        {
            get { return "美妆个护分类"; }
        }

        public override Type ViewModel
        {
            get { return typeof(BeautyCategoryBlockItemViewModel); }
        }
    }

    public class BeautyCategoryBlockItem : IBlockItem<BeautyCategoryBlockItemViewModel>
    {
    }


    public class BeautyCategoryBlockItemViewModel : IBlockItemViewModel
    {
        /// <summary>
        /// 分类标题
        /// </summary>
        [DisplayName(CNName = "分类标题", MaxLength = 25)]
        public string Title { get; set; }

        /// <summary>
        /// 链接地址
        /// </summary>
        [DisplayName(CNName = "链接地址", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl { get; set; }
    }
}
