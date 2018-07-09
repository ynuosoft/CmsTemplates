using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.OverSeaTuan
{
    public class BottomWillComeBlock : IBlock
    {
        public override int BlcokID
        {
            get { return (int)OverSearTuanBlockEnum.BottomWillComeBlock; }
        }

        public override string BlockName
        {
            get { return "即将上新模块"; }
        }

        public override Type ViewModel
        {
            get { return typeof(BottomWillComeBlockItemViewModel); }
        }
    }

    public class BottomWillComeBlockItem : IBlockItem<BottomWillComeBlockItemViewModel>
    {

    }

    public class BottomWillComeBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "活动图片URL地址")]
        public string PicUrl { get; set; }

        [DisplayName(CNName = "该活动开始时间")]
        public DateTime BeginTime { get; set; }
    }
}
