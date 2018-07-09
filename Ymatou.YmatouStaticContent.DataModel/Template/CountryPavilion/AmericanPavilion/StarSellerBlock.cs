using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.CountryPavilion.AmericanPavilion
{
    public class StarSellerBlock : IBlock
    {
        public override int BlcokID
        {
            get { return AmericanPavilionBlockEnum.StarSellerBlock; }
        }

        public override string BlockName
        {
            get { return "明星卖家"; }
        }

        public override Type ViewModel
        {
            get { return typeof(StarSellerBlockItemViewModel); }
        }
    }

    public class StarSellerBlockItem : IBlockItem<StarSellerBlockItemViewModel>
    {

    }

    public class StarSellerBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "卖家名称")]
        public string SellerName { get; set; }

        [DisplayName(CNName = "卖家ID")]
        public string SellerID { get; set; }

        [DisplayName(CNName = "卖家店铺图片地址")]
        public string SellerStorePic { get; set; }

        [DisplayName(CNName = "卖家店铺链接地址")]
        public string SellerStoreLinkUrl { get; set; }

        [DisplayName(CNName = "卖家所在地")]
        public string SellerAddress { get; set; }

        [DisplayName(CNName = "卖家描述（经营范围）")]
        public string SellerDescription { get; set; }
    }
}
