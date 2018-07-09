using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    public class ShareRightImageBlock : IBlock
    {
        public override int BlcokID
        {
            get { return IndexBlockEnum.ShareRightImage; }
        }

        public override string BlockName
        {
            get { return "分享互动-右边-图片"; }
        }
        public override Type ViewModel
        {
            get { return typeof(ShareRightImageBlockItemViewModel); }
        }
    }

    public class ShareRightImageBlockItem : IBlockItem<ShareRightImageBlockItemViewModel>
    {

    }

    public class ShareRightImageBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "图片地址", Tips = "图片尺寸：80×80")]
        public string ImgUrl { get; set; }
        [DisplayName(CNName = "链接地址")]
        public string LinkUrl { get; set; }
    }
}
