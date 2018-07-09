using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.CountryPavilion.AsianPavilion
{
    public class AsianPavilionTemplate : ITemplate
    {
        private IDictionary<int, IBlock> _ListTemplateBlock;

        public override TemplateEnum TemplateID
        {
            get { return TemplateEnum.AsianPavilionTemplate; }
        }

        public override string TemplateName
        {
            get { return "亚洲馆模板"; }
        }

        //预览URL
        public override string ViewUrl
        {
            get { return "/staticContent/asianPavilion/preview"; }
        }

        //可视化编辑URL
        public override string EditViewUrl
        {
            get
            {
                return "/Admin/OverseaPavilion/AsianEdit";
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

            _ListTemplateBlock.Add(AsianPavilionBlockEnum.TopBannerBlock, new TopBannerBlock());
            _ListTemplateBlock.Add(AsianPavilionBlockEnum.DiscountWeekCalendarBlock, new DiscountWeekCalendarBlock());
            _ListTemplateBlock.Add(AsianPavilionBlockEnum.BrandBlock, new BrandBlock());
            _ListTemplateBlock.Add(AsianPavilionBlockEnum.BrandLogoBlock, new BrandLogoBlock());
            _ListTemplateBlock.Add(AsianPavilionBlockEnum.StarSellerBlock, new StarSellerBlock());
            _ListTemplateBlock.Add(AsianPavilionBlockEnum.NewDiscoveryBlock, new NewDiscoveryBlock());
            _ListTemplateBlock.Add(AsianPavilionBlockEnum.HotSeasonBlock, new HotSeasonBlock());
            _ListTemplateBlock.Add(AsianPavilionBlockEnum.MotherBabyBlock, new MotherBabyBlock());
            _ListTemplateBlock.Add(AsianPavilionBlockEnum.HealthFoodBlock, new HealthFoodBlock());
            _ListTemplateBlock.Add(AsianPavilionBlockEnum.BeautyBlock, new BeautyBlock());
            _ListTemplateBlock.Add(AsianPavilionBlockEnum.BagClothingBlock, new BagClothingBlock());
            _ListTemplateBlock.Add(AsianPavilionBlockEnum.ManBlock, new ManBlock());
            _ListTemplateBlock.Add(AsianPavilionBlockEnum.ThisIsBlock, new ThisIsAsianBlock());
            _ListTemplateBlock.Add(AsianPavilionBlockEnum.LeftPromotionIconBlock, new LeftPromotionIconBlock());
        }
    }
}
