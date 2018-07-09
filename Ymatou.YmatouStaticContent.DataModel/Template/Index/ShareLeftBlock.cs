using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    public class ShareLeftBlock : IBlock
    {
        public override int BlcokID
        {
            get { return IndexBlockEnum.ShareLeft; }
        }
        public override string BlockName
        {
            get { return "分享互动-左文章"; }
        }
        public override Type ViewModel
        {
            get { return typeof(ShareLeftBlockItemViewModel); }
        }

    }
    public class ShareLeftBlockItem : IBlockItem<ShareLeftBlockItemViewModel>
    {

    }
    public class ShareLeftBlockItemViewModel : IBlockItemViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName(CNName = "图片", Tips = "图片尺寸：80×80")]
        public string ImageUrl { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        [DisplayName(CNName = "文字标题", MaxLength = 14)]
        public string Title { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
        [DisplayName(CNName = "链接地址")]
        public string LinkUrl { get; set; }
        /// <summary>
        /// 文字内容
        /// </summary>
        [DisplayName(CNName = "文字内容", MaxLength = 57)]
        public string Desc { get; set; }
    }
}
