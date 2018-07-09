using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Apparel
{
    public class ApparelMiddleBlock : IBlock
    {
        /// <summary>
        /// 服饰鞋包中间两个商品
        /// </summary>
        public override int BlcokID
        {
            get { return YmtBlocksEnums.ApparelMiddleBlock; }
        }

        /// <summary>
        /// 
        /// </summary>
        public override string BlockName
        {
            get { return "服饰鞋包中间两个商品"; }
        }

        /// <summary>
        /// 
        /// </summary>
        public override Type ViewModel
        {
            get { return typeof(ApparelMiddleBlockItemViewModel); }
        }
    }

    public class ApparelMiddleBlockItem : IBlockItem<ApparelMiddleBlockItemViewModel>
    {

    }

    public class ApparelMiddleBlockItemViewModel : IBlockItemViewModel
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
