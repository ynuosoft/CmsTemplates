using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymatou.StaticContent.DataModel.Template.WapIndex
{
    public class EveryDayTuan4Block :IBlock
    {
        public override int BlcokID
        {
            get
            {
                return WapIndexBlockEnum.EveryDayTuan4;
            }
        }

        public override string BlockName
        {
            get
            {
                return "自定义商品模块";
            }
        }
        public override Type ViewModel
        {
            get
            {
                return typeof(EveryDayTuan4BlockItemViewModel);
            }
        }

        private string _externalLink = string.Format("/Admin/OverseaPavilion/AddGroupBuyProductsBlockItem");

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
    public class EveryDayTuan4BlockItem : IBlockItem<EveryDayTuan4BlockItemViewModel>
    {

    }
    public class EveryDayTuan4BlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "标题", Group = "标题",MaxLength=5)]
        public string Title { get; set; }
        [DisplayName(CNName = "副标题", Group = "标题",MaxLength=16)]
        public string SubTitle { get; set; }

        [DisplayName(CNName = "产品大图", Group = "产品大图")]
        public string ImgUrl1 { get; set; }
        [DisplayName(CNName = "产品大图链接", Group = "产品大图")]
        public string LinkUrl1 { get; set; }

        [DisplayName(CNName = "产品中图", Group = "产品中图")]
        public string ImgUrl2 { get; set; }
        [DisplayName(CNName = "产品中图链接", Group = "产品中图")]
        public string LinkUrl2 { get; set; }
        [DisplayName(CNName = "产品中图名称", Group = "产品中图")]
        public string ProductTitle2 { get; set; }
        [DisplayName(CNName = "产品中图价格", Group = "产品中图")]
        public string ProductPrice2 { get; set; }
        [DisplayName(CNName = "产品中图市场价格", Group = "产品中图")]
        public string ProductOldPrice2 { get; set; }


        [DisplayName(CNName = "产品小图1", Group = "产品小图1")]
        public string ImgUrl3 { get; set; }
        [DisplayName(CNName = "产品小图1链接", Group = "产品小图1")]
        public string LinkUrl3 { get; set; }
        [DisplayName(CNName = "产品小图1名称", Group = "产品小图1")]
        public string ProductTitle3 { get; set; }
        [DisplayName(CNName = "产品小图1价格", Group = "产品小图1")]
        public string ProductPrice3 { get; set; }
        [DisplayName(CNName = "产品小图1市场价格", Group = "产品小图1")]
        public string ProductOldPrice3 { get; set; }

        [DisplayName(CNName = "产品小图2", Group = "产品小图2")]
        public string ImgUrl4 { get; set; }
        [DisplayName(CNName = "产品小图2链接", Group = "产品小图2")]
        public string LinkUrl4 { get; set; }
        [DisplayName(CNName = "产品小图2名称", Group = "产品小图2")]
        public string ProductTitle4 { get; set; }
        [DisplayName(CNName = "产品小图2价格", Group = "产品小图2")]
        public string ProductPrice4 { get; set; }
        [DisplayName(CNName = "产品小图2市场价格", Group = "产品小图2")]
        public string ProductOldPrice4 { get; set; }
    }
}
