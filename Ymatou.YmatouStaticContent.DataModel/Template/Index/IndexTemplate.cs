using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ymatou.StaticContent.DataModel.Template.Index
{
    /// <summary>
    /// 首页模板
    /// </summary>
    public class PcIndexTemplate : ITemplate
    {
        private IDictionary<int, IBlock> _ListTemplateBlock;
        public override IDictionary<int, IBlock> ListTemplateBlock
        {
            get { return _ListTemplateBlock; }
        }
        /// <summary>
        /// 
        /// </summary>
        public override string TemplateName
        {
            get { return "Pc首页模板"; }
        }
        /// <summary>
        /// 
        /// </summary>
        public override TemplateEnum TemplateID
        {
            get { return TemplateEnum.PcIndexTemplate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public override void AddTemplateBlock()
        {
            _ListTemplateBlock= new Dictionary<int, IBlock>();
            _ListTemplateBlock.Add(IndexBlockEnum.TopBanner, new TopBannerBlock());
            //
            _ListTemplateBlock.Add(IndexBlockEnum.NoticeBlock, new NoticeBlock());
            //
            _ListTemplateBlock.Add(IndexBlockEnum.OverSeaTuan, new OverseaTuanBlock());
            _ListTemplateBlock.Add(IndexBlockEnum.EverydayTuan, new EverydayTuanBlock());
            //
            _ListTemplateBlock.Add(IndexBlockEnum.AmericaDistrictLeftUp, new AmericaDistrictLeftUpBlock());
            _ListTemplateBlock.Add(IndexBlockEnum.AmericaDistrict4Banner, new AmericaDistrict4BannerBlock());
            _ListTemplateBlock.Add(IndexBlockEnum.AmericaDistrictRightMiddleDown4Banner, new AmericaDistrictRightMiddleDown4BannerBlock());
            _ListTemplateBlock.Add(IndexBlockEnum.AmericaDistrictRightBrand16Banner, new AmericaDistrictRightBrand16BannerBlock());
            //
            _ListTemplateBlock.Add(IndexBlockEnum.EuropeDistrictLeftUp, new EuropeDistrictLeftUpBlock());
            _ListTemplateBlock.Add(IndexBlockEnum.EuropeDistrict2Banner, new EuropeDistrict2BannerBlock());
            _ListTemplateBlock.Add(IndexBlockEnum.EuropeDistrictLeftDown2Banner, new EuropeDistrictLeftDown2BannerBlock()); 
            //
            _ListTemplateBlock.Add(IndexBlockEnum.AustraliaNewZealandDistrictLeftUp, new AustraliaNewZealandDistrictLeftUpBlock());
            _ListTemplateBlock.Add(IndexBlockEnum.AustraliaNewZealandDistrict2Banner, new AustraliaNewZealandDistrict2BannerBlock());
            _ListTemplateBlock.Add(IndexBlockEnum.AustraliaNewZealandDistrictRightDown4Banner, new AustraliaNewZealandDistrictRightDown4BannerBlock());
            //
            _ListTemplateBlock.Add(IndexBlockEnum.MilkDistrictLeftUp, new MilkDistrictLeftUpBlock());
            _ListTemplateBlock.Add(IndexBlockEnum.MilkDistrict2Banner, new MilkDistrict2BannerBlock());
            _ListTemplateBlock.Add(IndexBlockEnum.MilkDistrictLeftDown2Banner, new MilkDistrictLeftDown2BannerBlock());
            //
            _ListTemplateBlock.Add(IndexBlockEnum.NewArrivalDistrictLeftUp, new NewArrivalDistrictLeftUpBlock());
            _ListTemplateBlock.Add(IndexBlockEnum.NewArrivalDistrict2Banner, new NewArrivalDistrict2BannerBlock());
            _ListTemplateBlock.Add(IndexBlockEnum.NewArrivalDistrictRightDown4Banner, new NewArrivalDistrictRightDown4BannerBlock());
            //
            _ListTemplateBlock.Add(IndexBlockEnum.ShoppingGuide, new ShoppingGuideBlock());
            //
            _ListTemplateBlock.Add(IndexBlockEnum.HotTag, new HotTagBlock());
            //
            _ListTemplateBlock.Add(IndexBlockEnum.PopularProducts, new PopularProductsBlock());
            //
            _ListTemplateBlock.Add(IndexBlockEnum.CommonCategoryLevel1,new CommonCategoryLevel1Block());
            _ListTemplateBlock.Add(IndexBlockEnum.CommonCategoryLevel2, new CommonCategoryLevel2Block());
            _ListTemplateBlock.Add(IndexBlockEnum.CommonCategoryBrand, new CommonCategoryBrandBlock());
            //
            _ListTemplateBlock.Add(IndexBlockEnum.ShareLeft, new ShareLeftBlock());
            _ListTemplateBlock.Add(IndexBlockEnum.ShareMiddle, new ShareMiddleBlock());
            _ListTemplateBlock.Add(IndexBlockEnum.ShareRightImage, new ShareRightImageBlock());
            _ListTemplateBlock.Add(IndexBlockEnum.ShareRightName, new ShareRightNameBlock());
            _ListTemplateBlock.Add(IndexBlockEnum.ShareRightNameNewUser, new ShareRightNameNewUserBlock());
            _ListTemplateBlock.Add(IndexBlockEnum.ShareRightNamePingTuan, new ShareRightNamePingTuanBlock());
        }

        public override string ViewUrl
        {
            get
            {
                return "/Shared/Home818PreView"; 
            }
        }
        public override string EditViewUrl
        {
            get
            {
                return "/Admin/CMSAdmin/VisualPcIndex";
            }
            set
            {
                base.EditViewUrl = value;
            }
        }
    }
}
