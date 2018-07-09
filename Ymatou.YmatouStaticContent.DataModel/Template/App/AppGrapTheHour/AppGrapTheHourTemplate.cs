using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.App.AppGrapTheHour
{
    /// <summary>
    /// 
    /// </summary>
    public class AppGrapTheHourTemplate : ITemplate
    {

        public override TemplateEnum TemplateID
        {
            get { return TemplateEnum.AppGrapTheHour; }
        }
        public override string TemplateName
        {
            get { return "App-整点抢"; }
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

            _ListTemplateBlock.Add(AppGrapTheHourBlockEnum.TopBannerBlock, new TopBannerBlock());
        }
    }
}
