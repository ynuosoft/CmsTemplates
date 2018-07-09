using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymatou.StaticContent.DataModel.Template.WapIndex
{
    /// <summary>
    /// 
    /// </summary>
    public class WapIndexTemplate : ITemplate
    {
        public override TemplateEnum TemplateID
        {
            get { return TemplateEnum.WapIndexTemplate; }
        }

        public override string TemplateName
        {
            get { return "Wap首页模板"; }
        }
        private IDictionary<int, IBlock> _ListTemplateBlock;
        public override IDictionary<int, IBlock> ListTemplateBlock
        {
            get { return _ListTemplateBlock; }
        }
        public override void AddTemplateBlock()
        {
            _ListTemplateBlock = new Dictionary<int, IBlock>();

            _ListTemplateBlock.Add(WapIndexBlockEnum.TopBanner, new TopBannerBlock());
            _ListTemplateBlock.Add(WapIndexBlockEnum.PhoneExclusive, new PhoneExclusiveBlock());
            _ListTemplateBlock.Add(WapIndexBlockEnum.EveryDayTuan3, new EveryDayTuan3Block());
            _ListTemplateBlock.Add(WapIndexBlockEnum.EveryDayTuan4, new EveryDayTuan4Block());
            //_ListTemplateBlock.Add(WapIndexBlockEnum.EveryDayTuan5, new EveryDayTuan5Block());
            _ListTemplateBlock.Add(WapIndexBlockEnum.ThreeLevelCategoryTop9, new ThreeLevelCategoryTop9Block());

        }
        //预览URL
        public override string ViewUrl
        {
            get 
            { 
                return "/Home/Index818Preview"; 
            }  
        }

        //可视化编辑URL
        public override string EditViewUrl
        {
            get
            {
                return "/Admin/WapHomePageForEdit";
            }
            set
            {
                base.EditViewUrl = value;
            }
        }
    }
}
