using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    /// <summary>
    /// 还外团
    /// </summary>
    public class OverseaTuanBlock : IBlock
    {
        /// <summary>
        /// 
        /// </summary>
        public override int BlcokID
        {
            get { return IndexBlockEnum.OverSeaTuan; }
        }
        /// <summary>
        /// 
        /// </summary>
        public override string BlockName
        {
            get { return "海外团"; }
        }
        /// <summary>
        /// 
        /// </summary>
        public override Type ViewModel
        {
            get { return typeof(OverseaTuanBlockItemViewModel); }
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class OverseaTuanBlockItem : IBlockItem<OverseaTuanBlockItemViewModel>
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public class OverseaTuanBlockItemViewModel : IBlockItemViewModel
    {
        #region //左边
        [DisplayName(CNName = "左Banner图片", Group = "左Banner", InputFormat = DisplayNameInputFormat.Link,Tips="图片尺寸：260×280")]
        public string LefImgUrl { get; set; }
        [DisplayName(CNName = "左Banner链接", Group = "左Banner", InputFormat = DisplayNameInputFormat.Link)]
        public string LefLinkUrl { get; set; }
        [DisplayName(CNName = "左Banner标题第一行", Group = "左Banner",MaxLength=24)]
        public string LeftTitle1 { get; set; }
        [DisplayName(CNName = "左Banner标题第二行", Group = "左Banner",MaxLength=16)]
        public string LeftTitle2 { get; set; }
        [DisplayName(CNName = "左Banner标题第二行后括号中的文字", Group = "左Banner",MaxLength=8)]
        public string LeftTitle3 { get; set; }
        [DisplayName(CNName = "左Banner促销语", Group = "左Banner",MaxLength=8)]
        public string LeftPromotionText { get; set; }
        [DisplayName(CNName = "左Banner价格", Group = "左Banner",MaxLength=8)]
        public string LeftPrice { get; set; }
        [DisplayName(CNName = "左Banner按钮文字", Group = "左Banner",MaxLength=8)]
        public string LeftButtonText { get; set; }
        [DisplayName(CNName = "左Banner结束时间", Group = "左Banner", InputFormat = DisplayNameInputFormat.DateTime)]
        public DateTime LeftEndDate { get; set; }
        #endregion 

        #region //右上
        [DisplayName(CNName = "右上Banner图片", Group = "右上Banner", InputFormat = DisplayNameInputFormat.Link, Tips = "图片尺寸：130×130")]
        public string RightUpImgUrl { get; set; }
        [DisplayName(CNName = "右上Banner链接", Group = "右上Banner", InputFormat = DisplayNameInputFormat.Link)]
        public string RightUpLinkUrl { get; set; }
        [DisplayName(CNName = "右上Banner标题第一行", Group = "右上Banner",MaxLength=16)]
        public string RightUpTitle1 { get; set; }
        [DisplayName(CNName = "右上Banner标题第二行", Group = "右上Banner", MaxLength = 16)]
        public string RightUpTitle2 { get; set; }
        [DisplayName(CNName = "右上Banner原价", Group = "右上Banner",MaxLength=8)]
        public string RightUpPrePrice { get; set; }
        [DisplayName(CNName = "右上Banner现在价格", Group = "右上Banner", MaxLength = 8)]
        public string RightUpNowPrice { get; set; }

        #endregion 
        
        #region  右下

        [DisplayName(CNName = "右下Banner图片", Group = "右下Banner", InputFormat = DisplayNameInputFormat.Link, Tips = "图片尺寸：130×130")]
        public string RightDownImgUrl { get; set; }
        [DisplayName(CNName = "右下Banner链接", Group = "右下Banner", InputFormat = DisplayNameInputFormat.Link)]
        public string RightDownLinkUrl { get; set; }
        [DisplayName(CNName = "右下Banner标题第一行", Group = "右下Banner", MaxLength = 16)]
        public string RightDownTitle1 { get; set; }
        [DisplayName(CNName = "右下Banner标题第二行", Group = "右下Banner", MaxLength = 16)]
        public string RightDownTitle2 { get; set; }
        [DisplayName(CNName = "右下Banner原价", Group = "右下Banner", MaxLength = 8)]
        public string RightDownPrePrice { get; set; }
        [DisplayName(CNName = "右下Banner现在价格", Group = "右下Banner", MaxLength = 8)]
        public string RightDownNowPrice { get; set; }

        #endregion 
    }
}
