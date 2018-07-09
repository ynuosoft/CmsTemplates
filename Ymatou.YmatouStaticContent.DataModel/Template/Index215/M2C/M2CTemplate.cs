using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C
{
    /// <summary>
    /// 
    /// </summary>
    public class M2CTemplate : ITemplate
    {
        public override TemplateEnum TemplateID
        {
            get { return TemplateEnum.NewIndex215M2CTemplate; }
        }

        public override string TemplateName
        {
            get { return "215 M2C首页"; }
        }
        /// <summary>
        /// 预览地址
        /// </summary>
        public override string ViewUrl
        {
            get { return string.Empty; }
        }

        /// <summary>
        /// 可视化编辑地址
        /// </summary>
        public override string EditViewUrl
        {
            get
            {
                return base.EditViewUrl;
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

        private IDictionary<int, IBlock> _ListTemplateBlock;
        /// <summary>
        /// 
        /// </summary>
        public override void AddTemplateBlock()
        {
            _ListTemplateBlock = new Dictionary<int, IBlock>();

            _ListTemplateBlock.Add(M2CBlocksEnums.TopBannerBlock, new Banner.TopBannerBlock());

            _ListTemplateBlock.Add(M2CBlocksEnums.EverydayTuanBlock, new Tuan.EverydayTuanBlock());
            _ListTemplateBlock.Add(M2CBlocksEnums.OverseasTuanBlock, new Tuan.OverseasTuanBlock());

            _ListTemplateBlock.Add(M2CBlocksEnums.USABannerBlock, new USA.USABannerBlock());
            _ListTemplateBlock.Add(M2CBlocksEnums.USALeftUpTextBlock, new USA.USALeftUpTextBlock());
            _ListTemplateBlock.Add(M2CBlocksEnums.USAMiddleDownBlock, new USA.USAMiddleDownBlock());
            _ListTemplateBlock.Add(M2CBlocksEnums.USARightBrandBlock, new USA.USARightBrandBlock());

            _ListTemplateBlock.Add(M2CBlocksEnums.EuropeLeftUpTextBlock, new Europe.EuropeLeftUpTextBlock());
            _ListTemplateBlock.Add(M2CBlocksEnums.EuropeMiddleRightBlock, new Europe.EuropeMiddleRightBlock());
            _ListTemplateBlock.Add(M2CBlocksEnums.EuropeLeftDownBlock, new Europe.EuropeLeftDownBlock());

            _ListTemplateBlock.Add(M2CBlocksEnums.AsiaLeftUpTextBlock, new Asia.AsiaLeftUpTextBlock());
            _ListTemplateBlock.Add(M2CBlocksEnums.AsiaDownUpBlock, new Asia.AsiaDownUpBlock());
            _ListTemplateBlock.Add(M2CBlocksEnums.AsiaRightDownBlock, new Asia.AsiaRightDownBlock());

            _ListTemplateBlock.Add(M2CBlocksEnums.BabyTitleBlock, new Baby.BabyTitleBlock());
            _ListTemplateBlock.Add(M2CBlocksEnums.BabyLeftUpTextBlock, new Baby.BabyLeftUpTextBlock());
            _ListTemplateBlock.Add(M2CBlocksEnums.BabyMiddleRightBlock, new Baby.BabyMiddleRightBlock());
            _ListTemplateBlock.Add(M2CBlocksEnums.BabyLeftDownBlock, new Baby.BabyLeftDownBlock());

            _ListTemplateBlock.Add(M2CBlocksEnums.AustraliaLeftUpTextBlock, new Australia.AustraliaLeftUpTextBlock());
            _ListTemplateBlock.Add(M2CBlocksEnums.AustraliaDownUpBlock, new Australia.AustraliaDownUpBlock());
            _ListTemplateBlock.Add(M2CBlocksEnums.AustraliaRightDownBlock, new Australia.AustraliaRightDownBlock());

            _ListTemplateBlock.Add(M2CBlocksEnums.HotTagBlock, new HotRecommend.HotTagBlock());
            _ListTemplateBlock.Add(M2CBlocksEnums.TopTenBigBlock, new HotRecommend.TopTenBigBlock());
            _ListTemplateBlock.Add(M2CBlocksEnums.TopTenSmallBlock, new HotRecommend.TopTenSmallBlock());
            _ListTemplateBlock.Add(M2CBlocksEnums.RecommendBlock, new HotRecommend.RecommendBlock());
        }
    }
}
