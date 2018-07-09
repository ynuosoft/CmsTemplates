using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    public class AmericaDistrictRightMiddleDown4BannerBlock : IBlock
    {

        public override int BlcokID
        {
            get { return IndexBlockEnum.AmericaDistrictRightMiddleDown4Banner; }
        }

        public override string BlockName
        {
            get { return "美国馆-右中下4个Banner"; }
        }

        public override Type ViewModel
        {
            get { return typeof(AmericaDistrictRightMiddleDown4BannerBlockItemViewModel); }
        }
    }

    public class AmericaDistrictRightMiddleDown4BannerBlockItem : IBlockItem<AmericaDistrictRightMiddleDown4BannerBlockItemViewModel>
    {

    }

    public class AmericaDistrictRightMiddleDown4BannerBlockItemViewModel : IBlockItemViewModel
    {
       
        /// <summary>
        /// 图片1
        /// </summary>
        [DisplayName(CNName = "图片1", Group = "图片文字1", Tips = "图片尺寸：120×120")]
        public string ImgUrl1 { get; set; }
        [DisplayName(CNName = "文字1前面部分", Group = "图片文字1",MaxLength=10)]
        public string Title1Pre { get; set; }
        [DisplayName(CNName = "文字1中间红色部分", Group = "图片文字1", MaxLength = 10)]
        public string Title1Middle { get; set; }
        [DisplayName(CNName = "文字1右边部分", Group = "图片文字1", MaxLength = 10)]
        public string Title1Right { get; set; }
        [DisplayName(CNName = "图片链接1", Group = "图片文字1", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl1 { get; set; }
        /// <summary>
        /// 
        /// </summary>

        [DisplayName(CNName = "图片2", Group = "图片文字2", Tips = "图片尺寸：120×120")]
        public string ImgUrl2 { get; set; }
        [DisplayName(CNName = "文字2前面部分", Group = "图片文字2", MaxLength = 10)]
        public string Title2Pre { get; set; }
        [DisplayName(CNName = "文字2中间红色部分", Group = "图片文字2", MaxLength = 10)]
        public string Title2Middle { get; set; }
        [DisplayName(CNName = "文字2右边部分", Group = "图片文字2", MaxLength = 10)]
        public string Title2Right { get; set; }
        [DisplayName(CNName = "图片链接2", Group = "图片文字2", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DisplayName(CNName = "图片3", Group = "图片文字3", Tips = "图片尺寸：120×120")]
        public string ImgUrl3 { get; set; }
        [DisplayName(CNName = "文字3前面部分", Group = "图片文字3", MaxLength = 10)]
        public string Title3Pre { get; set; }
        [DisplayName(CNName = "文字3中间红色部分", Group = "图片文字3", MaxLength = 10)]
        public string Title3Middle { get; set; }
        [DisplayName(CNName = "文字3右边部分", Group = "图片文字3", MaxLength = 10)]
        public string Title3Right { get; set; }
        [DisplayName(CNName = "图片链接3", Group = "图片文字3", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DisplayName(CNName = "图片4", Group = "图片文字4", Tips = "图片尺寸：120×120")]
        public string ImgUrl4 { get; set; }
        [DisplayName(CNName = "文字4前面部分", Group = "图片文字4", MaxLength = 10)]
        public string Title4Pre { get; set; }
        [DisplayName(CNName = "文字4中间红色部分", Group = "图片文字4", MaxLength = 10)]
        public string Title4Middle { get; set; }
        [DisplayName(CNName = "文字4右边部分", Group = "图片文字4", MaxLength = 10)]
        public string Title4Right { get; set; }
        [DisplayName(CNName = "图片链接4", Group = "图片文字4", InputFormat = DisplayNameInputFormat.Link)]
        public string LinkUrl4 { get; set; }

       
    }
}
