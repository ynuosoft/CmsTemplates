using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    /// <summary>
    /// 
    /// </summary>
    public class HotTagBlock : IBlock
    {
        public override int BlcokID
        {
            get { return IndexBlockEnum.HotTag; }
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
    /// <summary>
    /// 
    /// </summary>
    public class HotTagBlockItem : IBlockItem<HotTagBlockItemViewModel>
    {

    }

    /// <summary>
    /// 
    /// </summary>
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
