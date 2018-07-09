using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.M2C.Baby
{
    /// <summary>
    /// 母婴馆左下两个小图商品
    /// </summary>
    public class BabyLeftDownBlock : IBlock
    {

        public override int BlcokID
        {
            get { return M2CBlocksEnums.BabyLeftDownBlock; }
        }

        public override string BlockName
        {
            get { return "母婴馆左下两个小图商品"; }
        }

        public override Type ViewModel
        {
            get { return typeof(BabyLeftDownBlockItemViewModel); }
        }
    }

    public class BabyLeftDownBlockItem : IBlockItem<BabyLeftDownBlockItemViewModel>
    {
    }

    public class BabyLeftDownBlockItemViewModel : IBlockItemViewModel
    {        
        [DisplayName(CNName = "图片1",  Tips = "图片尺寸：120×120")]
        public string ImgUrl { get; set; }

        [DisplayName(CNName = "文字1前面部分", MaxLength = 10)]
        public string TitlePre { get; set; }

        [DisplayName(CNName = "文字1中间红色部分", MaxLength = 10)]
        public string TitleMiddle { get; set; }

        [DisplayName(CNName = "文字1右边部分", MaxLength = 10)]
        public string TitleRight { get; set; }

        [DisplayName(CNName = "图片链接1", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl { get; set; }        
    }
}
