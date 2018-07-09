using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C.Baby
{
    /// <summary>
    /// 母婴馆中左中右中两个图片商品
    /// </summary>
    public class BabyMiddleRightBlock : IBlock
    {

        public override int BlcokID
        {
            get { return M2CBlocksEnums.BabyMiddleRightBlock; }
        }

        public override string BlockName
        {
            get { return "母婴馆中左中右中两个图片商品"; }
        }

        public override Type ViewModel
        {
            get { return typeof(BabyMiddleRightBlockItemViewModel); }
        }
    }

    public class BabyMiddleRightBlockItem : IBlockItem<BabyMiddleRightBlockItemViewModel>
    {
    }

    public class BabyMiddleRightBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "左中Banner", Group = "左中Banner", Tips = "图片尺寸：290×160")]
        public string LeftDownImgUrl { get; set; }

        [DisplayName(CNName = "左中Banner链接", Group = "左中Banner")]
        public string LeftDownLinkUrl { get; set; }


        [DisplayName(CNName = "右边Banner", Group = "右边Banner", Tips = "图片尺寸：290×485")]
        public string RightUpImgUrl { get; set; }

        [DisplayName(CNName = "右边Banner链接", Group = "右边Banner")]
        public string RightUpLinkUrl { get; set; }
    }
}
