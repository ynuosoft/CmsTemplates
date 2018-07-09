using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymatou.StaticContent.DataModel.Template.OverSeaTuan
{
    public class OverSeaTuanTemplate : ITemplate
    {
        private IDictionary<int, IBlock> _ListTemplateBlock;

        public override TemplateEnum TemplateID
        {
            get { return TemplateEnum.OverSeaTuanTemplate; }
        }

        public override string TemplateName
        {
            get { return "团购海外团模板"; }
        }
         
        public override IDictionary<int, IBlock> ListTemplateBlock
        {
            get { return _ListTemplateBlock; }
        }

        public override string ViewUrl
        {
            get { return string.Empty; }
        }

        public override void AddTemplateBlock()
        {
            _ListTemplateBlock = new Dictionary<int, IBlock>();

            _ListTemplateBlock.Add(OverSearTuanBlockEnum.TopLeftBannerBlock, new TopLeftBannerBlock());
            _ListTemplateBlock.Add(OverSearTuanBlockEnum.HotSalesBlcok, new HotSalesBlcok());
            _ListTemplateBlock.Add(OverSearTuanBlockEnum.BottomWillComeBlock, new BottomWillComeBlock());
        }
 
    }
}
