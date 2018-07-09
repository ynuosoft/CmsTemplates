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
    public class ShoppingGuideBlock : IBlock
    {
        public override int BlcokID
        {
            get { return IndexBlockEnum.ShoppingGuide; }
        }
        public override string BlockName
        {
            get { return "购物指南"; }
        }

        public override Type ViewModel
        {
            get { return typeof(ShoppingGuideBlcokItemViewModel); }
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class ShoppingGuideBlcokItem : IBlockItem<ShoppingGuideBlcokItemViewModel>
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public class ShoppingGuideBlcokItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "旗标", MaxLength = 2)]
        public string FlagName { get; set; }
        [DisplayName(CNName = "导购信息", MaxLength = 20)]
        public string Title { get; set; }
        [DisplayName(CNName = "导购信息图片", InputFormat = DisplayNameInputFormat.Image, Tips = "图片尺寸：255×170")]
        public string ImgUrl { get; set; }
        [DisplayName(CNName = "导购信息链接", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl { get; set; }
    }
}
