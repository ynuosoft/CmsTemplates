using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.CountryPavilion.ANZPavilion
{
    public class ANZPavilionTemplate : ITemplate
    {
        private IDictionary<int, IBlock> _ListTemplateBlock;

        public override TemplateEnum TemplateID
        {
            get { return TemplateEnum.ANZPavilionTemplate; }
        }

        public override string TemplateName
        {
            get { return "澳新馆模板"; }
        }

        //预览URL
        public override string ViewUrl
        {
            get { return "/staticContent/anzPavilion/preview"; }
        }

        //可视化编辑URL
        public override string EditViewUrl
        {
            get
            {
                return "/Admin/OverseaPavilion/ANZEdit";
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

            _ListTemplateBlock.Add(ANZPavilionBlockEnum.TopBannerBlock, new TopBannerBlock());
            _ListTemplateBlock.Add(ANZPavilionBlockEnum.DiscountWeekCalendarBlock, new DiscountWeekCalendarBlock());
            _ListTemplateBlock.Add(ANZPavilionBlockEnum.BrandBlock, new BrandBlock());
            _ListTemplateBlock.Add(ANZPavilionBlockEnum.BrandLogoBlock, new BrandLogoBlock());
            _ListTemplateBlock.Add(ANZPavilionBlockEnum.StarSellerBlock, new StarSellerBlock());
            _ListTemplateBlock.Add(ANZPavilionBlockEnum.NewDiscoveryBlock, new NewDiscoveryBlock());
            _ListTemplateBlock.Add(ANZPavilionBlockEnum.HotSeasonBlock, new HotSeasonBlock());
            _ListTemplateBlock.Add(ANZPavilionBlockEnum.MotherBabyBlock, new MotherBabyBlock());
            _ListTemplateBlock.Add(ANZPavilionBlockEnum.HealthFoodBlock, new HealthFoodBlock());
            _ListTemplateBlock.Add(ANZPavilionBlockEnum.BeautyBlock, new BeautyBlock());
            _ListTemplateBlock.Add(ANZPavilionBlockEnum.BagClothingBlock, new BagClothingBlock());
            _ListTemplateBlock.Add(ANZPavilionBlockEnum.ManBlock, new ManBlock());
            _ListTemplateBlock.Add(ANZPavilionBlockEnum.ThisIsBlock, new ThisIsANZBlock());
            _ListTemplateBlock.Add(ANZPavilionBlockEnum.LeftPromotionIconBlock, new LeftPromotionIconBlock());
        }
    }
}
