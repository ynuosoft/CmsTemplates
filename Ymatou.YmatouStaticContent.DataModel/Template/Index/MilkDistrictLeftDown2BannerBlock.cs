using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    public class MilkDistrictLeftDown2BannerBlock : EuropeDistrictLeftDown2BannerBlock
    {
        public override int BlcokID
        {
            get
            {
                return IndexBlockEnum.MilkDistrictLeftDown2Banner;
            }
        }

        public override string BlockName
        {
            get
            {
                return "奶粉馆-左下2个Banner";
            }
        }
    }
}
