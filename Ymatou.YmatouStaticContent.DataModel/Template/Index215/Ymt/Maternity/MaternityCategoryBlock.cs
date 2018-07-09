using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Maternity
{
    /// <summary>
    /// 母婴分类
    /// </summary>
    public class MaternityCategoryBlock : IBlock
    {

        public override int BlcokID
        {
            get { return YmtBlocksEnums.MaternityCategoryBlock; }
        }

        public override string BlockName
        {
            get { return "母婴分类"; }
        }

        public override Type ViewModel
        {
            get { return typeof(MaternityCategoryBlockItemViewModel); }
        }
    }

    public class MaternityCategoryBlockItem : IBlockItem<MaternityCategoryBlockItemViewModel>
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public class MaternityCategoryBlockItemViewModel : IBlockItemViewModel
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
