using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index
{
    public class EuropeDistrictLeftUpBlock : AmericaDistrictLeftUpBlock
    {
        public override int BlcokID
        {
            get
            {
                return IndexBlockEnum.EuropeDistrictLeftUp;
            }
        }
        public override string BlockName
        {
            get
            {
                return "欧洲馆-左上文字";
            }
        }

    }
}
