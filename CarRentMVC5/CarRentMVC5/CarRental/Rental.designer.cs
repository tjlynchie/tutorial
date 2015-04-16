﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRental
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MyScheduler")]
	public partial class RentalDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertType(Type instance);
    partial void UpdateType(Type instance);
    partial void DeleteType(Type instance);
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    partial void InsertCar(Car instance);
    partial void UpdateCar(Car instance);
    partial void DeleteCar(Car instance);
    #endregion
		
		public RentalDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MySchedulerConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public RentalDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RentalDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RentalDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RentalDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Type> Types
		{
			get
			{
				return this.GetTable<Type>();
			}
		}
		
		public System.Data.Linq.Table<Order> Orders
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
		
		public System.Data.Linq.Table<Car> Cars
		{
			get
			{
				return this.GetTable<Car>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Type")]
	public partial class Type : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _title;
		
		private EntitySet<Car> _Cars;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    #endregion
		
		public Type()
		{
			this._Cars = new EntitySet<Car>(new Action<Car>(this.attach_Cars), new Action<Car>(this.detach_Cars));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(100)")]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Type_Car", Storage="_Cars", ThisKey="Id", OtherKey="TypeId")]
		public EntitySet<Car> Cars
		{
			get
			{
				return this._Cars;
			}
			set
			{
				this._Cars.Assign(value);
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
		
		private void attach_Cars(Car entity)
		{
			this.SendPropertyChanging();
			entity.Type = this;
		}
		
		private void detach_Cars(Car entity)
		{
			this.SendPropertyChanging();
			entity.Type = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Order]")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _text;
		
		private string _description;
		
		private System.DateTime _start_date;
		
		private System.DateTime _end_date;
		
		private string _pick_location;
		
		private string _drop_location;
		
		private int _car_id;
		
		private int _car_number;
		
		private EntityRef<Car> _Car;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntextChanging(string value);
    partial void OntextChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void Onstart_dateChanging(System.DateTime value);
    partial void Onstart_dateChanged();
    partial void Onend_dateChanging(System.DateTime value);
    partial void Onend_dateChanged();
    partial void Onpick_locationChanging(string value);
    partial void Onpick_locationChanged();
    partial void Ondrop_locationChanging(string value);
    partial void Ondrop_locationChanged();
    partial void Oncar_idChanging(int value);
    partial void Oncar_idChanged();
    partial void Oncar_numberChanging(int value);
    partial void Oncar_numberChanged();
    #endregion
		
		public Order()
		{
			this._Car = default(EntityRef<Car>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_text", DbType="NVarChar(256)")]
		public string text
		{
			get
			{
				return this._text;
			}
			set
			{
				if ((this._text != value))
				{
					this.OntextChanging(value);
					this.SendPropertyChanging();
					this._text = value;
					this.SendPropertyChanged("text");
					this.OntextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(256)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_start_date", DbType="DateTime NOT NULL")]
		public System.DateTime start_date
		{
			get
			{
				return this._start_date;
			}
			set
			{
				if ((this._start_date != value))
				{
					this.Onstart_dateChanging(value);
					this.SendPropertyChanging();
					this._start_date = value;
					this.SendPropertyChanged("start_date");
					this.Onstart_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_end_date", DbType="DateTime NOT NULL")]
		public System.DateTime end_date
		{
			get
			{
				return this._end_date;
			}
			set
			{
				if ((this._end_date != value))
				{
					this.Onend_dateChanging(value);
					this.SendPropertyChanging();
					this._end_date = value;
					this.SendPropertyChanged("end_date");
					this.Onend_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pick_location", DbType="NVarChar(256)")]
		public string pick_location
		{
			get
			{
				return this._pick_location;
			}
			set
			{
				if ((this._pick_location != value))
				{
					this.Onpick_locationChanging(value);
					this.SendPropertyChanging();
					this._pick_location = value;
					this.SendPropertyChanged("pick_location");
					this.Onpick_locationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_drop_location", DbType="NVarChar(256)")]
		public string drop_location
		{
			get
			{
				return this._drop_location;
			}
			set
			{
				if ((this._drop_location != value))
				{
					this.Ondrop_locationChanging(value);
					this.SendPropertyChanging();
					this._drop_location = value;
					this.SendPropertyChanged("drop_location");
					this.Ondrop_locationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_car_id", DbType="Int NOT NULL")]
		public int car_id
		{
			get
			{
				return this._car_id;
			}
			set
			{
				if ((this._car_id != value))
				{
					if (this._Car.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Oncar_idChanging(value);
					this.SendPropertyChanging();
					this._car_id = value;
					this.SendPropertyChanged("car_id");
					this.Oncar_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_car_number", DbType="Int NOT NULL")]
		public int car_number
		{
			get
			{
				return this._car_number;
			}
			set
			{
				if ((this._car_number != value))
				{
					this.Oncar_numberChanging(value);
					this.SendPropertyChanging();
					this._car_number = value;
					this.SendPropertyChanged("car_number");
					this.Oncar_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Car_Order", Storage="_Car", ThisKey="car_id", OtherKey="id", IsForeignKey=true)]
		public Car Car
		{
			get
			{
				return this._Car.Entity;
			}
			set
			{
				Car previousValue = this._Car.Entity;
				if (((previousValue != value) 
							|| (this._Car.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Car.Entity = null;
						previousValue.Orders.Remove(this);
					}
					this._Car.Entity = value;
					if ((value != null))
					{
						value.Orders.Add(this);
						this._car_id = value.id;
					}
					else
					{
						this._car_id = default(int);
					}
					this.SendPropertyChanged("Car");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Car")]
	public partial class Car : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private decimal _Price;
		
		private int _TypeId;
		
		private string _Photo;
		
		private string _Brand;
		
		private int _Count;
		
		private EntitySet<Order> _Orders;
		
		private EntityRef<Type> _Type;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnTypeIdChanging(int value);
    partial void OnTypeIdChanged();
    partial void OnPhotoChanging(string value);
    partial void OnPhotoChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnCountChanging(int value);
    partial void OnCountChanged();
    #endregion
		
		public Car()
		{
			this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
			this._Type = default(EntityRef<Type>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(8,2) NOT NULL")]
		public decimal Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeId", DbType="Int NOT NULL")]
		public int TypeId
		{
			get
			{
				return this._TypeId;
			}
			set
			{
				if ((this._TypeId != value))
				{
					if (this._Type.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTypeIdChanging(value);
					this.SendPropertyChanging();
					this._TypeId = value;
					this.SendPropertyChanged("TypeId");
					this.OnTypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Photo", DbType="NVarChar(256)")]
		public string Photo
		{
			get
			{
				return this._Photo;
			}
			set
			{
				if ((this._Photo != value))
				{
					this.OnPhotoChanging(value);
					this.SendPropertyChanging();
					this._Photo = value;
					this.SendPropertyChanged("Photo");
					this.OnPhotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="NVarChar(100)")]
		public string Brand
		{
			get
			{
				return this._Brand;
			}
			set
			{
				if ((this._Brand != value))
				{
					this.OnBrandChanging(value);
					this.SendPropertyChanging();
					this._Brand = value;
					this.SendPropertyChanged("Brand");
					this.OnBrandChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Count", DbType="Int NOT NULL")]
		public int Count
		{
			get
			{
				return this._Count;
			}
			set
			{
				if ((this._Count != value))
				{
					this.OnCountChanging(value);
					this.SendPropertyChanging();
					this._Count = value;
					this.SendPropertyChanged("Count");
					this.OnCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Car_Order", Storage="_Orders", ThisKey="id", OtherKey="car_id")]
		public EntitySet<Order> Orders
		{
			get
			{
				return this._Orders;
			}
			set
			{
				this._Orders.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Type_Car", Storage="_Type", ThisKey="TypeId", OtherKey="Id", IsForeignKey=true)]
		public Type Type
		{
			get
			{
				return this._Type.Entity;
			}
			set
			{
				Type previousValue = this._Type.Entity;
				if (((previousValue != value) 
							|| (this._Type.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Type.Entity = null;
						previousValue.Cars.Remove(this);
					}
					this._Type.Entity = value;
					if ((value != null))
					{
						value.Cars.Add(this);
						this._TypeId = value.Id;
					}
					else
					{
						this._TypeId = default(int);
					}
					this.SendPropertyChanged("Type");
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
		
		private void attach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.Car = this;
		}
		
		private void detach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.Car = null;
		}
	}
}
#pragma warning restore 1591
