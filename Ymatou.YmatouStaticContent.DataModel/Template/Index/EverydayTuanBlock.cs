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
    public class EverydayTuanBlock : IBlock
    {
        /// <summary>
        /// 
        /// </summary>
        public override int BlcokID
        {
            get { return IndexBlockEnum.EverydayTuan; }
        }
        /// <summary>
        /// 
        /// </summary>
        public override string BlockName
        {
            get { return "每日团"; }
        }

        public override Type ViewModel
        {
            get { return typeof(EverydayTuanBlockItemViewModel); }
        }
        public override string ExternalLink
        {
            get
            {
                return "/Admin/CMSAdmin/AddEevryTuan";
            }
            set
            {
                base.ExternalLink = value;
            }
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class EverydayTuanBlockItem : IBlockItem<EverydayTuanBlockItemViewModel>
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public class EverydayTuanBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "角标", MaxLength = 4)]
        public string ShortName { get; set; }
        [DisplayName(CNName = "商品图片", InputFormat = DisplayNameInputFormat.Link)]
        public string ImgUrl { get; set; }

        [DisplayName(CNName = "折扣", MaxLength = 4)]
        public String Discount { get; set; }

        [DisplayName(CNName = "标题",MaxLength=32)]
        public string Title { get; set; }

        [DisplayName(CNName = "介绍",MaxLength=96)]
        public string Desc { get; set; }

        [DisplayName(CNName = "售价")]
        public decimal ShowPrice { get; set; }

        [DisplayName(CNName = "原价")]
        public decimal OriginalPrice { get; set; }

        [DisplayName(CNName = "Banner链接", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl { get; set; }

        [DisplayName(CNName = "购买人数")]
        public int BuyerCount { get; set; }
        [DisplayName(CNName = "特卖结束时间", InputFormat = DisplayNameInputFormat.DateTime)]
        public DateTime EndTime { get; set; }
        [DisplayName(CNName = "商品编号")]
        public string ProductID { get; set; }

    }
}
