using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymatou.StaticContent.DataModel.Template.OverSeaTuan
{
    public class HotSalesBlcok : IBlock
    {

        public override int BlcokID
        {
            get { return (int)OverSearTuanBlockEnum.HotSalesBlcok; }
        }

        public override string BlockName
        {
            get { return "正在热卖模块"; }
        }

        public override Type ViewModel
        {
            get { return typeof(HotSalesBlockItemViewModel); }
        }
    }

    public class HotSalesBlockItem : IBlockItem<HotSalesBlockItemViewModel>
    {

    }

    public class HotSalesBlockItemViewModel : IBlockItemViewModel
    {
        /// <summary>
        /// 左边热卖活动图片地址
        /// </summary>
        [DisplayName(CNName = "左边热卖活动图片地址")]
        public string LeftImgUrl { get; set; }

        /// <summary>
        /// 该活动截止时间
        /// </summary>
        [DisplayName(CNName = "该活动截止时间")]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 商家一名称
        /// </summary>
        [DisplayName(CNName = "商家一名称")]
        public string MerchantName1 { get; set; }

        /// <summary>
        /// 商家一Logo图片地址
        /// </summary>
        [DisplayName(CNName = "商家一Logo图片地址")]
        public string MerchantLogoPicUrl1 { get; set; }

        /// <summary>
        /// 商家一描述
        /// </summary>
        [DisplayName(CNName = "商家一描述")]
        public string MerchantDescription1 { get; set; }

        /// <summary>
        /// 商家一的商品一名称
        /// </summary>
        [DisplayName(CNName = "商品一名称")]
        public string CommodityName1 { get; set; }

        /// <summary>
        /// 商家一的商品一图片地址
        /// </summary>
        [DisplayName(CNName = "商品一图片地址")]
        public string CommodityPicUrl1 { get; set; }

        /// <summary>
        /// 商家一的商品一价格
        /// </summary>
        [DisplayName(CNName = "商品一价格")]
        public decimal CommodityPPrice1 { get; set; }

        /// <summary>
        /// 商家一的商品二名称
        /// </summary>
        [DisplayName(CNName = "商品二名称")]
        public string CommodityName2 { get; set; }

        /// <summary>
        /// 商家一的商品二图片地址
        /// </summary>
        [DisplayName(CNName = "商品二图片地址")]
        public string CommodityPicUrl2 { get; set; }

        /// <summary>
        /// 商家一的商品一价格
        /// </summary>
        [DisplayName(CNName = "商品二价格")]
        public decimal CommodityPPrice2 { get; set; }

        /// <summary>
        /// 商家二名称
        /// </summary>
        [DisplayName(CNName = "商家二名称")]
        public string MerchantName2 { get; set; }

        /// <summary>
        /// 商家二Logo图片地址
        /// </summary>
        [DisplayName(CNName = "商家二Logo图片地址")]
        public string MerchantLogoPicUrl2 { get; set; }

        /// <summary>
        /// 商家二描述
        /// </summary>
        [DisplayName(CNName = "商家二描述")]
        public string MerchantDescription2 { get; set; }

        /// <summary>
        /// 商家三名称
        /// </summary>
        [DisplayName(CNName = "商家三名称")]
        public string MerchantName3 { get; set; }

        /// <summary>
        /// 商家三Logo图片地址
        /// </summary>
        [DisplayName(CNName = "商家三Logo图片地址")]
        public string MerchantLogoPicUrl3 { get; set; }

        /// <summary>
        /// 商家三描述
        /// </summary>
        [DisplayName(CNName = "商家三描述")]
        public string MerchantDescription3 { get; set; }

        /// <summary>
        /// 商家四名称
        /// </summary>
        [DisplayName(CNName = "商家四名称")]
        public string MerchantName4 { get; set; }

        /// <summary>
        /// 商家四Logo图片地址
        /// </summary>
        [DisplayName(CNName = "商家四Logo图片地址")]
        public string MerchantLogoPicUrl4 { get; set; }

        /// <summary>
        /// 商家四描述
        /// </summary>
        [DisplayName(CNName = "商家四描述")]
        public string MerchantDescription4 { get; set; }

    }
}
