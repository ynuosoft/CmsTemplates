using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ymatou.StaticContent.DataModel
{
    /// <summary>
    /// 模板枚举
    /// </summary>
    public enum TemplateEnum : int
    {
        /// <summary>
        /// 首页模板 1
        /// </summary>
        PcIndexTemplate = 1,
        /// <summary>
        /// 每日团购模板 2
        /// </summary>
        EveryTuanTemplate = 2,
        /// <summary>
        /// Wap首页 3
        /// </summary>
        WapIndexTemplate = 3,
        /// <summary>
        /// 海外团模板 50
        /// </summary>
        OverSeaTuanTemplate = 4,
        /// <summary>
        /// 美国馆模板 51
        /// </summary>
        AmericanPavilionTemplate = 51,
        /// <summary>
        /// 欧洲馆模板 52
        /// </summary>
        EuropePavilionTemplate = 52,
        /// <summary>
        /// 澳新馆模板 53
        /// </summary>
        ANZPavilionTemplate = 53,
        /// <summary>
        /// 亚洲馆模板 54
        /// </summary>
        AsianPavilionTemplate = 54,

        #region //app

        /// <summary>
        /// App-整点抢
        /// </summary>
        AppGrapTheHour=60,
        /// <summary>
        /// App-全球热卖
        /// </summary>
        AppTheGlobalHit= 61,
        /// <summary>
        /// 特卖现场
        /// </summary>
        AppSpecialSaleOnScene=62,
        /// <summary>
        /// 大家都在逛
        /// </summary>
        AppEveryoneInTheAround=63,

        #endregion 
        
        #region index215 新首页模板

        /// <summary>
        /// m2c模板
        /// </summary>
        NewIndex215M2CTemplate=70,

        /// <summary>
        /// ymt215首页模板
        /// </summary>
        NewIndex215YMTTemplate = 80

        #endregion

    }
}
