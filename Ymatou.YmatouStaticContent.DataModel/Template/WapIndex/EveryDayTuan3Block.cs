using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymatou.StaticContent.DataModel.Template.WapIndex
{
    /// <summary>
    /// 每日团3
    /// </summary>
    public class EveryDayTuan3Block : IBlock
    {

        public override int BlcokID
        {
            get { return WapIndexBlockEnum.EveryDayTuan3; }
        }

        public override string BlockName
        {
            get { return "每日团3"; }
        }

        public override Type ViewModel
        {
            get { return typeof(EveryDayTuan3BlockItemViewModel); }
        }
    }
    public class EveryDayTuan3BlockItem : IBlockItem<EveryDayTuan3BlockItemViewModel>
    {

    }
    public class EveryDayTuan3BlockItemViewModel : IBlockItemViewModel
    {
      
        [DisplayName(CNName = "副标题", Group = "标题",MaxLength=5)]
        public string SubTitle { get; set; }

        [DisplayName(CNName = "产品大图", Group = "产品大图")]
        public string ImgUrl1 { get; set; }
        [DisplayName(CNName = "产品大图链接", Group = "产品大图")]
        public string LinkUrl1 { get; set; }

      
    }
}
