using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.HomeGoods
{
    public class HomeGoodsCategoryBlock : IBlock
    {
        public override int BlcokID
        {
            get { return YmtBlocksEnums.HomeGoodsCategoryBlock; }
        }

        public override string BlockName
        {
            get { return "居家日用分类"; }
        }

        public override Type ViewModel
        {
            get { return typeof(HomeGoodsCategoryBlockItemViewModel); }
        }
    }

    public class HomeGoodsCategoryBlockItem : IBlockItem<HomeGoodsCategoryBlockItemViewModel>
    {
    }

    public class HomeGoodsCategoryBlockItemViewModel : IBlockItemViewModel
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
