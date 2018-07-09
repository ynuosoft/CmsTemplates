using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
   public class MilkDistrict2BannerBlock:EuropeDistrict2BannerBlock
    {
       public override int BlcokID
       {
           get
           {
               return IndexBlockEnum.MilkDistrict2Banner;
           }
       }

       public override string BlockName
       {
           get
           {
               return "奶粉馆-左中Banner、右Banner";
           }
       }
    }
}
