using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    public class CommonCategoryLevel2Block : IBlock
    {
        public override int BlcokID
        {
            get { return IndexBlockEnum.CommonCategoryLevel2; }
        }

        public override string BlockName
        {
            get { return "常用分类-2级分类"; }
        }

        public override Type ViewModel
        {
            get { return typeof(CommonCategoryLevel2BlockItemViewModel); }
        }
    }
    public class CommonCategoryLevel2BlockItem : IBlockItem<CommonCategoryLevel2BlockItemViewModel>
    {

    }

    public class CommonCategoryLevel2BlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "2级分类名称", MaxLength = 5)]
        public string CategoryName { get; set; }
        [DisplayName(CNName = "分类链接")]
        public string LinkUrl { get; set; }
        [DisplayName(CNName = "分类显示位置", Tips = "左上：1，右上：2，左下：3，右下:4，")]
        public int Postion { get; set; }
    }
}
