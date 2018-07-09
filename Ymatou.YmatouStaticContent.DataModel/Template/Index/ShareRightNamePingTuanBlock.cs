using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
   public class ShareRightNamePingTuanBlock:ShareRightNameBlock
    {
       public override int BlcokID
       {
           get
           {
               return IndexBlockEnum.ShareRightNamePingTuan;
           }
       }
       public override string BlockName
       {
           get
           {
               return "分享互动-右边拼团";
           }
       }
    }
}
