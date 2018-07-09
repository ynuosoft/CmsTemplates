using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C.HotRecommend
{
    /// <summary>
    /// 热卖榜两个大图
    /// </summary>
    public class TopTenBigBlock : IBlock
    {

        public override int BlcokID
        {
            get { return M2CBlocksEnums.TopTenBigBlock; }
        }

        public override string BlockName
        {
            get { return "热卖榜两个大图"; }
        }

        public override Type ViewModel
        {
            get { return typeof(TopTenBigBlockItemViewModel); }
        }
    }

    public class TopTenBigBlockItem : IBlockItem<TopTenBigBlockItemViewModel>
    {
    }

    public class TopTenBigBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "商品图片", Tips = "图片尺寸：80×80")]
        public string ImgUrl { get; set; }

        [DisplayName(CNName = "商品标题", MaxLength = 22, Tips = "输入22个字符以内")]
        public string Title { get; set; }

        [DisplayName(CNName = "商品链接", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl { get; set; }
    }
}
