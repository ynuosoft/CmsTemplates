using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.CountryPavilion.EuropePavilion
{
    public class EuropeCountryCollectionBlock : IBlock
    {
        public override int BlcokID
        {
            get { return EuropePavilionBlockEnum.EuropeCountryCollectionBlock; }
        }

        public override string BlockName
        {
            get { return "国家精选"; }
        }

        public override Type ViewModel
        {
            get { return typeof(EuropeCountryCollectionBlockItemViewModel); }
        }
    }

    public class EuropeCountryCollectionBlockItem : IBlockItem<EuropeCountryCollectionBlockItemViewModel>
    {

    }

    public class EuropeCountryCollectionBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "国家名称", Group = "1", Tips = "只可选填国家：奥地利、比利时、捷克、丹麦、英国、芬兰、法国、德国、希腊、意大利、荷兰、波兰、葡萄牙、俄罗斯、西班牙、瑞典、瑞士，一共17个")]
        public string CountryName { get; set; }

        [DisplayName(CNName = "背景国旗图片地址", Group = "2")]
        public string BackgroundPicture { get; set; }

        [DisplayName(CNName = "国家链接URL地址", Group = "2")]
        public string CountryLinkUrl { get; set; }

        [DisplayName(CNName = "商品图片", Group = "2",InputFormat=DisplayNameInputFormat.Image)]
        public string CommodityPicture { get; set; }

        [DisplayName(CNName = "国家描述", Group = "3", MaxLength=48)]
        public string CommodityDescription { get; set; }

        [DisplayName(CNName = "现价", Group = "4")]
        public string Price { get; set; }

        [DisplayName(CNName = "旧价", Group = "4")]
        public string OldPrice { get; set; }
    }
}
