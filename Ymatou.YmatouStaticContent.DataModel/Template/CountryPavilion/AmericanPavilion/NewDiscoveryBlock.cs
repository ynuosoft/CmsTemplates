using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.CountryPavilion.AmericanPavilion
{
    public class NewDiscoveryBlock : IBlock
    {
        public override int BlcokID
        {
            get { return AmericanPavilionBlockEnum.NewDiscoveryBlock; }
        }

        public override string BlockName
        {
            get { return "新发现"; }
        }

        public override Type ViewModel
        {
            get { return typeof(CommodityBlockItemViewModel); }
        }

        private string _externalLink = string.Format("/Admin/OverseaPavilion/addproductblockitem?templateid={0}&templateblockid={1}",
                                                        (int)TemplateEnum.AmericanPavilionTemplate, AmericanPavilionBlockEnum.NewDiscoveryBlock);
        public override string ExternalLink
        {
            get
            {
                return _externalLink;
            }
            set
            {
                _externalLink = value;
            }
        }
    }

    public class NewDiscoveryBlockItem : IBlockItem<CommodityBlockItemViewModel>
    {

    }

    public class CommodityBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "商品ID")]
        public string CommodityID { get; set; }

        [DisplayName(CNName = "商品描述")]
        public string CommodityDescription { get; set; }

        [DisplayName(CNName = "商品图片地址")]
        public string CommodityPicUrl { get; set; }

        [DisplayName(CNName = "商品链接地址")]
        public string CommodityUrl { get; set; }

        [DisplayName(CNName = "商品价格")]
        public string CommodityPrice { get; set; }

        [DisplayName(CNName = "商品旧价格")]
        public string CommodityOldPrice { get; set; }

        [DisplayName(CNName = "商品状态文字", Tips = "填写商品销售状态： 热售/售完/促销/或者其它文字（2-4个文字, 默认为空表示正常状态不显示文字）", DefaultInputValue = "",MaxLength=4)]
        public string CommodityStatus { get; set; }

        [DisplayName(CNName = "商品促销角标颜色", Tips = "填写促销角标颜色，填写数字类型： 0：不显示角标/1：红色角标/2：蓝色角标/3:灰色售完角标 （默认值为0） ", DefaultInputValue = "0",MaxLength=1)]
        public string CommodityIconColor { get; set; }

        [DisplayName(CNName = "商品高亮关键字")]
        public string CommodityHightlightKeyword { get; set; }
    }
}
