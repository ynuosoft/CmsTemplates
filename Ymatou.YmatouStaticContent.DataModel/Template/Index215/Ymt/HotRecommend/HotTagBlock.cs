using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.HotRecommend
{
    /// <summary>
    /// 热门标签
    /// </summary>
    public class HotTagBlock : IBlock
    {

        public override int BlcokID
        {
            get { return YmtBlocksEnums.HotTagBlock; }
        }

        public override string BlockName
        {
            get { return "热门标签"; }
        }

        public override Type ViewModel
        {
            get { return typeof(HotTagBlockItemViewModel); }
        }
    }

    public class HotTagBlockItem : IBlockItem<HotTagBlockItemViewModel>
    {
    }

    public class HotTagBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "标签名称")]
        public string TagName { get; set; }
        [DisplayName(CNName = "显示等级", Tips = "输入值1,2,3 ;每行6个，1级2个，2级2个，3级2个，不同级别对应不同字号和颜色")]
        public int Level { get; set; }
        [DisplayName(CNName = "标签链接")]
        public string LinkUrl { get; set; }
    }
}
