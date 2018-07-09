using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    public class PopularProductsBlock : IBlock
    {

        public override int BlcokID
        {
            get { return IndexBlockEnum.PopularProducts; }
        }

        public override string BlockName
        {
            get { return "人气商品"; }
        }

        public override Type ViewModel
        {
            get { return typeof(PopularProductsBlockItemViewModel); }
        }

        public override string ExternalLink
        {
            get
            {
                return "/Admin/CMSAdmin/AddPopularProducts";
            }
            set
            {
                base.ExternalLink = value;
            }
        }
    }

    public class PopularProductsBlockItem : IBlockItem<PopularProductsBlockItemViewModel>
    {

    }
    public class PopularProductsBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "商品图片", Tips = "图片尺寸：120×120")]
        public string ImgUrl { get; set; }
        [DisplayName(CNName = "商品标题", MaxLength = 24,Tips="输入24个字符以内")]
        public string Title { get; set; }
        [DisplayName(CNName = "商品最低价")]
        public string LowPrice { get; set; }
        [DisplayName(CNName = "商品链接")]
        public string LinkUrl { get; set; }
    }
}
