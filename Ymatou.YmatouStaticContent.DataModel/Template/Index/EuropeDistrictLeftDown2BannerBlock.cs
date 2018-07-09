using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    public class EuropeDistrictLeftDown2BannerBlock : IBlock
    {

        public override int BlcokID
        {
            get { return IndexBlockEnum.EuropeDistrictLeftDown2Banner; }
        }

        public override string BlockName
        {
            get { return " 欧洲馆-左下2个Banner"; }
        }

        public override Type ViewModel
        {
            get { return typeof(EuropeDistrictLeftDown2BannerBlockItemViewModel); }
        }
    }

    public class EuropeDistrictLeftDown2BannerBlockItem : IBlockItem<EuropeDistrictLeftDown2BannerBlockItemViewModel>
    {

    }
    public class EuropeDistrictLeftDown2BannerBlockItemViewModel : IBlockItemViewModel
    {
       
        /// <summary>
        /// 
        /// </summary>
        [DisplayName(CNName = "图片地址1",Group="图片文字1")]
        public string ImgUrl1 { get; set; }

        [DisplayName(CNName = "左边文字1", Group = "图片文字1", MaxLength = 10)]
        public string TitleLeft1 { get; set; }

        [DisplayName(CNName = "中间文字1", Group = "图片文字1", MaxLength = 10)]
        public string TitleMiddle1 { get; set; }
        [DisplayName(CNName = "右边文字1", Group = "图片文字1", MaxLength = 10)]
        public string TitleRight1 { get; set; }
        [DisplayName(CNName = "链接地址1", Group = "图片文字1", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DisplayName(CNName = "图片地址2", Group = "图片文字2")]
        public string ImgUrl2 { get; set; }

        [DisplayName(CNName = "左边文字2", Group = "图片文字2", MaxLength = 10)]
        public string TitleLeft2 { get; set; }

        [DisplayName(CNName = "中间文字2", Group = "图片文字2", MaxLength = 10)]
        public string TitleMiddle2 { get; set; }
        [DisplayName(CNName = "右边文字2", Group = "图片文字2", MaxLength = 10)]
        public string TitleRight2 { get; set; }
        [DisplayName(CNName = "链接地址2", Group = "图片文字2", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl2 { get; set; }

        
    }
}
