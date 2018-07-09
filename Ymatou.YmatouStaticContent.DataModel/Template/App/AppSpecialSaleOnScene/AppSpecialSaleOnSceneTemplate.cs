using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.App.AppSpecialSaleOnScene
{
    /// <summary>
    /// 
    /// </summary>
    public class AppSpecialSaleOnSceneTemplate : ITemplate
    {

        public override TemplateEnum TemplateID
        {
            get { return TemplateEnum.AppSpecialSaleOnScene; }
        }
        public override string TemplateName
        {
            get { return "App-特卖现场"; }
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

            _ListTemplateBlock.Add(AppSpecialSaleOnSceneBlockEnum.MiddleBannerBlock, new MiddleBannerBlock());
        }
    }
}
