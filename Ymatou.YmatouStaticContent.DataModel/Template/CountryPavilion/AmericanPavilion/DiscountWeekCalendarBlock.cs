using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.CountryPavilion.AmericanPavilion
{
    public class DiscountWeekCalendarBlock : IBlock
    {
        public override int BlcokID
        {
            get { return AmericanPavilionBlockEnum.DiscountWeekCalendarBlock; }
        }

        public override string BlockName
        {
            get { return "折扣周历"; }
        }

        public override Type ViewModel
        {
            get { return typeof(DiscountWeekCalendarBlockItemViewModel); }
        }
    }

    public class DiscountWeekCalendarBlockItem : IBlockItem<DiscountWeekCalendarBlockItemViewModel>
    {

    }

    public class DiscountWeekCalendarBlockItemViewModel : IBlockItemViewModel
    {
        [DisplayName(CNName = "年份", InputFormat = DisplayNameInputFormat.Year,Group="年份周")]
        public int Year { get; set; }

        [DisplayName(CNName = "月份", InputFormat = DisplayNameInputFormat.Month, Group = "年份周")]
        public int Month { get; set; }

        [DisplayName(CNName = "周次", InputFormat = DisplayNameInputFormat.Int, 
            Group = "年份周", Tips="'周'定义为'公历周日0:00:00为一周的开始，后一个周六23:59:59为一周的结束'，请判断周六在哪个月，就属于这个月的第几周。例如，8月2日在周六，则这周为8月的第一周。")]
        public int Week { get; set; }

        [DisplayName(CNName = "折扣一名称", Group = "折扣一", MaxLength = 6)]
        public string DisountName1 { get; set; }

        [DisplayName(CNName = "折扣一描述", Group = "折扣一", MaxLength = 6)]
        public string DiscountDescription1 { get; set; }

        [DisplayName(CNName = "折扣一信息链接地址", Group = "折扣一")]
        public string DisountLinkUrl1 { get; set; }

        [DisplayName(CNName = "折扣二名称", Group = "折扣二", MaxLength = 6)]
        public string DisountName2 { get; set; }

        [DisplayName(CNName = "折扣二描述", Group = "折扣二", MaxLength = 6)]
        public string DiscountDescription2 { get; set; }

        [DisplayName(CNName = "折扣二信息链接地址", Group = "折扣二")]
        public string DisountLinkUrl2 { get; set; }
    }
}
