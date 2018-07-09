using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    public class NoticeBlock : IBlock
    {
        public override int BlcokID
        {
            get { return IndexBlockEnum.NoticeBlock; }
        }

        public override string BlockName
        {
            get { return "公告"; }
        }

        public override Type ViewModel
        {
            get { return typeof(NoticeBlockItemViewModel); }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class NoticeBlockItem : IBlockItem<NoticeBlockItemViewModel>
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public class NoticeBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "公告标题",MaxLength=25)]
        public string Title { get; set; }

        [DisplayName(CNName = "公告链接", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl { get; set; }

        [DisplayName(CNName = "是否重要", Tips = "重要：1，不重要：0",InputFormat=DisplayNameInputFormat.Int)]
        public int Important { get; set; }
    }
}
