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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CovidClients")]
public partial class CovidLINQDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertClient(Client instance);
  partial void UpdateClient(Client instance);
  partial void DeleteClient(Client instance);
  #endregion
	
	public CovidLINQDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CovidClientsConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public CovidLINQDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CovidLINQDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CovidLINQDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CovidLINQDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Client> Clients
	{
		get
		{
			return this.GetTable<Client>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Clients")]
public partial class Client : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _FullName;
	
	private string _TAZ;
	
	private string _Address;
	
	private System.DateTime _BirthDate;
	
	private string _Phone;
	
	private string _Mobile;
	
	private System.Nullable<System.DateTime> _Vac1Date;
	
	private string _Vac1Mnf;
	
	private System.Nullable<System.DateTime> _Vac2Date;
	
	private string _Vac2Mnf;
	
	private System.Nullable<System.DateTime> _Vac3Date;
	
	private string _Vac3Mnf;
	
	private System.Nullable<System.DateTime> _Vac4Date;
	
	private string _Vac4Mnf;
	
	private System.Nullable<System.DateTime> _PozitiveDate;
	
	private System.Nullable<System.DateTime> _RecoveryDate;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFullNameChanging(string value);
    partial void OnFullNameChanged();
    partial void OnTAZChanging(string value);
    partial void OnTAZChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnBirthDateChanging(System.DateTime value);
    partial void OnBirthDateChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnMobileChanging(string value);
    partial void OnMobileChanged();
    partial void OnVac1DateChanging(System.Nullable<System.DateTime> value);
    partial void OnVac1DateChanged();
    partial void OnVac1MnfChanging(string value);
    partial void OnVac1MnfChanged();
    partial void OnVac2DateChanging(System.Nullable<System.DateTime> value);
    partial void OnVac2DateChanged();
    partial void OnVac2MnfChanging(string value);
    partial void OnVac2MnfChanged();
    partial void OnVac3DateChanging(System.Nullable<System.DateTime> value);
    partial void OnVac3DateChanged();
    partial void OnVac3MnfChanging(string value);
    partial void OnVac3MnfChanged();
    partial void OnVac4DateChanging(System.Nullable<System.DateTime> value);
    partial void OnVac4DateChanged();
    partial void OnVac4MnfChanging(string value);
    partial void OnVac4MnfChanged();
    partial void OnPozitiveDateChanging(System.Nullable<System.DateTime> value);
    partial void OnPozitiveDateChanged();
    partial void OnRecoveryDateChanging(System.Nullable<System.DateTime> value);
    partial void OnRecoveryDateChanged();
    #endregion
	
	public Client()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string FullName
	{
		get
		{
			return this._FullName;
		}
		set
		{
			if ((this._FullName != value))
			{
				this.OnFullNameChanging(value);
				this.SendPropertyChanging();
				this._FullName = value;
				this.SendPropertyChanged("FullName");
				this.OnFullNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TAZ", DbType="NChar(9) NOT NULL", CanBeNull=false)]
	public string TAZ
	{
		get
		{
			return this._TAZ;
		}
		set
		{
			if ((this._TAZ != value))
			{
				this.OnTAZChanging(value);
				this.SendPropertyChanging();
				this._TAZ = value;
				this.SendPropertyChanged("TAZ");
				this.OnTAZChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
	public string Address
	{
		get
		{
			return this._Address;
		}
		set
		{
			if ((this._Address != value))
			{
				this.OnAddressChanging(value);
				this.SendPropertyChanging();
				this._Address = value;
				this.SendPropertyChanged("Address");
				this.OnAddressChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BirthDate", DbType="Date NOT NULL")]
	public System.DateTime BirthDate
	{
		get
		{
			return this._BirthDate;
		}
		set
		{
			if ((this._BirthDate != value))
			{
				this.OnBirthDateChanging(value);
				this.SendPropertyChanging();
				this._BirthDate = value;
				this.SendPropertyChanged("BirthDate");
				this.OnBirthDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NChar(10)")]
	public string Phone
	{
		get
		{
			return this._Phone;
		}
		set
		{
			if ((this._Phone != value))
			{
				this.OnPhoneChanging(value);
				this.SendPropertyChanging();
				this._Phone = value;
				this.SendPropertyChanged("Phone");
				this.OnPhoneChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobile", DbType="NChar(10)")]
	public string Mobile
	{
		get
		{
			return this._Mobile;
		}
		set
		{
			if ((this._Mobile != value))
			{
				this.OnMobileChanging(value);
				this.SendPropertyChanging();
				this._Mobile = value;
				this.SendPropertyChanged("Mobile");
				this.OnMobileChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vac1Date", DbType="Date")]
	public System.Nullable<System.DateTime> Vac1Date
	{
		get
		{
			return this._Vac1Date;
		}
		set
		{
			if ((this._Vac1Date != value))
			{
				this.OnVac1DateChanging(value);
				this.SendPropertyChanging();
				this._Vac1Date = value;
				this.SendPropertyChanged("Vac1Date");
				this.OnVac1DateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vac1Mnf", DbType="NChar(10)")]
	public string Vac1Mnf
	{
		get
		{
			return this._Vac1Mnf;
		}
		set
		{
			if ((this._Vac1Mnf != value))
			{
				this.OnVac1MnfChanging(value);
				this.SendPropertyChanging();
				this._Vac1Mnf = value;
				this.SendPropertyChanged("Vac1Mnf");
				this.OnVac1MnfChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vac2Date", DbType="Date")]
	public System.Nullable<System.DateTime> Vac2Date
	{
		get
		{
			return this._Vac2Date;
		}
		set
		{
			if ((this._Vac2Date != value))
			{
				this.OnVac2DateChanging(value);
				this.SendPropertyChanging();
				this._Vac2Date = value;
				this.SendPropertyChanged("Vac2Date");
				this.OnVac2DateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vac2Mnf", DbType="NChar(10)")]
	public string Vac2Mnf
	{
		get
		{
			return this._Vac2Mnf;
		}
		set
		{
			if ((this._Vac2Mnf != value))
			{
				this.OnVac2MnfChanging(value);
				this.SendPropertyChanging();
				this._Vac2Mnf = value;
				this.SendPropertyChanged("Vac2Mnf");
				this.OnVac2MnfChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vac3Date", DbType="Date")]
	public System.Nullable<System.DateTime> Vac3Date
	{
		get
		{
			return this._Vac3Date;
		}
		set
		{
			if ((this._Vac3Date != value))
			{
				this.OnVac3DateChanging(value);
				this.SendPropertyChanging();
				this._Vac3Date = value;
				this.SendPropertyChanged("Vac3Date");
				this.OnVac3DateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vac3Mnf", DbType="NChar(10)")]
	public string Vac3Mnf
	{
		get
		{
			return this._Vac3Mnf;
		}
		set
		{
			if ((this._Vac3Mnf != value))
			{
				this.OnVac3MnfChanging(value);
				this.SendPropertyChanging();
				this._Vac3Mnf = value;
				this.SendPropertyChanged("Vac3Mnf");
				this.OnVac3MnfChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vac4Date", DbType="Date")]
	public System.Nullable<System.DateTime> Vac4Date
	{
		get
		{
			return this._Vac4Date;
		}
		set
		{
			if ((this._Vac4Date != value))
			{
				this.OnVac4DateChanging(value);
				this.SendPropertyChanging();
				this._Vac4Date = value;
				this.SendPropertyChanged("Vac4Date");
				this.OnVac4DateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vac4Mnf", DbType="NChar(10)")]
	public string Vac4Mnf
	{
		get
		{
			return this._Vac4Mnf;
		}
		set
		{
			if ((this._Vac4Mnf != value))
			{
				this.OnVac4MnfChanging(value);
				this.SendPropertyChanging();
				this._Vac4Mnf = value;
				this.SendPropertyChanged("Vac4Mnf");
				this.OnVac4MnfChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PozitiveDate", DbType="Date")]
	public System.Nullable<System.DateTime> PozitiveDate
	{
		get
		{
			return this._PozitiveDate;
		}
		set
		{
			if ((this._PozitiveDate != value))
			{
				this.OnPozitiveDateChanging(value);
				this.SendPropertyChanging();
				this._PozitiveDate = value;
				this.SendPropertyChanged("PozitiveDate");
				this.OnPozitiveDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecoveryDate", DbType="Date")]
	public System.Nullable<System.DateTime> RecoveryDate
	{
		get
		{
			return this._RecoveryDate;
		}
		set
		{
			if ((this._RecoveryDate != value))
			{
				this.OnRecoveryDateChanging(value);
				this.SendPropertyChanging();
				this._RecoveryDate = value;
				this.SendPropertyChanged("RecoveryDate");
				this.OnRecoveryDateChanged();
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
#pragma warning restore 1591
