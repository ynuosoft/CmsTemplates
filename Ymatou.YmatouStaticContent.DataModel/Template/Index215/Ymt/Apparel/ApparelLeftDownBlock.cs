using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Apparel
{
    /// <summary>
    /// 服饰鞋包左下商品图片
    /// </summary>
    public class ApparelLeftDownBlock : IBlock
    {
        /// <summary>
        /// 
        /// </summary>
        public override int BlcokID
        {
            get { return YmtBlocksEnums.ApparelLeftDownBlock; }
        }

        /// <summary>
        /// 
        /// </summary>
        public override string BlockName
        {
            get { return "服饰鞋包左下商品图片"; }
        }

        /// <summary>
        /// 
        /// </summary>
        public override Type ViewModel
        {
            get { return typeof(ApparelLeftDownBlockItemViewModel); }
        }
    }

    public class ApparelLeftDownBlockItem : IBlockItem<ApparelLeftDownBlockItemViewModel>
    {

    }

    public class ApparelLeftDownBlockItemViewModel : IBlockItemViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName(CNName = "商品图片地址", Group = "左下商品", Tips = "图片尺寸：279×148")]
        public string LeftDownImg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DisplayName(CNName = "商品图片链接", Group = "左下商品", InputFormat = DisplayNameInputFormat.Link)]
        public string LeftDownLink { get; set; }
    }
}
