#region

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using Microsoft.Practices.Unity;
using Ymatou.CommonService;
using Ymatou.StaticContent.DataModel;
using Newtonsoft.Json;

#endregion

namespace Ymatou.StaticContent.QueryServices.Impl
{
    /// <summary>
    /// 数据模型转换
    /// </summary>
    public static class TemplateBlcokItemExtension
    {
        /// <summary>
        /// 转换成对应的数据模型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listTemplateBlockItem"></param>
        /// <returns></returns>
        public static List<T> ToViewModel<T>(this List<TemplateBlcokItem> listTemplateBlockItem) where T : IBlockItemViewModel
        {
            var listBlockItemViewModel = new List<T>();
            var listTemplateBlockItem01 = listTemplateBlockItem.OrderBy(m => m.iOrder).ToList();
            foreach (var item in listTemplateBlockItem01)
            {
                listBlockItemViewModel.Add(item.ToViewModel<T>());
            }
            return listBlockItemViewModel;
        }
        /// <summary>
        /// 转换成对应的数据模型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listTemplateBlockItem"></param>
        /// <returns></returns>
        public static T ToViewModel<T>(this TemplateBlcokItem item) where T : IBlockItemViewModel
        {
            //反序列化对应的对象
            return  JsonConvert.DeserializeObject<T>(item.sContent, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling=DefaultValueHandling.Ignore,
                 
                 
            });
        }
        /// <summary>
        /// 转换成对应的数据模型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listTemplateBlockItem"></param>
        /// <returns></returns>
        public static IBlockItem<T> ToBlockItem<T>(this TemplateBlcokItem item) where T : IBlockItemViewModel
        {
            var entity = new IBlockItem<T>();
            entity.Action = item.iAction;
            entity.AddTime = item.dAddTime;
            entity.BlockID = item.iTemplateBlcokID;
            entity.BlockItemID = item.iTemplateBlockItemID;
            entity.Content = item.sContent;
            entity.Remark = item.sRemark;
            entity.TemplateID = item.iTemplateID;
            entity.UpdateTime = item.dupdateTime;
            //反序列化对应的对象
            entity.ViewModel = JsonConvert.DeserializeObject<T>(entity.Content, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling=DefaultValueHandling.Ignore,
            });

