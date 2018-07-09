using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Top
{
    /// <summary>
    /// 搜素关键字
    /// </summary>
    public class SearchKeywordBlock : IBlock
    {
        public override int BlcokID
        {
            get { return YmtBlocksEnums.SearchKeywordBlock; }
        }

        public override string BlockName
        {
            get { return "搜素关键字"; }
        }

        public override Type ViewModel
        {
            get { return typeof(SearchKeywordBlockItemViewModel); }
        }
    }

    public class SearchKeywordBlockItem : IBlockItem<SearchKeywordBlockItemViewModel>
    {

    }

    public class SearchKeywordBlockItemViewModel : IBlockItemViewModel
    {
        /// <summary>
        /// 关键字
        /// </summary>
        [DisplayName(CNName = "关键字", MaxLength = 25)]
        public string Keyword { get; set; }

        /// <summary>
        /// 关键字链接地址
        /// </summary>
        [DisplayName(CNName = "关键字链接地址", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl { get; set; }
    }
}
