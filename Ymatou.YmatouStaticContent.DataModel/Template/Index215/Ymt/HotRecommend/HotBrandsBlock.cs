using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.HotRecommend
{
    /// <summary>
    /// 热门品牌
    /// </summary>
    public class HotBrandsBlock : IBlock
    {
        public override int BlcokID
        {
            get { return YmtBlocksEnums.HotBrandsBlock; }
        }

        public override string BlockName
        {
            get { return "热门品牌"; }
        }

        public override Type ViewModel
        {
            get { return typeof(HotBrandsBlockItemViewModel); }
        }
    }

    public class HotBrandsBlockItem : IBlockItem<HotBrandsBlockItemViewModel>
    {

    }

    public class HotBrandsBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "品牌图片", InputFormat = DisplayNameInputFormat.Image, Tips = "图片尺寸：84×55")]
        public string ImgUrl { get; set; }

        [DisplayName(CNName = "品牌链接", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl { get; set; }

        [DisplayName(CNName = "品牌名称")]
        public string Title { get; set; }
    }


}
