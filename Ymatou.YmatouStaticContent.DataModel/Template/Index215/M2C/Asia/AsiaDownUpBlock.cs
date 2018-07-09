using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C.Asia
{
    /// <summary>
    /// 亚洲馆左下右上两个图片商品
    /// </summary>
    public class AsiaDownUpBlock : IBlock
    {
        public override int BlcokID
        {
            get { return M2CBlocksEnums.AsiaDownUpBlock; }
        }

        public override string BlockName
        {
            get { return "亚洲馆左下右上两个图片商品"; }
        }

        public override Type ViewModel
        {
            get { return typeof(AsiaDownUpBlockItemViewModel); }
        }
    }

    public class AsiaDownUpBlockItem : IBlockItem<AsiaDownUpBlockItemViewModel>
    {
    }

    public class AsiaDownUpBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "左下Banner", Group = "左下Banner", Tips = "图片尺寸：290×325")]
        public string LeftDownImgUrl { get; set; }

        [DisplayName(CNName = "左下Banner链接", Group = "左下Banner")]
        public string LeftDownLinkUrl { get; set; }


        [DisplayName(CNName = "右上Banner", Group = "右上Banner", Tips = "图片尺寸：290×160")]
        public string RightUpImgUrl { get; set; }

        [DisplayName(CNName = "右上Banner链接", Group = "右上Banner")]
        public string RightUpLinkUrl { get; set; }
    }

}
