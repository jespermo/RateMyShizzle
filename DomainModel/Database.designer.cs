﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DomainModel
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="RateMyShizzle")]
	public partial class DatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertRatingScore(RatingScore instance);
    partial void UpdateRatingScore(RatingScore instance);
    partial void DeleteRatingScore(RatingScore instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertRatingType(RatingType instance);
    partial void UpdateRatingType(RatingType instance);
    partial void DeleteRatingType(RatingType instance);
    #endregion
		
		public DatabaseDataContext() : 
				base(global::DomainModel.Properties.Settings.Default.RateMyShizzleConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<RatingScore> RatingScores
		{
			get
			{
				return this.GetTable<RatingScore>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<RatingType> RatingTypes
		{
			get
			{
				return this.GetTable<RatingType>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RatingScore")]
	public partial class RatingScore : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RatingScoreId;
		
		private int _RatedById;
		
		private System.DateTime _CreatedDate;
		
		private System.DateTime _LastModifiedDate;
		
		private int _Score;
		
		private int _RatingTypeId;
		
		private EntityRef<User> _User;
		
		private EntityRef<RatingType> _RatingType;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRatingScoreIdChanging(int value);
    partial void OnRatingScoreIdChanged();
    partial void OnRatedByIdChanging(int value);
    partial void OnRatedByIdChanged();
    partial void OnCreatedDateChanging(System.DateTime value);
    partial void OnCreatedDateChanged();
    partial void OnLastModifiedDateChanging(System.DateTime value);
    partial void OnLastModifiedDateChanged();
    partial void OnScoreChanging(int value);
    partial void OnScoreChanged();
    partial void OnRatingTypeIdChanging(int value);
    partial void OnRatingTypeIdChanged();
    #endregion
		
		public RatingScore()
		{
			this._User = default(EntityRef<User>);
			this._RatingType = default(EntityRef<RatingType>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RatingScoreId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int RatingScoreId
		{
			get
			{
				return this._RatingScoreId;
			}
			set
			{
				if ((this._RatingScoreId != value))
				{
					this.OnRatingScoreIdChanging(value);
					this.SendPropertyChanging();
					this._RatingScoreId = value;
					this.SendPropertyChanged("RatingScoreId");
					this.OnRatingScoreIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RatedById", DbType="Int NOT NULL")]
		public int RatedById
		{
			get
			{
				return this._RatedById;
			}
			set
			{
				if ((this._RatedById != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRatedByIdChanging(value);
					this.SendPropertyChanging();
					this._RatedById = value;
					this.SendPropertyChanged("RatedById");
					this.OnRatedByIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedDate", DbType="DateTime NOT NULL")]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._CreatedDate;
			}
			set
			{
				if ((this._CreatedDate != value))
				{
					this.OnCreatedDateChanging(value);
					this.SendPropertyChanging();
					this._CreatedDate = value;
					this.SendPropertyChanged("CreatedDate");
					this.OnCreatedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastModifiedDate", DbType="DateTime NOT NULL")]
		public System.DateTime LastModifiedDate
		{
			get
			{
				return this._LastModifiedDate;
			}
			set
			{
				if ((this._LastModifiedDate != value))
				{
					this.OnLastModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._LastModifiedDate = value;
					this.SendPropertyChanged("LastModifiedDate");
					this.OnLastModifiedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Score", DbType="Int NOT NULL")]
		public int Score
		{
			get
			{
				return this._Score;
			}
			set
			{
				if ((this._Score != value))
				{
					this.OnScoreChanging(value);
					this.SendPropertyChanging();
					this._Score = value;
					this.SendPropertyChanged("Score");
					this.OnScoreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RatingTypeId", DbType="Int NOT NULL")]
		public int RatingTypeId
		{
			get
			{
				return this._RatingTypeId;
			}
			set
			{
				if ((this._RatingTypeId != value))
				{
					if (this._RatingType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRatingTypeIdChanging(value);
					this.SendPropertyChanging();
					this._RatingTypeId = value;
					this.SendPropertyChanged("RatingTypeId");
					this.OnRatingTypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_RatingScore", Storage="_User", ThisKey="RatedById", OtherKey="UserId", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.RatingScores.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.RatingScores.Add(this);
						this._RatedById = value.UserId;
					}
					else
					{
						this._RatedById = default(int);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RatingType_RatingScore", Storage="_RatingType", ThisKey="RatingTypeId", OtherKey="RatingTypeId", IsForeignKey=true)]
		public RatingType RatingType
		{
			get
			{
				return this._RatingType.Entity;
			}
			set
			{
				RatingType previousValue = this._RatingType.Entity;
				if (((previousValue != value) 
							|| (this._RatingType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._RatingType.Entity = null;
						previousValue.RatingScores.Remove(this);
					}
					this._RatingType.Entity = value;
					if ((value != null))
					{
						value.RatingScores.Add(this);
						this._RatingTypeId = value.RatingTypeId;
					}
					else
					{
						this._RatingTypeId = default(int);
					}
					this.SendPropertyChanged("RatingType");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserId;
		
		private string _UserName;
		
		private EntitySet<RatingScore> _RatingScores;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    #endregion
		
		public User()
		{
			this._RatingScores = new EntitySet<RatingScore>(new Action<RatingScore>(this.attach_RatingScores), new Action<RatingScore>(this.detach_RatingScores));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_RatingScore", Storage="_RatingScores", ThisKey="UserId", OtherKey="RatedById")]
		public EntitySet<RatingScore> RatingScores
		{
			get
			{
				return this._RatingScores;
			}
			set
			{
				this._RatingScores.Assign(value);
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
		
		private void attach_RatingScores(RatingScore entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_RatingScores(RatingScore entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RatingType")]
	public partial class RatingType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RatingTypeId;
		
		private string _Name;
		
		private int _MaxScore;
		
		private EntitySet<RatingScore> _RatingScores;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRatingTypeIdChanging(int value);
    partial void OnRatingTypeIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnMaxScoreChanging(int value);
    partial void OnMaxScoreChanged();
    #endregion
		
		public RatingType()
		{
			this._RatingScores = new EntitySet<RatingScore>(new Action<RatingScore>(this.attach_RatingScores), new Action<RatingScore>(this.detach_RatingScores));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RatingTypeId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int RatingTypeId
		{
			get
			{
				return this._RatingTypeId;
			}
			set
			{
				if ((this._RatingTypeId != value))
				{
					this.OnRatingTypeIdChanging(value);
					this.SendPropertyChanging();
					this._RatingTypeId = value;
					this.SendPropertyChanged("RatingTypeId");
					this.OnRatingTypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaxScore", DbType="Int NOT NULL")]
		public int MaxScore
		{
			get
			{
				return this._MaxScore;
			}
			set
			{
				if ((this._MaxScore != value))
				{
					this.OnMaxScoreChanging(value);
					this.SendPropertyChanging();
					this._MaxScore = value;
					this.SendPropertyChanged("MaxScore");
					this.OnMaxScoreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RatingType_RatingScore", Storage="_RatingScores", ThisKey="RatingTypeId", OtherKey="RatingTypeId")]
		public EntitySet<RatingScore> RatingScores
		{
			get
			{
				return this._RatingScores;
			}
			set
			{
				this._RatingScores.Assign(value);
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
		
		private void attach_RatingScores(RatingScore entity)
		{
			this.SendPropertyChanging();
			entity.RatingType = this;
		}
		
		private void detach_RatingScores(RatingScore entity)
		{
			this.SendPropertyChanging();
			entity.RatingType = null;
		}
	}
}
#pragma warning restore 1591
