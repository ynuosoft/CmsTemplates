using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt
{
    class YmtTemplate :  ITemplate
    {
        private IDictionary<int, IBlock> _ListTemplateBlock;


        /// <summary>
        /// 模板编号
        /// </summary>
        public override TemplateEnum TemplateID
        {
            get { return TemplateEnum.NewIndex215YMTTemplate; }
        }

        /// <summary>
        /// 模板名称
        /// </summary>
        public override string TemplateName
        {
            get { return "215 洋码头新首页"; }
        }

        /// <summary>
        /// 页面预览
        /// </summary>
        public override string ViewUrl
        {
            get
            {
                return "/Shared/Ymt215PreView";
            }
        }

        /// <summary>
        /// 可视化编辑模式
        /// </summary>
        public override string EditViewUrl
        {
            get
            {
                return "/Admin/CMSAdmin/Ymt215Index";
            }
            set
            {
                base.EditViewUrl = value;
            }
        }

        /// <summary>
        /// 区块集合
        /// </summary>
        public override IDictionary<int, IBlock> ListTemplateBlock
        {
            get { return _ListTemplateBlock; }
        }

        /// <summary>
        /// 添加区块到集合
        /// </summary>
        public override void AddTemplateBlock()
        {
            _ListTemplateBlock = new Dictionary<int, IBlock>();

            // 页头部分
            _ListTemplateBlock.Add(YmtBlocksEnums.TopNoticeBlock, new Top.TopNoticeBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.TopBannerBlock, new Top.TopBannerBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.SearchKeywordBlock, new Top.SearchKeywordBlock());

            // 团
            _ListTemplateBlock.Add(YmtBlocksEnums.OverseaTuanBlock, new Tuan.OverseaTuanBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.EverydayTuanBlock, new Tuan.EverydayTuanBlock());

            // Banner广告位
            _ListTemplateBlock.Add(YmtBlocksEnums.LeftUpBannerBlock, new Banner.LeftUpBannerBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.LeftDownBannerBlock, new Banner.LeftDownBannerBlock());

            // 母婴
            _ListTemplateBlock.Add(YmtBlocksEnums.MaternityTitleBlock, new Maternity.MaternityTitleBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.MaternityCategoryBlock, new Maternity.MaternityCategoryBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.MaternityLeftDownBlock, new Maternity.MaternityLeftDownBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.MaternityMiddleBlock, new Maternity.MaternityMiddleBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.MaternityRightBlock, new Maternity.MaternityRightBlock());

            // 美妆个护
            _ListTemplateBlock.Add(YmtBlocksEnums.BeautyTitleBlock, new Beauty.BeautyTitleBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.BeautyCategoryBlock, new Beauty.BeautyCategoryBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.BeautyLeftDownBlock, new Beauty.BeautyLeftDownBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.BeautyMiddleBlock, new Beauty.BeautyMiddleBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.BeautyRightBlock, new Beauty.BeautyRightBlock());

            // 食品保健
            _ListTemplateBlock.Add(YmtBlocksEnums.GroceryTitleBlock, new Grocery.GroceryTitleBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.GroceryCategoryBlock, new Grocery.GroceryCategoryBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.GroceryLeftDownBlock, new Grocery.GroceryLeftDownBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.GroceryMiddleBlock, new Grocery.GroceryMiddleBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.GroceryRightBlock, new Grocery.GroceryRightBlock());

            // 服饰鞋包
            _ListTemplateBlock.Add(YmtBlocksEnums.ApparelTitleBlock, new Apparel.ApparelTitleBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.ApparelCategoryBlock, new Apparel.ApparelCategoryBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.ApparelLeftDownBlock, new Apparel.ApparelLeftDownBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.ApparelMiddleBlock, new Apparel.ApparelMiddleBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.ApparelRightBlock, new Apparel.ApparelRightBlock());

            // 居家日用
            _ListTemplateBlock.Add(YmtBlocksEnums.HomeGoodsTitleBlock, new HomeGoods.HomeGoodsTitleBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.HomeGoodsCategoryBlock, new HomeGoods.HomeGoodsCategoryBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.HomeGoodsLeftDownBlock, new HomeGoods.HomeGoodsLeftDownBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.HomeGoodsMiddleBlock, new HomeGoods.HomeGoodsMiddleBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.HomeGoodsRightBlock, new HomeGoods.HomeGoodsRightBlock());

            // 运动户外
            _ListTemplateBlock.Add(YmtBlocksEnums.SportsTitleBlock, new Sports.SportsTitleBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.SportsCategoryBlock, new Sports.SportsCategoryBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.SportsLeftDownBlock, new Sports.SportsLeftDownBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.SportsMiddleBlock, new Sports.SportsMiddleBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.SportsRightBlock, new Sports.SportsRightBlock());

            // HotRecommend
            _ListTemplateBlock.Add(YmtBlocksEnums.HotBrandsBlock, new HotRecommend.HotBrandsBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.HotTagBlock, new HotRecommend.HotTagBlock());
            _ListTemplateBlock.Add(YmtBlocksEnums.RecommendBlock, new HotRecommend.RecommendBlock());

        }
    }
}
