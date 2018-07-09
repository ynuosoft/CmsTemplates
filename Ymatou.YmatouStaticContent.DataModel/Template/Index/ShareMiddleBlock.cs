using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    /// <summary>
    /// 
    /// </summary>
    public class ShareMiddleBlock : IBlock
    {
        public override int BlcokID
        {
            get { return IndexBlockEnum.ShareMiddle; }
        }

        public override string BlockName
        {
            get { return "分享互动-中文章"; }
        }

        public override Type ViewModel
        {
            get { return typeof(ShareMiddleBlockItemViewModel); }
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class ShareMiddleBlockItem : IBlockItem<ShareMiddleBlockItemViewModel>
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public class ShareMiddleBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "图片地址", Tips = "图片尺寸：80×80")]
        public string ImgUrl { get; set; }
        [DisplayName(CNName = "信息标题", MaxLength = 17)]
        public string Title { get; set; }
        [DisplayName(CNName = "链接地址")]
        public string LinkUrl { get; set; }
    }
}
