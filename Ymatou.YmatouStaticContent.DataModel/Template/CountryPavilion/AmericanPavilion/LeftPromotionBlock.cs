using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.CountryPavilion.AmericanPavilion
{
    public class LeftPromotionIconBlock : IBlock
    {
        public override int BlcokID
        {
            get { return AmericanPavilionBlockEnum.LeftPromotionIconBlock; }
        }

        public override string BlockName
        {
            get { return "最左侧大图标维护"; }
        }

        public override Type ViewModel
        {
            get { return typeof(LeftPromotionIconBlockItemViewModel); }
        }
    }

    public class LeftPromotionIconBlockItem : IBlockItem<LeftPromotionIconBlockItemViewModel>
    {

    }

    public class LeftPromotionIconBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "品牌栏最左侧模块图片地址", Group="1")]
        public string BrandIconPicUrl { get; set; }

        [DisplayName(CNName = "品牌栏最左侧模块链接跳转地址", Group = "1")]
        public string BrandIconLinkUrl { get; set; }

        [DisplayName(CNName = "品牌栏文字描述最前面的高亮关键字", Group = "1")]
        public string BrandIconHighlightKeywords { get; set; }

        [DisplayName(CNName = "品牌栏最左侧文字描述", Group = "1")]
        public string BrandIconDescrip { get; set; }

        [DisplayName(CNName = "品牌栏最左侧最上品牌名", Group = "1")]
        public string BrandTopName { get; set; }

        [DisplayName(CNName = "新发现最左侧模块图片地址", Group = "2")]
        public string NewDiscoveryIconPicUrl { get; set; }

        [DisplayName(CNName = "新发现最左侧模块链接跳转地址", Group = "2")]
        public string NewDiscoveryIconLinkUrl { get; set; }

        [DisplayName(CNName = "新发现最左侧模块商品价格", Group = "2")]
        public string NewDiscoveryCommodityPrice { get; set; }

        [DisplayName(CNName = "新发现最左侧模块商品旧价格", Group = "2")]
        public string NewDiscoveryCommodityOldPrice { get; set; }

        [DisplayName(CNName = "最热季最左侧模块图片地址", Group = "3")]
        public string HotSaleIconPicUrl { get; set; }

        [DisplayName(CNName = "最热季最左侧模块链接跳转地址", Group = "3")]
        public string HotSaleIconLinkUrl { get; set; }

        [DisplayName(CNName = "最热季最左侧模块商品价格", Group = "3")]
        public string HotSaleCommodityPrice { get; set; }

        [DisplayName(CNName = "最热季最左侧模块商品旧价格", Group = "3")]
        public string HotSaleCommodityOldPrice { get; set; }

        [DisplayName(CNName = "母婴宝宝最左侧模块图片地址", Group = "4")]
        public string MotherBabyIconPicUrl { get; set; }

        [DisplayName(CNName = "母婴宝宝最左侧模块链接跳转地址", Group = "4")]
        public string MotherBabyIconLinkUrl { get; set; }

        [DisplayName(CNName = "母婴宝宝最左侧模块商品价格", Group = "4")]
        public string MotherBabyCommodityPrice { get; set; }

        [DisplayName(CNName = "母婴宝宝最左侧模块商品旧价格", Group = "4")]
        public string MotherBabyCommodityOldPrice { get; set; }

        [DisplayName(CNName = "保健食品最左侧模块图片地址", Group = "5")]
        public string HealthIconPicUrl { get; set; }

        [DisplayName(CNName = "保健食品最左侧模块链接跳转地址", Group = "5")]
        public string HealthIconLinkUrl { get; set; }

        [DisplayName(CNName = "保健食品最左侧模块商品价格", Group = "5")]
        public string HealthCommodityPrice { get; set; }

        [DisplayName(CNName = "保健食品最左侧模块商品旧价格", Group = "5")]
        public string HealthCommodityOldPrice { get; set; }

        [DisplayName(CNName = "美妆个护最左侧模块图片地址", Group = "6")]
        public string BeautyIconPicUrl { get; set; }

        [DisplayName(CNName = "美妆个护最左侧模块链接跳转地址", Group = "6")]
        public string BeautyIconLinkUrl { get; set; }

        [DisplayName(CNName = "美妆个护最左侧模块商品价格", Group = "6")]
        public string BeautyCommodityPrice { get; set; }

        [DisplayName(CNName = "美妆个护最左侧模块商品旧价格", Group = "6")]
        public string BeautyCommodityOldPrice { get; set; }

        [DisplayName(CNName = "箱包服饰最左侧模块图片地址", Group = "7")]
        public string BagIconPicUrl { get; set; }

        [DisplayName(CNName = "箱包服饰最左侧模块链接跳转地址", Group = "7")]
        public string BagIconLinkUrl { get; set; }

        [DisplayName(CNName = "箱包服饰最左侧模块商品价格", Group = "7")]
        public string BagCommodityPrice { get; set; }

        [DisplayName(CNName = "箱包服饰最左侧模块商品旧价格", Group = "7")]
        public string BagCommodityOldPrice { get; set; }

        [DisplayName(CNName = "男士专区最左侧模块图片地址", Group = "8")]
        public string ManIconPicUrl { get; set; }

        [DisplayName(CNName = "男士专区最左侧模块链接跳转地址", Group = "8")]
        public string ManIconLinkUrl { get; set; }

        [DisplayName(CNName = "男士专区最左侧模块商品价格", Group = "8")]
        public string ManCommodityPrice { get; set; }

        [DisplayName(CNName = "男士专区最左侧模块商品旧价格", Group = "8")]
        public string ManCommodityOldPrice { get; set; }
    }
}