            return entity;
        }
        /// <summary>
        /// 转换成对应的数据模型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listTemplateBlockItem"></param>
        /// <returns></returns>
        public static List<IBlockItem<T>> ToBlockItem<T>(this List<TemplateBlcokItem> listTemplateBlockItem) where T : IBlockItemViewModel
        {
            var listBlockItemViewModel = new List<IBlockItem<T>>();
            var listTemplateBlockItem01 = listTemplateBlockItem.OrderBy(m => m.iOrder).ToList();
            foreach (var item in listTemplateBlockItem01)
            {
                listBlockItemViewModel.Add(item.ToBlockItem<T>());
            }
            return listBlockItemViewModel;
        }
    }


    public class StaticContentQueryService : IStaticContentQueryService
    {
        [Dependency]
        public StaticContentQueryDataContext DataContext { get; set; }

        #region //new
        /// <summary>
        /// 预览方法
        /// 获取预览和发布的数据
        /// </summary>
        /// <param name="iTemplateID"></param>
        /// <param name="iTemplateBlcokID"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public PagedList<TemplateBlcokItem> ListBlockItemPreView(int iTemplateID, int iTemplateBlcokID, int page, int pageSize)
        {
            var templates = DataContext.TemplateBlcokItems.Where(t => t.iTemplateID == iTemplateID && t.iTemplateBlcokID == iTemplateBlcokID);
            //状态
            templates = from p in templates
                        where p.iAction == TemplateBlcokItemIActionEnum.Apply || p.iAction == TemplateBlcokItemIActionEnum.PreView
                        select p;
            //
            templates = from p in templates
                        orderby p.iTemplateBlockItemID descending
                        select p;

            var pl= templates.ToPagedList(page, pageSize);
            return pl;
        }
        /// <summary>
        /// 获取预览的数据，国家馆就是备选数据
        /// </summary>
        /// <param name="iTemplateID"></param>
        /// <param name="iTemplateBlcokID"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public PagedList<TemplateBlcokItem> ListBlockItemBackUp(int iTemplateID, int iTemplateBlcokID, int page, int pageSize)
        {
            var templates = DataContext.TemplateBlcokItems.Where(t => t.iTemplateID == iTemplateID && t.iTemplateBlcokID == iTemplateBlcokID);
            //状态
            templates = from p in templates
                        where p.iAction == TemplateBlcokItemIActionEnum.PreView
                        select p;
            //
            templates = from p in templates
                        orderby p.iTemplateBlockItemID descending
                        select p;

            var pl = templates.ToPagedList(page, pageSize);
            return pl;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iTemplateID"></param>
        /// <param name="iTemplateBlcokID"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public PagedList<TemplateBlcokItem> ListBlockItem(TemplateEnum iTemplateID, int iTemplateBlcokID, int page, int pageSize)
        {
            var pl = ListBlockItem((int)iTemplateID, iTemplateBlcokID, TemplateBlcokItemIActionEnum.Apply, string.Empty, page, pageSize);
            return pl;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iTemplateID"></param>
        /// <param name="iTemplateBlcokID"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public PagedList<TemplateBlcokItem> ListBlockItem(int iTemplateID, int iTemplateBlcokID, int page, int pageSize)
        {
            var pl= ListBlockItem(iTemplateID, iTemplateBlcokID, TemplateBlcokItemIActionEnum.Apply,string.Empty, page, pageSize);
            return pl;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iTemplateID"></param>
        /// <param name="iTemplateBlcokID"></param>
        /// <param name="iaction">参考：TemplateBlcokItemIActionEnum.</param>
        /// <param name="keyword"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public PagedList<TemplateBlcokItem> ListBlockItem(int iTemplateID, int iTemplateBlcokID,int? iaction,string keyword, int page, int pageSize)
        {
          
            var templates = DataContext.TemplateBlcokItems.Where(t => t.iTemplateID == iTemplateID && t.iTemplateBlcokID == iTemplateBlcokID);
            //状态
            if (iaction.HasValue)
            {
                templates = from p in templates
                            where p.iAction == iaction.Value
                            select p;
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                templates = templates.Where(n => n.sContent.StartsWith(keyword) || n.sContent.EndsWith(keyword) || n.sContent.IndexOf(keyword) != -1);
            }
            //
            templates = from p in templates
                        orderby p.iTemplateBlockItemID descending
                        select p;

            return templates.ToPagedList(page, pageSize);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iTemplateBlockItemID"></param>
        /// <returns></returns>
        public TemplateBlcokItem GetOneBlockItem(int iTemplateBlockItemID)
        {
            return DataContext.TemplateBlcokItems.SingleOrDefault(m => m.iTemplateBlockItemID == iTemplateBlockItemID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int AddOneBlockItem(TemplateBlcokItem blockItem)
        {
            DataContext.TemplateBlcokItems.InsertOnSubmit(blockItem);
            DataContext.SubmitChanges();
            return blockItem.iTemplateBlockItemID;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int AddOneBlockItem(int iTemplateID,int iTemplateBlcokID, IBlockItemViewModel viewModel)
        {
            var blockItem=new TemplateBlcokItem();
            blockItem.dAddTime=DateTime.Now;
            blockItem.dupdateTime=DateTime.Now;
            blockItem.iAction=0;
            blockItem.iOrder=1;
            blockItem.iTemplateBlcokID=iTemplateBlcokID;
            blockItem.iTemplateID=iTemplateID;
            blockItem.sRemark = string.Empty;
            blockItem.sContent = JsonConvert.SerializeObject(viewModel);
            //
            DataContext.TemplateBlcokItems.InsertOnSubmit(blockItem);
            DataContext.SubmitChanges();

            return blockItem.iTemplateBlockItemID;
        }
        /// <summary>
        /// 数据复制
        /// </summary>
        /// <param name="iTemplateBlockItemID"></param>
        /// <returns></returns>
        public int CloneOneBlockItem(int iTemplateBlockItemID)
        {
            var blcokItemNow = GetOneBlockItem(iTemplateBlockItemID);
            if (blcokItemNow != null)
            {
                var blockItem = new TemplateBlcokItem();
                blockItem.dAddTime = DateTime.Now;
                blockItem.dupdateTime = DateTime.Now;
                blockItem.iAction = 0;
                blockItem.iOrder = 1;
                blockItem.iTemplateBlcokID = blcokItemNow.iTemplateBlcokID;
                blockItem.iTemplateID = blcokItemNow.iTemplateID;
                //
                blockItem.sContent =blcokItemNow.sContent;
                blockItem.sRemark = string.Format("数据复制，来源编号：{0}", blcokItemNow.iTemplateBlockItemID);
                //
                DataContext.TemplateBlcokItems.InsertOnSubmit(blockItem);
                DataContext.SubmitChanges();

                return blockItem.iTemplateBlockItemID;
            }
            return 0;
        }
        /// <summary>
        /// 编辑数据
        /// </summary>
        /// <returns></returns>
        public int EditOneBlockItem(TemplateBlcokItem blockItem)
        {
            var blcokItemNow = GetOneBlockItem(blockItem.iTemplateBlockItemID);
            if (blcokItemNow != null)
            {
                blcokItemNow.sRemark = blockItem.sRemark;
                blcokItemNow.sContent = blockItem.sContent;
                blcokItemNow.iAction = blockItem.iAction;
                blcokItemNow.iOrder = blockItem.iOrder;
                blcokItemNow.dAddTime = blcokItemNow.dAddTime;
                blcokItemNow.dupdateTime = blockItem.dupdateTime;

                //DataContext.SubmitChanges();
                
                try
                {
                    DataContext.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                }
                catch (System.Data.Linq.ChangeConflictException ex)
                {
                    foreach (System.Data.Linq.ObjectChangeConflict occ in DataContext.ChangeConflicts)
                    {
                        //以下是解决冲突的三种方法，选一种即可
                        // 使用当前数据库中的值，覆盖Linq缓存中实体对象的值
                        //occ.Resolve(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                        // 使用Linq缓存中实体对象的值，覆盖当前数据库中的值
                        occ.Resolve(System.Data.Linq.RefreshMode.KeepCurrentValues);
                        // 只更新实体对象中改变的字段的值，其他的保留不变
                        //occ.Resolve(System.Data.Linq.RefreshMode.KeepChanges);
                    }
                    // 这个地方要注意，Catch方法中，我们前面只是指明了怎样来解决冲突，这个地方还需要再次提交更新，这样的话，值    //才会提交到数据库。
                    DataContext.SubmitChanges();
                }
                 
                return blockItem.iTemplateBlockItemID;
            }
            return 0;
        }
        /// <summary>
        /// 设置数据状态为备选，添加备选说明
        /// </summary>
        /// <returns></returns>
        public int SetOneBlockItemBackUp(int _iTemplateBlockItemID)
        {
            var blcokItemNow = GetOneBlockItem(_iTemplateBlockItemID);
            if (blcokItemNow != null)
            {
                blcokItemNow.sRemark = string.Format("该数据于{0},已经为备选数据", DateTime.Now.ToString("yyyy-mm-dd HH:mm:ss"));

                return EditOneBlockItem(blcokItemNow);
            }
            return 0;
        }
        #endregion 
    }
}