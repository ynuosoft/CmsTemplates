using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Tuan
{
    /// <summary>
    /// 海外团
    /// </summary>
    public class OverseaTuanBlock : IBlock
    {

        public override int BlcokID
        {
            get { return YmtBlocksEnums.OverseaTuanBlock; }
        }

        public override string BlockName
        {
            get { return "海外团"; }
        }

        public override Type ViewModel
        {
            get { return typeof(OverseaTuanBlockItemViewModel); }
        }
    }

    public class OverseaTuanBlockItem : IBlockItem<OverseaTuanBlockItemViewModel>
    {

    }

    public class OverseaTuanBlockItemViewModel : IBlockItemViewModel
    {
        #region //左边大图商品

        [DisplayName(CNName = "左Banner图片", Group = "左Banner", InputFormat = DisplayNameInputFormat.Link, Tips = "图片尺寸：240×240")]
        public string LefImgUrl { get; set; }
        [DisplayName(CNName = "左Banner链接", Group = "左Banner", InputFormat = DisplayNameInputFormat.Link)]
        public string LefLinkUrl { get; set; }
        [DisplayName(CNName = "左Banner标题第一行", Group = "左Banner", MaxLength = 24)]
        public string LeftTitle1 { get; set; }
        [DisplayName(CNName = "左Banner标题第二行", Group = "左Banner", MaxLength = 20)]
        public string LeftTitle2 { get; set; }
        [DisplayName(CNName = "左Banner标题第三行红色的文字", Group = "左Banner", MaxLength = 20)]
        public string LeftTitle3 { get; set; }
        [DisplayName(CNName = "左Banner促销语", Group = "左Banner", MaxLength = 8)]
        public string LeftPromotionText { get; set; }
        [DisplayName(CNName = "左Banner价格", Group = "左Banner", MaxLength = 8)]
        public string LeftPrice { get; set; }
        [DisplayName(CNName = "左Banner按钮文字", Group = "左Banner", MaxLength = 8)]
        public string LeftButtonText { get; set; }
        [DisplayName(CNName = "左Banner结束时间", Group = "左Banner", InputFormat = DisplayNameInputFormat.DateTime)]
        public DateTime LeftEndDate { get; set; }
        #endregion

        #region 右上商品
        [DisplayName(CNName = "右上Banner图片", Group = "右上Banner", InputFormat = DisplayNameInputFormat.Link, Tips = "图片尺寸：80×74")]
        public string RightUpImgUrl { get; set; }

        [DisplayName(CNName = "右上Banner链接", Group = "右上Banner", InputFormat = DisplayNameInputFormat.Link)]
        public string RightUpLinkUrl { get; set; }

        [DisplayName(CNName = "右上Banner标题", Group = "右上Banner", MaxLength = 20)]
        public string RightUpTitle { get; set; }

        [DisplayName(CNName = "右上Banner价格", Group = "右上Banner", MaxLength = 8)]
        public string RightUpPrice { get; set; }

        #endregion

        #region  右下商品

        [DisplayName(CNName = "右下Banner图片", Group = "右下Banner", InputFormat = DisplayNameInputFormat.Link, Tips = "图片尺寸：80×74")]
        public string RightDownImgUrl { get; set; }

        [DisplayName(CNName = "右下Banner链接", Group = "右下Banner", InputFormat = DisplayNameInputFormat.Link)]
        public string RightDownLinkUrl { get; set; }

        [DisplayName(CNName = "右下Banner标题", Group = "右下Banner", MaxLength = 20)]
        public string RightDownTitle { get; set; }

        [DisplayName(CNName = "右下Banner价格", Group = "右下Banner", MaxLength = 8)]
        public string RightDownPrice { get; set; }

        #endregion 
    }
}
