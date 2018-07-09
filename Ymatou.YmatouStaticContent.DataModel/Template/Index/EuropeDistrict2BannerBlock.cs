using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
   public class EuropeDistrict2BannerBlock:IBlock
    {
        public override int BlcokID
        {
            get { return IndexBlockEnum.EuropeDistrict2Banner; }
        }

        public override string BlockName
        {
            get { return "欧洲馆-左中Banner、右Banner"; }
        }

        public override Type ViewModel
        {
            get { return  typeof(EuropeDistrict2BannerBlockItemViewModel); }
        }
    }

   public class EuropeDistrict2BannerBlockItem : IBlockItem<EuropeDistrict2BannerBlockItemViewModel>
    {

    }
   public class EuropeDistrict2BannerBlockItemViewModel : IBlockItemViewModel
   {
       [DisplayName(CNName = "左中Banner", Group = "左中Banner", Tips = "图片尺寸：275×155")]
       public string LeftMiddleImgUrl { get; set; }

       [DisplayName(CNName = "左中Banner链接", Group = "左中Banner")]
       public string LeftMiddleLinkUrl { get; set; }


       [DisplayName(CNName = "右Banner", Group = "右Banner", Tips = "图片尺寸：275×480")]
       public string RightImgUrl { get; set; }

       [DisplayName(CNName = "右Banner链接", Group = "右Banner")]
       public string RightLinkUrl { get; set; }
   }
}
