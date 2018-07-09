using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    public class AustraliaNewZealandDistrictLeftUpBlock : AmericaDistrictLeftUpBlock
    {

        public override int BlcokID
        {
            get { return IndexBlockEnum.AustraliaNewZealandDistrictLeftUp; }
        }

        public override string BlockName
        {
            get { return "澳新馆-左上文字"; }
        }
       
    }

}
