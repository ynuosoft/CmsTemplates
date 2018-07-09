using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Sports
{
    public class SportsCategoryBlock : IBlock
    {
        /// <summary>
        /// 运动户外分类
        /// </summary>
        public override int BlcokID
        {
            get { return YmtBlocksEnums.SportsCategoryBlock; }
        }

        public override string BlockName
        {
            get { return "运动户外分类"; }
        }

        public override Type ViewModel
        {
            get { return typeof(SportsCategoryBlockItemViewModel); }
        }
    }

    public class SportsCategoryBlockItem : IBlockItem<SportsCategoryBlockItemViewModel>
    {

    }

    public class SportsCategoryBlockItemViewModel : IBlockItemViewModel
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
