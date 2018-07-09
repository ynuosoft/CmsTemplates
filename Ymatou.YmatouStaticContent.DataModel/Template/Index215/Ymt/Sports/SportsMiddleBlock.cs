using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.Index215.Ymt.Sports
{
    /// <summary>
    /// 运动户外中间两个商品
    /// </summary>
    public class SportsMiddleBlock : IBlock
    {

        public override int BlcokID
        {
            get { return YmtBlocksEnums.SportsMiddleBlock; }
        }

        public override string BlockName
        {
            get { return "运动户外中间两个商品"; }
        }

        public override Type ViewModel
        {
            get { return typeof(SportsMiddleBlockItemViewModel); }
        }
    }

    public class SportsMiddleBlockItem : IBlockItem<SportsMiddleBlockItemViewModel>
    {
    }

    public class SportsMiddleBlockItemViewModel : Ymt.Apparel.ApparelMiddleBlockItemViewModel
    {  
    }
}
