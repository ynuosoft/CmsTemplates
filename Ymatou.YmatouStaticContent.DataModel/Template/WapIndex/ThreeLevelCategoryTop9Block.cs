using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymatou.StaticContent.DataModel.Template.WapIndex
{
    public class ThreeLevelCategoryTop9Block : IBlock
    {
        public override int BlcokID
        {
            get { return WapIndexBlockEnum.ThreeLevelCategoryTop9; }
        }

        public override string BlockName
        {
            get { return "三级分类Top9"; }
        }

        public override Type ViewModel
        {
            get { return typeof(ThreeLevelCategoryTop9BlockItemViewModel); }
        }
    }
    public class ThreeLevelCategoryTop9BlockItem : IBlockItem<ThreeLevelCategoryTop9BlockItemViewModel>
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public class ThreeLevelCategoryTop9BlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName="名称",MaxLength=5)]
        public string Name { get; set; }

        [DisplayName(CNName = "链接地址")]
        public string Link { get; set; }
    }
}
