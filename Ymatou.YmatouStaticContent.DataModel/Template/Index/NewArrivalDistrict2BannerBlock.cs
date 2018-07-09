using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    public class NewArrivalDistrict2BannerBlock : AustraliaNewZealandDistrict2BannerBlock
    {
        public override int BlcokID
        {
            get
            {
                return IndexBlockEnum.NewArrivalDistrict2Banner;
            }
        }
        public override string BlockName
        {
            get
            {
                return "新品馆-左下Banner、右上Banner";
            }
        }
    }
}
