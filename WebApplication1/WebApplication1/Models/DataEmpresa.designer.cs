﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="empresa")]
	public partial class DataEmpresaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Insertarea(area instance);
    partial void Updatearea(area instance);
    partial void Deletearea(area instance);
    partial void Insertempleado(empleado instance);
    partial void Updateempleado(empleado instance);
    partial void Deleteempleado(empleado instance);
    #endregion
		
		public DataEmpresaDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["empresaConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataEmpresaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataEmpresaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataEmpresaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataEmpresaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<area> area
		{
			get
			{
				return this.GetTable<area>();
			}
		}
		
		public System.Data.Linq.Table<empleado> empleado
		{
			get
			{
				return this.GetTable<empleado>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Actualiza_Area")]
		public int SP_Actualiza_Area([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> codigo2, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string descripcion2)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), codigo2, descripcion2);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Buscar_Area")]
		public ISingleResult<SP_Buscar_AreaResult> SP_Buscar_Area([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> codigo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), codigo);
			return ((ISingleResult<SP_Buscar_AreaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Eliminar_Area")]
		public int SP_Eliminar_Area([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> codigo3)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), codigo3);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Insertar_Area")]
		public int SP_Insertar_Area([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string descripcion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), descripcion);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Listar_Area")]
		public ISingleResult<SP_Listar_AreaResult> SP_Listar_Area()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_Listar_AreaResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.area")]
	public partial class area : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _are_cod;
		
		private string _are_des;
		
		private EntitySet<empleado> _empleado;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onare_codChanging(int value);
    partial void Onare_codChanged();
    partial void Onare_desChanging(string value);
    partial void Onare_desChanged();
    #endregion
		
		public area()
		{
			this._empleado = new EntitySet<empleado>(new Action<empleado>(this.attach_empleado), new Action<empleado>(this.detach_empleado));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_are_cod", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int are_cod
		{
			get
			{
				return this._are_cod;
			}
			set
			{
				if ((this._are_cod != value))
				{
					this.Onare_codChanging(value);
					this.SendPropertyChanging();
					this._are_cod = value;
					this.SendPropertyChanged("are_cod");
					this.Onare_codChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_are_des", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string are_des
		{
			get
			{
				return this._are_des;
			}
			set
			{
				if ((this._are_des != value))
				{
					this.Onare_desChanging(value);
					this.SendPropertyChanging();
					this._are_des = value;
					this.SendPropertyChanged("are_des");
					this.Onare_desChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="area_empleado", Storage="_empleado", ThisKey="are_cod", OtherKey="are_cod")]
		public EntitySet<empleado> empleado
		{
			get
			{
				return this._empleado;
			}
			set
			{
				this._empleado.Assign(value);
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
		
		private void attach_empleado(empleado entity)
		{
			this.SendPropertyChanging();
			entity.area = this;
		}
		
		private void detach_empleado(empleado entity)
		{
			this.SendPropertyChanging();
			entity.area = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.empleado")]
	public partial class empleado : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _emp_cod;
		
		private string _emp_nom;
		
		private int _are_cod;
		
		private EntityRef<area> _area;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onemp_codChanging(int value);
    partial void Onemp_codChanged();
    partial void Onemp_nomChanging(string value);
    partial void Onemp_nomChanged();
    partial void Onare_codChanging(int value);
    partial void Onare_codChanged();
    #endregion
		
		public empleado()
		{
			this._area = default(EntityRef<area>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emp_cod", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int emp_cod
		{
			get
			{
				return this._emp_cod;
			}
			set
			{
				if ((this._emp_cod != value))
				{
					this.Onemp_codChanging(value);
					this.SendPropertyChanging();
					this._emp_cod = value;
					this.SendPropertyChanged("emp_cod");
					this.Onemp_codChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emp_nom", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string emp_nom
		{
			get
			{
				return this._emp_nom;
			}
			set
			{
				if ((this._emp_nom != value))
				{
					this.Onemp_nomChanging(value);
					this.SendPropertyChanging();
					this._emp_nom = value;
					this.SendPropertyChanged("emp_nom");
					this.Onemp_nomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_are_cod", DbType="Int NOT NULL")]
		public int are_cod
		{
			get
			{
				return this._are_cod;
			}
			set
			{
				if ((this._are_cod != value))
				{
					if (this._area.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onare_codChanging(value);
					this.SendPropertyChanging();
					this._are_cod = value;
					this.SendPropertyChanged("are_cod");
					this.Onare_codChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="area_empleado", Storage="_area", ThisKey="are_cod", OtherKey="are_cod", IsForeignKey=true)]
		public area area
		{
			get
			{
				return this._area.Entity;
			}
			set
			{
				area previousValue = this._area.Entity;
				if (((previousValue != value) 
							|| (this._area.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._area.Entity = null;
						previousValue.empleado.Remove(this);
					}
					this._area.Entity = value;
					if ((value != null))
					{
						value.empleado.Add(this);
						this._are_cod = value.are_cod;
					}
					else
					{
						this._are_cod = default(int);
					}
					this.SendPropertyChanged("area");
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
	
	public partial class SP_Buscar_AreaResult
	{
		
		private int _are_cod;
		
		private string _are_des;
		
		public SP_Buscar_AreaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_are_cod", DbType="Int NOT NULL")]
		public int are_cod
		{
			get
			{
				return this._are_cod;
			}
			set
			{
				if ((this._are_cod != value))
				{
					this._are_cod = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_are_des", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string are_des
		{
			get
			{
				return this._are_des;
			}
			set
			{
				if ((this._are_des != value))
				{
					this._are_des = value;
				}
			}
		}
	}
	
	public partial class SP_Listar_AreaResult
	{
		
		private int _are_cod;
		
		private string _are_des;
		
		public SP_Listar_AreaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_are_cod", DbType="Int NOT NULL")]
		public int are_cod
		{
			get
			{
				return this._are_cod;
			}
			set
			{
				if ((this._are_cod != value))
				{
					this._are_cod = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_are_des", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string are_des
		{
			get
			{
				return this._are_des;
			}
			set
			{
				if ((this._are_des != value))
				{
					this._are_des = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
