using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C.Tuan
{
    public class OverseasTuanBlock : IBlock
    {
        public override int BlcokID
        {
            get { return M2CBlocksEnums.OverseasTuanBlock; }
        }

        public override string BlockName
        {
            get { return "海外团"; }
        }

        public override Type ViewModel
        {
            get { return typeof(OverseasTuanBlockItemViewModel); }
        }
    }

    public class OverseasTuanBlockItem : IBlockItem<OverseasTuanBlockItemViewModel>
    {
    }

    public class OverseasTuanBlockItemViewModel : IBlockItemViewModel
    {
        #region //左边大图商品

        [DisplayName(CNName = "左Banner图片", InputFormat = DisplayNameInputFormat.Link, Tips = "图片尺寸：170×220")]
        public string LefImgUrl { get; set; }

        [DisplayName(CNName = "左Banner链接", InputFormat = DisplayNameInputFormat.Link)]
        public string LefLinkUrl { get; set; }

        [DisplayName(CNName = "左Banner标题第一行", MaxLength = 24)]
        public string LeftTitle1 { get; set; }

        [DisplayName(CNName = "左Banner标题第二行", MaxLength = 20)]
        public string LeftTitle2 { get; set; }

        [DisplayName(CNName = "左Banner标题第三行红色的文字", MaxLength = 20)]
        public string LeftTitle3 { get; set; }

        [DisplayName(CNName = "左Banner促销语", MaxLength = 8)]
        public string LeftPromotionText { get; set; }

        [DisplayName(CNName = "左Banner价格", MaxLength = 8)]
        public string LeftPrice { get; set; }

        [DisplayName(CNName = "左Banner按钮文字", MaxLength = 8)]
        public string LeftButtonText { get; set; }

        [DisplayName(CNName = "左Banner结束时间", InputFormat = DisplayNameInputFormat.DateTime)]
        public DateTime LeftEndDate { get; set; }

        #endregion
    }
}
