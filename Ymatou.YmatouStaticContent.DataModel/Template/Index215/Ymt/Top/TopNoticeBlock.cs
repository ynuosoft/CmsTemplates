using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Top
{
    /// <summary>
    /// 页顶公告
    /// </summary>
    public class TopNoticeBlock : IBlock
    {
        public override int BlcokID
        {
            get { return YmtBlocksEnums.TopNoticeBlock; }
        }

        public override string BlockName
        {
            get { return "页顶公告"; }
        }

        public override Type ViewModel
        {
            get { return typeof(TopNoticeBlockItemViewModel); }
        }
    }

    public class TopNoticeBlockItem : IBlockItem<TopNoticeBlockItemViewModel>
    {
    }

    public class TopNoticeBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "公告标题", MaxLength = 25)]
        public string Title { get; set; }

        [DisplayName(CNName = "公告链接", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl { get; set; }

        [DisplayName(CNName = "是否重要", Tips = "重要：1，不重要：0", InputFormat = DisplayNameInputFormat.Int)]
        public int Important { get; set; }
    }
}
