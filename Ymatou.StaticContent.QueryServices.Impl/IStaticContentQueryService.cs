using System.Collections.Generic;
using Ymatou.CommonService;
using Ymatou.StaticContent.DataModel;
using Ymatou.StaticContent.QueryServices.Impl;

namespace Ymatou.StaticContent.QueryServices
{
    public interface IStaticContentQueryService
    {
        #region //New 
        /// <summary>
        /// 获取预览数据
        /// </summary>
        /// <param name="iTemplateID"></param>
        /// <param name="iTemplateBlcokID"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        PagedList<TemplateBlcokItem> ListBlockItemBackUp(int iTemplateID, int iTemplateBlcokID, int page, int pageSize);
        /// <summary>
        /// 获取预览与发布数据，前端预览页面使用
        /// </summary>
        /// <param name="iTemplateID"></param>
        /// <param name="iTemplateBlcokID"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        PagedList<TemplateBlcokItem> ListBlockItemPreView(int iTemplateID, int iTemplateBlcokID, int page, int pageSize);
        /// <summary>
        /// 获取发布数据
        /// </summary>
        /// <param name="iTemplateID"></param>
        /// <param name="iTemplateBlcokID"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        PagedList<TemplateBlcokItem> ListBlockItem(TemplateEnum iTemplateID, int iTemplateBlcokID, int page, int pageSize);
       /// <summary>
       /// 获取发布数据
       /// </summary>
       /// <param name="iTemplateID"></param>
       /// <param name="iTemplateBlcokID"></param>
       /// <param name="page"></param>
       /// <param name="pageSize"></param>
       /// <returns></returns>
        PagedList<TemplateBlcokItem> ListBlockItem(int iTemplateID, int iTemplateBlcokID, int page, int pageSize);
        /// <summary>
        /// 后台获取数据的方法
        /// </summary>
        /// <param name="iTemplateID"></param>
        /// <param name="iTemplateBlcokID"></param>
        /// <param name="iaction"></param>
        /// <param name="keyword"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        PagedList<TemplateBlcokItem> ListBlockItem(int iTemplateID, int iTemplateBlcokID, int? iaction, string keyword, int page, int pageSize);
        /// <summary>
        /// 获取一条数据
        /// </summary>
        /// <param name="iTemplateBlockItemID"></param>
        /// <returns></returns>
        TemplateBlcokItem GetOneBlockItem(int iTemplateBlockItemID);
        /// <summary>
        /// 数据复制
        /// </summary>
        /// <param name="iTemplateBlockItemID"></param>
        /// <returns></returns>
        int CloneOneBlockItem(int iTemplateBlockItemID);
        /// <summary>
        /// 添加一条数据
        /// </summary>
        /// <returns></returns>
        int AddOneBlockItem(TemplateBlcokItem blockItem);
        /// <summary>
        /// 添加一条数据
        /// </summary>
        /// <param name="iTemplateID"></param>
        /// <param name="iTemplateBlcokID"></param>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        int AddOneBlockItem(int iTemplateID, int iTemplateBlcokID, IBlockItemViewModel viewModel);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int EditOneBlockItem(TemplateBlcokItem blockItem);
        /// <summary>
        /// 设置数据状态为备选，添加备选说明
        /// </summary>
        /// <returns></returns>
        int SetOneBlockItemBackUp(int iTemplateBlockItemID);
        #endregion 
    }
}