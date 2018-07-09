using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Tuan
{
    /// <summary>
    /// 每日团
    /// </summary>
    public class EverydayTuanBlock : IBlock
    {

        public override int BlcokID
        {
            get { return YmtBlocksEnums.EverydayTuanBlock; }
        }

        public override string BlockName
        {
            get { return "每日团"; }
        }

        public override Type ViewModel
        {
            get { return typeof(EverydayTuanBlockItemViewModel); }
        }

        public override string ExternalLink
        {
            get
            {
                return "/Admin/CMSAdmin/AddYmtEevryTuan";
            }
            set
            {
                base.ExternalLink = value;
            }
        }
    }

    public class EverydayTuanBlockItem : IBlockItem<EverydayTuanBlockItemViewModel>
    {

    }

    public class EverydayTuanBlockItemViewModel : Index.EverydayTuanBlockItemViewModel
    {        
    }
}
