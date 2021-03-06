﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ymatou.StaticContent.QueryServices.Impl
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="YmtStaticContent")]
	public partial class StaticContentQueryDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTemplateBlcokItem(TemplateBlcokItem instance);
    partial void UpdateTemplateBlcokItem(TemplateBlcokItem instance);
    partial void DeleteTemplateBlcokItem(TemplateBlcokItem instance);
    #endregion
		
		public StaticContentQueryDataContext() : 
				base(global::Ymatou.StaticContent.QueryServices.Impl.Properties.Settings.Default.YmtStaticContentConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public StaticContentQueryDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StaticContentQueryDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StaticContentQueryDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StaticContentQueryDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TemplateBlcokItem> TemplateBlcokItems
		{
			get
			{
				return this.GetTable<TemplateBlcokItem>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TemplateBlcokItem")]
	public partial class TemplateBlcokItem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _iTemplateBlockItemID;
		
		private int _iTemplateID;
		
		private int _iTemplateBlcokID;
		
		private string _sContent;
		
		private System.DateTime _dAddTime;
		
		private System.DateTime _dupdateTime;
		
		private int _iAction;
		
		private int _iOrder;
		
		private string _sRemark;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OniTemplateBlockItemIDChanging(int value);
    partial void OniTemplateBlockItemIDChanged();
    partial void OniTemplateIDChanging(int value);
    partial void OniTemplateIDChanged();
    partial void OniTemplateBlcokIDChanging(int value);
    partial void OniTemplateBlcokIDChanged();
    partial void OnsContentChanging(string value);
    partial void OnsContentChanged();
    partial void OndAddTimeChanging(System.DateTime value);
    partial void OndAddTimeChanged();
    partial void OndupdateTimeChanging(System.DateTime value);
    partial void OndupdateTimeChanged();
    partial void OniActionChanging(int value);
    partial void OniActionChanged();
    partial void OniOrderChanging(int value);
    partial void OniOrderChanged();
    partial void OnsRemarkChanging(string value);
    partial void OnsRemarkChanged();
    #endregion
		
		public TemplateBlcokItem()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_iTemplateBlockItemID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int iTemplateBlockItemID
		{
			get
			{
				return this._iTemplateBlockItemID;
			}
			set
			{
				if ((this._iTemplateBlockItemID != value))
				{
					this.OniTemplateBlockItemIDChanging(value);
					this.SendPropertyChanging();
					this._iTemplateBlockItemID = value;
					this.SendPropertyChanged("iTemplateBlockItemID");
					this.OniTemplateBlockItemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_iTemplateID", DbType="Int NOT NULL")]
		public int iTemplateID
		{
			get
			{
				return this._iTemplateID;
			}
			set
			{
				if ((this._iTemplateID != value))
				{
					this.OniTemplateIDChanging(value);
					this.SendPropertyChanging();
					this._iTemplateID = value;
					this.SendPropertyChanged("iTemplateID");
					this.OniTemplateIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_iTemplateBlcokID", DbType="Int NOT NULL")]
		public int iTemplateBlcokID
		{
			get
			{
				return this._iTemplateBlcokID;
			}
			set
			{
				if ((this._iTemplateBlcokID != value))
				{
					this.OniTemplateBlcokIDChanging(value);
					this.SendPropertyChanging();
					this._iTemplateBlcokID = value;
					this.SendPropertyChanged("iTemplateBlcokID");
					this.OniTemplateBlcokIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sContent", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string sContent
		{
			get
			{
				return this._sContent;
			}
			set
			{
				if ((this._sContent != value))
				{
					this.OnsContentChanging(value);
					this.SendPropertyChanging();
					this._sContent = value;
					this.SendPropertyChanged("sContent");
					this.OnsContentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dAddTime", DbType="DateTime NOT NULL")]
		public System.DateTime dAddTime
		{
			get
			{
				return this._dAddTime;
			}
			set
			{
				if ((this._dAddTime != value))
				{
					this.OndAddTimeChanging(value);
					this.SendPropertyChanging();
					this._dAddTime = value;
					this.SendPropertyChanged("dAddTime");
					this.OndAddTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dupdateTime", DbType="DateTime NOT NULL")]
		public System.DateTime dupdateTime
		{
			get
			{
				return this._dupdateTime;
			}
			set
			{
				if ((this._dupdateTime != value))
				{
					this.OndupdateTimeChanging(value);
					this.SendPropertyChanging();
					this._dupdateTime = value;
					this.SendPropertyChanged("dupdateTime");
					this.OndupdateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_iAction", DbType="Int NOT NULL")]
		public int iAction
		{
			get
			{
				return this._iAction;
			}
			set
			{
				if ((this._iAction != value))
				{
					this.OniActionChanging(value);
					this.SendPropertyChanging();
					this._iAction = value;
					this.SendPropertyChanged("iAction");
					this.OniActionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_iOrder", DbType="Int NOT NULL")]
		public int iOrder
		{
			get
			{
				return this._iOrder;
			}
			set
			{
				if ((this._iOrder != value))
				{
					this.OniOrderChanging(value);
					this.SendPropertyChanging();
					this._iOrder = value;
					this.SendPropertyChanged("iOrder");
					this.OniOrderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sRemark", DbType="NVarChar(500)")]
		public string sRemark
		{
			get
			{
				return this._sRemark;
			}
			set
			{
				if ((this._sRemark != value))
				{
					this.OnsRemarkChanging(value);
					this.SendPropertyChanging();
					this._sRemark = value;
					this.SendPropertyChanged("sRemark");
					this.OnsRemarkChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
