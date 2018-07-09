using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ymatou.StaticContent.DataModel.Template.App.AppSpecialSaleOnScene;


namespace Ymatou.StaticContent.DataModel
{
    using Ymatou.StaticContent.DataModel.Template.App.AppEveryoneInTheAround;
    using Ymatou.StaticContent.DataModel.Template.App.AppGrapTheHour;
    using Ymatou.StaticContent.DataModel.Template.App.AppTheGlobalHit;
    using Ymatou.StaticContent.DataModel.Template.CountryPavilion.AmericanPavilion;
    using Ymatou.StaticContent.DataModel.Template.CountryPavilion.ANZPavilion;
    using Ymatou.StaticContent.DataModel.Template.CountryPavilion.AsianPavilion;
    using Ymatou.StaticContent.DataModel.Template.CountryPavilion.EuropePavilion;
    using Ymatou.StaticContent.DataModel.Template.Index;
    using Ymatou.StaticContent.DataModel.Template.Index215.M2C;
    using Ymatou.StaticContent.DataModel.Template.Index215.Ymt;
    using Ymatou.StaticContent.DataModel.Template.OverSeaTuan;
    using Ymatou.StaticContent.DataModel.Template.WapIndex;
    /// <summary>
    /// 模板管理类
    /// </summary>
    public class TemplateManger
    {
        private TemplateManger()
        {
 
        }
        private  static Dictionary<TemplateEnum, ITemplate> _DicTemplate ;
        /// <summary>
        /// 
        /// </summary>
        public  static Dictionary<TemplateEnum, ITemplate> DicTemplate {
            get { return _DicTemplate; }
        }
        /// <summary>
        /// 
        /// </summary>
        static TemplateManger()
        {
            _DicTemplate = new Dictionary<TemplateEnum, ITemplate>();

            

            #region //pc
            DicTemplate.Add(TemplateEnum.PcIndexTemplate, new PcIndexTemplate());
            DicTemplate.Add(TemplateEnum.WapIndexTemplate, new WapIndexTemplate());
            //DicTemplate.Add(TemplateEnum.OverSeaTuanTemplate, new OverSeaTuanTemplate());
            DicTemplate.Add(TemplateEnum.AmericanPavilionTemplate, new AmericanPavilionTemplate());
            DicTemplate.Add(TemplateEnum.EuropePavilionTemplate, new EuropePavilionTemplate());
            DicTemplate.Add(TemplateEnum.ANZPavilionTemplate, new ANZPavilionTemplate());
            DicTemplate.Add(TemplateEnum.AsianPavilionTemplate, new AsianPavilionTemplate());
            #endregion 
            #region //app
            DicTemplate.Add(TemplateEnum.AppGrapTheHour, new AppGrapTheHourTemplate());
            DicTemplate.Add(TemplateEnum.AppTheGlobalHit, new AppTheGlobalHitTemplate());
            DicTemplate.Add(TemplateEnum.AppSpecialSaleOnScene, new AppSpecialSaleOnSceneTemplate());
            DicTemplate.Add(TemplateEnum.AppEveryoneInTheAround, new AppEveryoneInTheAroundTemplate());
          
            #endregion 

            #region //215

            DicTemplate.Add(TemplateEnum.NewIndex215M2CTemplate, new M2CTemplate());
            DicTemplate.Add(TemplateEnum.NewIndex215YMTTemplate, new YmtTemplate());

            #endregion 
          

        }

    }
}
