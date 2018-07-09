using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Maternity
{
    /// <summary>
    /// 母婴中间两个商品
    /// </summary>
    public class MaternityMiddleBlock : IBlock
    {

        public override int BlcokID
        {
            get { return YmtBlocksEnums.MaternityMiddleBlock; }
        }

        public override string BlockName
        {
            get { return "母婴中间两个商品"; }
        }

        public override Type ViewModel
        {
            get { return typeof(MaternityMiddleBlockItemViewModel); }
        }
    }

    public class MaternityMiddleBlockItem : IBlockItem<MaternityMiddleBlockItemViewModel>
    {
    }

    public class MaternityMiddleBlockItemViewModel : IBlockItemViewModel
    {
        /// <summary>
        /// 商品1
        /// </summary>
        [DisplayName(CNName = "图片", Tips = "图片尺寸：120×120")]
        public string ImgUrl { get; set; }

        [DisplayName(CNName = "商品标题", MaxLength = 10)]
        public string Title { get; set; }

        [DisplayName(CNName = "商品价格", MaxLength = 10)]
        public string Price { get; set; }

        [DisplayName(CNName = "图片链接", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl { get; set; }        
    }
}
