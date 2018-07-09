using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C.Tuan
{
    /// <summary>
    /// 每日团
    /// </summary>
    public class EverydayTuanBlock : Index.EverydayTuanBlock
    {
        public override int BlcokID
        {
            get
            {
                return M2CBlocksEnums.EverydayTuanBlock;
            }
        }

        public override string BlockName
        {
            get
            {
                return "每日团";
            }
        }
        public override string ExternalLink
        {
            get
            {
                return "/Admin/CMSAdmin/AddM2CEevryTuan";
            }
            set
            {
                base.ExternalLink = value;
            }
        }
        public override Type ViewModel
        {
            get
            {
                return typeof(EverydayTuanBlockItemViewModel);
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
