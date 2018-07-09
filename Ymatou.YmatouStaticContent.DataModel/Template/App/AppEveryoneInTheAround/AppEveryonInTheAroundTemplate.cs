using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.App.AppEveryoneInTheAround
{
    /// <summary>
    /// 大家都在逛 模板
    /// </summary>
    public class AppEveryoneInTheAroundTemplate : ITemplate
    {

        public override TemplateEnum TemplateID
        {
            get { return TemplateEnum.AppEveryoneInTheAround; }
        }
        public override string TemplateName
        {
            get { return "App-大家都在逛"; }
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

            _ListTemplateBlock.Add(AppEveryoneInTheAroundBlockEnum.MiddleBannerBlock, new MiddleBannerBlock());
        }
    }
}
