using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.App.AppTheGlobalHit
{
   public class AppTheGlobalHitTemplate:ITemplate
    {
        public override TemplateEnum TemplateID
        {
            get { return TemplateEnum.AppTheGlobalHit; }
        }

        public override string TemplateName
        {
            get { return "App-全球热门"; }
        }

        public override string ViewUrl
        {
            get { return string.Empty; }
        }

        private Dictionary<int, IBlock> _ListTemplateBlock;
        public override IDictionary<int, IBlock> ListTemplateBlock
        {
            get { return _ListTemplateBlock; }
        }

        public override void AddTemplateBlock()
        {
            _ListTemplateBlock = new Dictionary<int, IBlock>();

            _ListTemplateBlock.Add(AppTheGlobalHitBlockEnum.TopBannerBlock, new TopBannerBlock());
        }
    }
}
