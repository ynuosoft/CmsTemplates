using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
   public class MilkDistrictLeftUpBlock:EuropeDistrictLeftUpBlock
    {
       public override int BlcokID
       {
           get
           {
               return IndexBlockEnum.MilkDistrictLeftUp;
           }
       }

       public override string BlockName
       {
           get
           {
               return "奶粉馆-左上文字";
           }
       }
    }
}
