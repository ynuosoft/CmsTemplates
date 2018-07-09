using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Maternity
{
    /// <summary>
    /// 母婴右边大图商品
    /// </summary>
    public class MaternityRightBlock : IBlock
    {

        public override int BlcokID
        {
            get { return YmtBlocksEnums.MaternityRightBlock; }
        }

        public override string BlockName
        {
            get { return "母婴右边大图商品"; }
        }

        public override Type ViewModel
        {
            get { return typeof(MaternityRightBlockItemViewModel); }
        }
    }

    public class MaternityRightBlockItem : IBlockItem<MaternityRightBlockItemViewModel>
    {
    }

    public class MaternityRightBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "商品图片地址", Group = "右边大商品", Tips = "图片尺寸：265×305")]
        public string RightImg { get; set; }
        [DisplayName(CNName = "商品图片链接", Group = "右边大商品", InputFormat = DisplayNameInputFormat.Link)]
        public string RightLink { get; set; }
    }
}
