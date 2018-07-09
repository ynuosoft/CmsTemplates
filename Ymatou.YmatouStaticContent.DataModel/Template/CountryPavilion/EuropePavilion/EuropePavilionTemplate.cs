using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.CountryPavilion.EuropePavilion
{
    public class EuropePavilionTemplate : ITemplate
    {
        private IDictionary<int, IBlock> _ListTemplateBlock;

        public override TemplateEnum TemplateID
        {
            get { return TemplateEnum.EuropePavilionTemplate; }
        }

        public override string TemplateName
        {
            get { return "欧洲馆模板"; }
        }

        //预览URL
        public override string ViewUrl
        {
            get { return "/staticcontent/europepavilion/preview"; }
        }

        //可视化编辑URL
        public override string EditViewUrl
        {
            get
            {
                return "/Admin/OverseaPavilion/EuropeEdit";
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

            _ListTemplateBlock.Add(EuropePavilionBlockEnum.TopBannerBlock, new TopBannerBlock());
            _ListTemplateBlock.Add(EuropePavilionBlockEnum.DiscountWeekCalendarBlock, new DiscountWeekCalendarBlock());
            _ListTemplateBlock.Add(EuropePavilionBlockEnum.BrandBlock, new BrandBlock());
            _ListTemplateBlock.Add(EuropePavilionBlockEnum.BrandLogoBlock, new BrandLogoBlock());
            _ListTemplateBlock.Add(EuropePavilionBlockEnum.StarSellerBlock, new StarSellerBlock());
            _ListTemplateBlock.Add(EuropePavilionBlockEnum.EuropeCountryCollectionBlock, new EuropeCountryCollectionBlock());
            _ListTemplateBlock.Add(EuropePavilionBlockEnum.NewDiscoveryBlock, new NewDiscoveryBlock());
            _ListTemplateBlock.Add(EuropePavilionBlockEnum.HotSeasonBlock, new HotSeasonBlock());
            _ListTemplateBlock.Add(EuropePavilionBlockEnum.MotherBabyBlock, new MotherBabyBlock());
            _ListTemplateBlock.Add(EuropePavilionBlockEnum.HealthFoodBlock, new HealthFoodBlock());
            _ListTemplateBlock.Add(EuropePavilionBlockEnum.BeautyBlock, new BeautyBlock());
            _ListTemplateBlock.Add(EuropePavilionBlockEnum.BagClothingBlock, new BagClothingBlock());
            _ListTemplateBlock.Add(EuropePavilionBlockEnum.ManBlock, new ManBlock());
            _ListTemplateBlock.Add(EuropePavilionBlockEnum.ThisIsBlock, new ThisIsEuropeBlock());
            _ListTemplateBlock.Add(EuropePavilionBlockEnum.LeftPromotionIconBlock, new LeftPromotionIconBlock());
        }
    }
}
