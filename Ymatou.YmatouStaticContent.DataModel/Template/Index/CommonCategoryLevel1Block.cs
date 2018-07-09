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
    public class CommonCategoryLevel1Block : IBlock
    {
        public override int BlcokID
        {
            get { return IndexBlockEnum.CommonCategoryLevel1; }
        }
        public override string BlockName
        {
            get { return "常用分类-1级分类"; }
        }
        public override Type ViewModel
        {
            get { return typeof(CommonCategoryLevel1BlockItemViewModel); }
        }
    }
    public class CommonCategoryLevel1BlockItem : IBlockItem<CommonCategoryLevel1BlockItemViewModel>
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public class CommonCategoryLevel1BlockItemViewModel : IBlockItemViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [DisplayName(CNName = "左上分类", Group = "左上分类", MaxLength = 6)]
        public string LeftUpCategory1 { get; set; }
        [DisplayName(CNName = "左上分类链接", Group = "左上分类")]
        public string LeftUpLink1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName(CNName = "右上分类", Group = "右上分类", MaxLength = 6)]
        public string RightUpCategory1 { get; set; }
        [DisplayName(CNName = "右上分类链接", Group = "右上分类")]
        public string RightUpLink1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName(CNName = "左下分类", Group = "左下分类", MaxLength = 6)]
        public string LeftDownCategory1 { get; set; }
        [DisplayName(CNName = "左下分类链接", Group = "左下分类")]
        public string LeftDownLink1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DisplayName(CNName = "右下分类", Group = "右下分类", MaxLength = 6)]
        public string RightDownCategory1 { get; set; }
        [DisplayName(CNName = "右下分类链接", Group = "右下分类")]
        public string RightDownLink1 { get; set; }

       
    }
}
