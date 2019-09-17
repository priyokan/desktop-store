﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mbrow
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MB")]
	public partial class linqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertbuyer(buyer instance);
    partial void Updatebuyer(buyer instance);
    partial void Deletebuyer(buyer instance);
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    partial void Insertcategory(category instance);
    partial void Updatecategory(category instance);
    partial void Deletecategory(category instance);
    partial void Insertdetail_order(detail_order instance);
    partial void Updatedetail_order(detail_order instance);
    partial void Deletedetail_order(detail_order instance);
    partial void Insertitem(item instance);
    partial void Updateitem(item instance);
    partial void Deleteitem(item instance);
    partial void Insertorder(order instance);
    partial void Updateorder(order instance);
    partial void Deleteorder(order instance);
    partial void Insertpembayaran(pembayaran instance);
    partial void Updatepembayaran(pembayaran instance);
    partial void Deletepembayaran(pembayaran instance);
    #endregion
		
		public linqDataContext() : 
				base(global::mbrow.Properties.Settings.Default.MBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<buyer> buyers
		{
			get
			{
				return this.GetTable<buyer>();
			}
		}
		
		public System.Data.Linq.Table<user> users
		{
			get
			{
				return this.GetTable<user>();
			}
		}
		
		public System.Data.Linq.Table<category> categories
		{
			get
			{
				return this.GetTable<category>();
			}
		}
		
		public System.Data.Linq.Table<detail_order> detail_orders
		{
			get
			{
				return this.GetTable<detail_order>();
			}
		}
		
		public System.Data.Linq.Table<item> items
		{
			get
			{
				return this.GetTable<item>();
			}
		}
		
		public System.Data.Linq.Table<order> orders
		{
			get
			{
				return this.GetTable<order>();
			}
		}
		
		public System.Data.Linq.Table<pembayaran> pembayarans
		{
			get
			{
				return this.GetTable<pembayaran>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.buyer")]
	public partial class buyer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_buyer;
		
		private string _nama_buyer;
		
		private string _email;
		
		private string _telphone_whatsapp;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_buyerChanging(int value);
    partial void Onid_buyerChanged();
    partial void Onnama_buyerChanging(string value);
    partial void Onnama_buyerChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void Ontelphone_whatsappChanging(string value);
    partial void Ontelphone_whatsappChanged();
    #endregion
		
		public buyer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_buyer", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_buyer
		{
			get
			{
				return this._id_buyer;
			}
			set
			{
				if ((this._id_buyer != value))
				{
					this.Onid_buyerChanging(value);
					this.SendPropertyChanging();
					this._id_buyer = value;
					this.SendPropertyChanged("id_buyer");
					this.Onid_buyerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nama_buyer", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nama_buyer
		{
			get
			{
				return this._nama_buyer;
			}
			set
			{
				if ((this._nama_buyer != value))
				{
					this.Onnama_buyerChanging(value);
					this.SendPropertyChanging();
					this._nama_buyer = value;
					this.SendPropertyChanged("nama_buyer");
					this.Onnama_buyerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[telphone/whatsapp]", Storage="_telphone_whatsapp", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string telphone_whatsapp
		{
			get
			{
				return this._telphone_whatsapp;
			}
			set
			{
				if ((this._telphone_whatsapp != value))
				{
					this.Ontelphone_whatsappChanging(value);
					this.SendPropertyChanging();
					this._telphone_whatsapp = value;
					this.SendPropertyChanged("telphone_whatsapp");
					this.Ontelphone_whatsappChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[user]")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_user;
		
		private string _nama;
		
		private string _username;
		
		private string _password;
		
		private string _role;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_userChanging(int value);
    partial void Onid_userChanged();
    partial void OnnamaChanging(string value);
    partial void OnnamaChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnroleChanging(string value);
    partial void OnroleChanged();
    #endregion
		
		public user()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_user", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_user
		{
			get
			{
				return this._id_user;
			}
			set
			{
				if ((this._id_user != value))
				{
					this.Onid_userChanging(value);
					this.SendPropertyChanging();
					this._id_user = value;
					this.SendPropertyChanged("id_user");
					this.Onid_userChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nama", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nama
		{
			get
			{
				return this._nama;
			}
			set
			{
				if ((this._nama != value))
				{
					this.OnnamaChanging(value);
					this.SendPropertyChanging();
					this._nama = value;
					this.SendPropertyChanged("nama");
					this.OnnamaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_role", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string role
		{
			get
			{
				return this._role;
			}
			set
			{
				if ((this._role != value))
				{
					this.OnroleChanging(value);
					this.SendPropertyChanging();
					this._role = value;
					this.SendPropertyChanged("role");
					this.OnroleChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.category")]
	public partial class category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_category;
		
		private string _nama_category;
		
		private string _deskripsi;
		
		private System.Data.Linq.Binary _foto;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_categoryChanging(int value);
    partial void Onid_categoryChanged();
    partial void Onnama_categoryChanging(string value);
    partial void Onnama_categoryChanged();
    partial void OndeskripsiChanging(string value);
    partial void OndeskripsiChanged();
    partial void OnfotoChanging(System.Data.Linq.Binary value);
    partial void OnfotoChanged();
    #endregion
		
		public category()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_category", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_category
		{
			get
			{
				return this._id_category;
			}
			set
			{
				if ((this._id_category != value))
				{
					this.Onid_categoryChanging(value);
					this.SendPropertyChanging();
					this._id_category = value;
					this.SendPropertyChanged("id_category");
					this.Onid_categoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nama_category", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nama_category
		{
			get
			{
				return this._nama_category;
			}
			set
			{
				if ((this._nama_category != value))
				{
					this.Onnama_categoryChanging(value);
					this.SendPropertyChanging();
					this._nama_category = value;
					this.SendPropertyChanged("nama_category");
					this.Onnama_categoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deskripsi", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string deskripsi
		{
			get
			{
				return this._deskripsi;
			}
			set
			{
				if ((this._deskripsi != value))
				{
					this.OndeskripsiChanging(value);
					this.SendPropertyChanging();
					this._deskripsi = value;
					this.SendPropertyChanged("deskripsi");
					this.OndeskripsiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_foto", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary foto
		{
			get
			{
				return this._foto;
			}
			set
			{
				if ((this._foto != value))
				{
					this.OnfotoChanging(value);
					this.SendPropertyChanging();
					this._foto = value;
					this.SendPropertyChanged("foto");
					this.OnfotoChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.detail_order")]
	public partial class detail_order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_detail_order;
		
		private int _order_id;
		
		private int _item_id;
		
		private int _qty;
		
		private int _harga;
		
		private int _total;
		
		private string _status;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_detail_orderChanging(int value);
    partial void Onid_detail_orderChanged();
    partial void Onorder_idChanging(int value);
    partial void Onorder_idChanged();
    partial void Onitem_idChanging(int value);
    partial void Onitem_idChanged();
    partial void OnqtyChanging(int value);
    partial void OnqtyChanged();
    partial void OnhargaChanging(int value);
    partial void OnhargaChanged();
    partial void OntotalChanging(int value);
    partial void OntotalChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    #endregion
		
		public detail_order()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_detail_order", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_detail_order
		{
			get
			{
				return this._id_detail_order;
			}
			set
			{
				if ((this._id_detail_order != value))
				{
					this.Onid_detail_orderChanging(value);
					this.SendPropertyChanging();
					this._id_detail_order = value;
					this.SendPropertyChanged("id_detail_order");
					this.Onid_detail_orderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_order_id", DbType="Int NOT NULL")]
		public int order_id
		{
			get
			{
				return this._order_id;
			}
			set
			{
				if ((this._order_id != value))
				{
					this.Onorder_idChanging(value);
					this.SendPropertyChanging();
					this._order_id = value;
					this.SendPropertyChanged("order_id");
					this.Onorder_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_id", DbType="Int NOT NULL")]
		public int item_id
		{
			get
			{
				return this._item_id;
			}
			set
			{
				if ((this._item_id != value))
				{
					this.Onitem_idChanging(value);
					this.SendPropertyChanging();
					this._item_id = value;
					this.SendPropertyChanged("item_id");
					this.Onitem_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_qty", DbType="Int NOT NULL")]
		public int qty
		{
			get
			{
				return this._qty;
			}
			set
			{
				if ((this._qty != value))
				{
					this.OnqtyChanging(value);
					this.SendPropertyChanging();
					this._qty = value;
					this.SendPropertyChanged("qty");
					this.OnqtyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_harga", DbType="Int NOT NULL")]
		public int harga
		{
			get
			{
				return this._harga;
			}
			set
			{
				if ((this._harga != value))
				{
					this.OnhargaChanging(value);
					this.SendPropertyChanging();
					this._harga = value;
					this.SendPropertyChanged("harga");
					this.OnhargaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_total", DbType="Int NOT NULL")]
		public int total
		{
			get
			{
				return this._total;
			}
			set
			{
				if ((this._total != value))
				{
					this.OntotalChanging(value);
					this.SendPropertyChanging();
					this._total = value;
					this.SendPropertyChanged("total");
					this.OntotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.item")]
	public partial class item : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_item;
		
		private string _nama_item;
		
		private string _derkripsi;
		
		private int _harga;
		
		private System.Data.Linq.Binary _foto;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_itemChanging(int value);
    partial void Onid_itemChanged();
    partial void Onnama_itemChanging(string value);
    partial void Onnama_itemChanged();
    partial void OnderkripsiChanging(string value);
    partial void OnderkripsiChanged();
    partial void OnhargaChanging(int value);
    partial void OnhargaChanged();
    partial void OnfotoChanging(System.Data.Linq.Binary value);
    partial void OnfotoChanged();
    #endregion
		
		public item()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_item", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_item
		{
			get
			{
				return this._id_item;
			}
			set
			{
				if ((this._id_item != value))
				{
					this.Onid_itemChanging(value);
					this.SendPropertyChanging();
					this._id_item = value;
					this.SendPropertyChanged("id_item");
					this.Onid_itemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nama_item", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nama_item
		{
			get
			{
				return this._nama_item;
			}
			set
			{
				if ((this._nama_item != value))
				{
					this.Onnama_itemChanging(value);
					this.SendPropertyChanging();
					this._nama_item = value;
					this.SendPropertyChanged("nama_item");
					this.Onnama_itemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_derkripsi", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string derkripsi
		{
			get
			{
				return this._derkripsi;
			}
			set
			{
				if ((this._derkripsi != value))
				{
					this.OnderkripsiChanging(value);
					this.SendPropertyChanging();
					this._derkripsi = value;
					this.SendPropertyChanged("derkripsi");
					this.OnderkripsiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_harga", DbType="Int NOT NULL")]
		public int harga
		{
			get
			{
				return this._harga;
			}
			set
			{
				if ((this._harga != value))
				{
					this.OnhargaChanging(value);
					this.SendPropertyChanging();
					this._harga = value;
					this.SendPropertyChanged("harga");
					this.OnhargaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_foto", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary foto
		{
			get
			{
				return this._foto;
			}
			set
			{
				if ((this._foto != value))
				{
					this.OnfotoChanging(value);
					this.SendPropertyChanging();
					this._foto = value;
					this.SendPropertyChanged("foto");
					this.OnfotoChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[order]")]
	public partial class order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _order_id;
		
		private int _user_id;
		
		private int _buyer_id;
		
		private System.DateTime _tanggal_pemesanan;
		
		private System.DateTime _tanggal_pengambilan;
		
		private int _total_harga;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onorder_idChanging(int value);
    partial void Onorder_idChanged();
    partial void Onuser_idChanging(int value);
    partial void Onuser_idChanged();
    partial void Onbuyer_idChanging(int value);
    partial void Onbuyer_idChanged();
    partial void Ontanggal_pemesananChanging(System.DateTime value);
    partial void Ontanggal_pemesananChanged();
    partial void Ontanggal_pengambilanChanging(System.DateTime value);
    partial void Ontanggal_pengambilanChanged();
    partial void Ontotal_hargaChanging(int value);
    partial void Ontotal_hargaChanged();
    #endregion
		
		public order()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_order_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int order_id
		{
			get
			{
				return this._order_id;
			}
			set
			{
				if ((this._order_id != value))
				{
					this.Onorder_idChanging(value);
					this.SendPropertyChanging();
					this._order_id = value;
					this.SendPropertyChanged("order_id");
					this.Onorder_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="Int NOT NULL")]
		public int user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_buyer_id", DbType="Int NOT NULL")]
		public int buyer_id
		{
			get
			{
				return this._buyer_id;
			}
			set
			{
				if ((this._buyer_id != value))
				{
					this.Onbuyer_idChanging(value);
					this.SendPropertyChanging();
					this._buyer_id = value;
					this.SendPropertyChanged("buyer_id");
					this.Onbuyer_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tanggal_pemesanan", DbType="Date NOT NULL")]
		public System.DateTime tanggal_pemesanan
		{
			get
			{
				return this._tanggal_pemesanan;
			}
			set
			{
				if ((this._tanggal_pemesanan != value))
				{
					this.Ontanggal_pemesananChanging(value);
					this.SendPropertyChanging();
					this._tanggal_pemesanan = value;
					this.SendPropertyChanged("tanggal_pemesanan");
					this.Ontanggal_pemesananChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tanggal_pengambilan", DbType="Date NOT NULL")]
		public System.DateTime tanggal_pengambilan
		{
			get
			{
				return this._tanggal_pengambilan;
			}
			set
			{
				if ((this._tanggal_pengambilan != value))
				{
					this.Ontanggal_pengambilanChanging(value);
					this.SendPropertyChanging();
					this._tanggal_pengambilan = value;
					this.SendPropertyChanged("tanggal_pengambilan");
					this.Ontanggal_pengambilanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_total_harga", DbType="Int NOT NULL")]
		public int total_harga
		{
			get
			{
				return this._total_harga;
			}
			set
			{
				if ((this._total_harga != value))
				{
					this.Ontotal_hargaChanging(value);
					this.SendPropertyChanging();
					this._total_harga = value;
					this.SendPropertyChanged("total_harga");
					this.Ontotal_hargaChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.pembayaran")]
	public partial class pembayaran : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_pembayaran;
		
		private int _id_order;
		
		private System.DateTime _tanggal_pembayaran;
		
		private int _total_harga;
		
		private int _uang_pembeli;
		
		private int _kembalian;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_pembayaranChanging(int value);
    partial void Onid_pembayaranChanged();
    partial void Onid_orderChanging(int value);
    partial void Onid_orderChanged();
    partial void Ontanggal_pembayaranChanging(System.DateTime value);
    partial void Ontanggal_pembayaranChanged();
    partial void Ontotal_hargaChanging(int value);
    partial void Ontotal_hargaChanged();
    partial void Onuang_pembeliChanging(int value);
    partial void Onuang_pembeliChanged();
    partial void OnkembalianChanging(int value);
    partial void OnkembalianChanged();
    #endregion
		
		public pembayaran()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_pembayaran", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_pembayaran
		{
			get
			{
				return this._id_pembayaran;
			}
			set
			{
				if ((this._id_pembayaran != value))
				{
					this.Onid_pembayaranChanging(value);
					this.SendPropertyChanging();
					this._id_pembayaran = value;
					this.SendPropertyChanged("id_pembayaran");
					this.Onid_pembayaranChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_order", DbType="Int NOT NULL")]
		public int id_order
		{
			get
			{
				return this._id_order;
			}
			set
			{
				if ((this._id_order != value))
				{
					this.Onid_orderChanging(value);
					this.SendPropertyChanging();
					this._id_order = value;
					this.SendPropertyChanged("id_order");
					this.Onid_orderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tanggal_pembayaran", DbType="Date NOT NULL")]
		public System.DateTime tanggal_pembayaran
		{
			get
			{
				return this._tanggal_pembayaran;
			}
			set
			{
				if ((this._tanggal_pembayaran != value))
				{
					this.Ontanggal_pembayaranChanging(value);
					this.SendPropertyChanging();
					this._tanggal_pembayaran = value;
					this.SendPropertyChanged("tanggal_pembayaran");
					this.Ontanggal_pembayaranChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_total_harga", DbType="Int NOT NULL")]
		public int total_harga
		{
			get
			{
				return this._total_harga;
			}
			set
			{
				if ((this._total_harga != value))
				{
					this.Ontotal_hargaChanging(value);
					this.SendPropertyChanging();
					this._total_harga = value;
					this.SendPropertyChanged("total_harga");
					this.Ontotal_hargaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uang_pembeli", DbType="Int NOT NULL")]
		public int uang_pembeli
		{
			get
			{
				return this._uang_pembeli;
			}
			set
			{
				if ((this._uang_pembeli != value))
				{
					this.Onuang_pembeliChanging(value);
					this.SendPropertyChanging();
					this._uang_pembeli = value;
					this.SendPropertyChanged("uang_pembeli");
					this.Onuang_pembeliChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kembalian", DbType="Int NOT NULL")]
		public int kembalian
		{
			get
			{
				return this._kembalian;
			}
			set
			{
				if ((this._kembalian != value))
				{
					this.OnkembalianChanging(value);
					this.SendPropertyChanging();
					this._kembalian = value;
					this.SendPropertyChanged("kembalian");
					this.OnkembalianChanged();
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