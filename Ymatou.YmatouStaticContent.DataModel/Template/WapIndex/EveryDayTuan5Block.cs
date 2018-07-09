using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymatou.StaticContent.DataModel.Template.WapIndex
{
    public class EveryDayTuan5Block : EveryDayTuan4Block
    {
        public override int BlcokID
        {
            get
            {
                return WapIndexBlockEnum.EveryDayTuan5;
            }
        }

        public override string BlockName
        {
            get
            {
                return "每日团5";
            }
        }
    }
}
