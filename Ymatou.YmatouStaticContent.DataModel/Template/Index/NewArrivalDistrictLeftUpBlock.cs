using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    public class NewArrivalDistrictLeftUpBlock : AmericaDistrictLeftUpBlock
    {
        public override int BlcokID
        {
            get
            {
                return IndexBlockEnum.NewArrivalDistrictLeftUp;
            }
        }

        public override string BlockName
        {
            get
            {
                return "新品馆-左上文字";
            }
        }
    }
}
