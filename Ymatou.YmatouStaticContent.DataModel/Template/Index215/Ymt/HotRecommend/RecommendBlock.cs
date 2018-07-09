using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.HotRecommend
{
    /// <summary>
    /// 人气商品
    /// </summary>
    public class RecommendBlock : IBlock
    {

        public override int BlcokID
        {
            get { return YmtBlocksEnums.RecommendBlock; }
        }

        public override string BlockName
        {
            get { return "人气商品"; }
        }

        public override string ExternalLink
        {
            get
            {
                return "/Admin/CMSAdmin/AddYmtPopularProducts";
            }
            set
            {
                base.ExternalLink = value;
            }
        }

        public override Type ViewModel
        {
            get { return typeof(RecommendBlockItemViewModel); }
        }
    }

    public class RecommendBlockItem : IBlockItem<RecommendBlockItemViewModel>
    {

    }

    public class RecommendBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "商品图片", Tips = "图片尺寸：120×120")]
        public string ImgUrl { get; set; }
        [DisplayName(CNName = "商品标题", MaxLength = 20, Tips = "输入20个字符以内")]
        public string Title { get; set; }
        [DisplayName(CNName = "商品最低价")]
        public string LowPrice { get; set; }
        [DisplayName(CNName = "商品链接")]
        public string LinkUrl { get; set; }
    }
}
