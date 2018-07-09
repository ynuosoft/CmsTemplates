using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.WapIndex
{
    /// <summary>
    /// 
    /// </summary>
    public class PhoneExclusiveBlock : IBlock
    {
        public override int BlcokID
        {
            get { return WapIndexBlockEnum.PhoneExclusive; }
        }

        public override string BlockName
        {
            get { return "专享模块"; }
        }

        public override Type ViewModel
        {
            get { return typeof(PhoneExclusiveBlockItemViewModel); }
        }
    }
    public class PhoneExclusiveBlockItem : IBlockItem<PhoneExclusiveBlockItemViewModel>
    {

    }

    public class PhoneExclusiveBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "文字标题",MaxLength=4)]
        public string Title { get; set; }

        [DisplayName(CNName = "专享图片")]
        public string PicUrl { get; set; }

        [DisplayName(CNName = "链接地址")]
        public string LinkUrl { get; set; }
    }
}
