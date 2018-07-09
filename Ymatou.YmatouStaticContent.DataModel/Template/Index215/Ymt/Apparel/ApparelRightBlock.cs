using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Apparel
{
    /// <summary>
    /// 服饰鞋包右边大商品图
    /// </summary>
    public class ApparelRightBlock : IBlock
    {
        /// <summary>
        /// 
        /// </summary>
        public override int BlcokID
        {
            get { return YmtBlocksEnums.ApparelRightBlock; }
        }

        /// <summary>
        /// 
        /// </summary>
        public override string BlockName
        {
            get { return "服饰鞋包右边大商品图"; }
        }

        /// <summary>
        /// 
        /// </summary>
        public override Type ViewModel
        {
            get { return typeof(ApparelRightBlockItemViewModel); }
        }
    }

    public class ApparelRightBlockItem : IBlockItem<ApparelRightBlockItemViewModel>
    {

    }

    public class ApparelRightBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "商品图片地址", Group = "右边大商品", Tips = "图片尺寸：265×305")]
        public string RightImg { get; set; }
        [DisplayName(CNName = "商品图片链接", Group = "右边大商品", InputFormat = DisplayNameInputFormat.Link)]
        public string RightLink { get; set; }
    }
}
