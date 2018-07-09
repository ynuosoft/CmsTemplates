using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    public class ShareRightNameBlock : IBlock
    {
        /// <summary>
        /// 
        /// </summary>
        public override int BlcokID
        {
            get { return IndexBlockEnum.ShareRightName; }
        }
        /// <summary>
        /// 
        /// </summary>
        public override string BlockName
        {
            get { return "分享互动-右下机动文字位"; }
        }
        /// <summary>
        /// 
        /// </summary>
        public override Type ViewModel
        {
            get { return typeof(ShareRightNameBlockItemViewModel); }
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class ShareRightNameBlockItem : IBlockItem<ShareRightNameBlockItemViewModel>
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public class ShareRightNameBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "文字标题")]
        public string Title { get; set; }
        [DisplayName(CNName = "链接地址")]
        public string LinkUrl { get; set; }
    }
}
