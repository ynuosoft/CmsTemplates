using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.CountryPavilion.AmericanPavilion
{
    public class AmericanPavilionTemplate : ITemplate
    {
        private IDictionary<int, IBlock> _ListTemplateBlock;

        public override TemplateEnum TemplateID
        {
            get { return TemplateEnum.AmericanPavilionTemplate; }
        }

        public override string TemplateName
        {
            get { return "美国馆模板"; }
        }

        //预览URL
        public override string ViewUrl
        {
            get { return "/staticcontent/americanpavilion/preview"; }
        }

        //可视化编辑URL
        public override string EditViewUrl
        {
            get
            {
                return "/Admin/OverseaPavilion/AmericanEdit";
            }
            set
            {
                base.EditViewUrl = value;
            }
        }


        public override IDictionary<int, IBlock> ListTemplateBlock
        {
            get { return _ListTemplateBlock; }
        }

        public override void AddTemplateBlock()
        {
            _ListTemplateBlock = new Dictionary<int, IBlock>();

            _ListTemplateBlock.Add(AmericanPavilionBlockEnum.TopBannerBlock, new TopBannerBlock());
            _ListTemplateBlock.Add(AmericanPavilionBlockEnum.DiscountWeekCalendarBlock, new DiscountWeekCalendarBlock());
            _ListTemplateBlock.Add(AmericanPavilionBlockEnum.BrandBlock, new BrandBlock());
            _ListTemplateBlock.Add(AmericanPavilionBlockEnum.BrandLogoBlock, new BrandLogoBlock());
            _ListTemplateBlock.Add(AmericanPavilionBlockEnum.StarSellerBlock, new StarSellerBlock());
            _ListTemplateBlock.Add(AmericanPavilionBlockEnum.NewDiscoveryBlock, new NewDiscoveryBlock());
            _ListTemplateBlock.Add(AmericanPavilionBlockEnum.HotSeasonBlock, new HotSeasonBlock());
            _ListTemplateBlock.Add(AmericanPavilionBlockEnum.MotherBabyBlock, new MotherBabyBlock());
            _ListTemplateBlock.Add(AmericanPavilionBlockEnum.HealthFoodBlock, new HealthFoodBlock());
            _ListTemplateBlock.Add(AmericanPavilionBlockEnum.BeautyBlock, new BeautyBlock());
            _ListTemplateBlock.Add(AmericanPavilionBlockEnum.BagClothingBlock, new BagClothingBlock());
            _ListTemplateBlock.Add(AmericanPavilionBlockEnum.ManBlock, new ManBlock());
            _ListTemplateBlock.Add(AmericanPavilionBlockEnum.ThisIsBlock, new ThisIsUSBlock());
            _ListTemplateBlock.Add(AmericanPavilionBlockEnum.LeftPromotionIconBlock, new LeftPromotionIconBlock());
        }
    }
}
