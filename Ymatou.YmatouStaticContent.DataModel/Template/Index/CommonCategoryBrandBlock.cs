using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    public class CommonCategoryBrandBlock : IBlock
    {

        public override int BlcokID
        {
            get { return IndexBlockEnum.CommonCategoryBrand; }
        }

        public override string BlockName
        {
            get { return "常用分类-品牌"; }
        }

        public override Type ViewModel
        {
            get { return typeof(CommonCategoryBrandBlockItemViewModel); }
        }
    }

    public class CommonCategoryBrandBlockItem : IBlockItem<CommonCategoryBrandBlockItemViewModel>
    {

    }

    public class CommonCategoryBrandBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "品牌图片", Tips = "图片尺寸：90×50", InputFormat = DisplayNameInputFormat.Image)]
        public string ImgUrl { get; set; }
        [DisplayName(CNName = "品牌图片链接",InputFormat=DisplayNameInputFormat.Link)]
        public string LinkUrl { get; set; }
        [DisplayName(CNName = "品牌显示位置", Tips = "左上：1，右上：2，左下：3，右下:4，",InputFormat=DisplayNameInputFormat.Int)]
        public int Postion { get; set; }
    }

}
