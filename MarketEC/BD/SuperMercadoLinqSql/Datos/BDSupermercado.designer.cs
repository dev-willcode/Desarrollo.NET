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

namespace Datos
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MarketECUADOR")]
	public partial class BDSupermercadoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertCATEGORIA(CATEGORIA instance);
    partial void UpdateCATEGORIA(CATEGORIA instance);
    partial void DeleteCATEGORIA(CATEGORIA instance);
    #endregion
		
		public BDSupermercadoDataContext() : 
				base(global::Datos.Properties.Settings.Default.MarketECUADORConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BDSupermercadoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BDSupermercadoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BDSupermercadoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BDSupermercadoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CATEGORIA> CATEGORIA
		{
			get
			{
				return this.GetTable<CATEGORIA>();
			}
		}
		
		public System.Data.Linq.Table<VProdCategoria> VProdCategoria
		{
			get
			{
				return this.GetTable<VProdCategoria>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.cp_ActualizarProveedor")]
		public int cp_ActualizarProveedor([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdProveedor", DbType="Int")] System.Nullable<int> idProveedor, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CedProveedor", DbType="VarChar(13)")] string cedProveedor, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(40)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Representante", DbType="VarChar(30)")] string representante, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Direccion", DbType="VarChar(60)")] string direccion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ciudad", DbType="VarChar(15)")] string ciudad, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Telefono", DbType="VarChar(15)")] string telefono, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fax", DbType="VarChar(15)")] string fax)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idProveedor, cedProveedor, nombre, representante, direccion, ciudad, telefono, fax);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.cp_EliminarProveedor")]
		public int cp_EliminarProveedor([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdProveedor", DbType="Int")] System.Nullable<int> idProveedor)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idProveedor);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.cp_InsertarProveedor")]
		public int cp_InsertarProveedor([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdProveedor", DbType="Int")] System.Nullable<int> idProveedor, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CedProveedor", DbType="VarChar(13)")] string cedProveedor, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(40)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Representante", DbType="VarChar(30)")] string representante, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Direccion", DbType="VarChar(60)")] string direccion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ciudad", DbType="VarChar(15)")] string ciudad, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Telefono", DbType="VarChar(15)")] string telefono, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fax", DbType="VarChar(15)")] string fax)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idProveedor, cedProveedor, nombre, representante, direccion, ciudad, telefono, fax);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.cp_ListaProveedoresFiltro")]
		public ISingleResult<cp_ListaProveedoresFiltroResult> cp_ListaProveedoresFiltro([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Valor", DbType="VarChar(40)")] string valor)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), valor);
			return ((ISingleResult<cp_ListaProveedoresFiltroResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.cp_EliminarCategoria")]
		public int cp_EliminarCategoria([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ide", DbType="Int")] System.Nullable<int> ide)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), ide);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.cp_ActualizarCategoria")]
		public int cp_ActualizarCategoria([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ide", DbType="Int")] System.Nullable<int> ide, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cat", DbType="VarChar(30)")] string cat, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Descp", DbType="VarChar(40)")] string descp)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), ide, cat, descp);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.cp_InsertarCategoria")]
		public int cp_InsertarCategoria([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cat", DbType="VarChar(30)")] string cat, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Descp", DbType="VarChar(40)")] string descp)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), cat, descp);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.cp_ListarCategoria_Filtro")]
		public ISingleResult<cp_ListarCategoria_FiltroResult> cp_ListarCategoria_Filtro([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Valor", DbType="VarChar(40)")] string valor)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), valor);
			return ((ISingleResult<cp_ListarCategoria_FiltroResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.cp_ActualizarProducto")]
		public int cp_ActualizarProducto([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdeProd", DbType="Int")] System.Nullable<int> ideProd, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdeCat", DbType="Int")] System.Nullable<int> ideCat, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nom", DbType="VarChar(40)")] string nom, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="UnidadMedida", DbType="VarChar(30)")] string unidadMedida, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PrecioProveedor", DbType="Money")] System.Nullable<decimal> precioProveedor, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PrecioVenta", DbType="Money")] System.Nullable<decimal> precioVenta, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="StockAct", DbType="SmallInt")] System.Nullable<short> stockAct, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="StockMin", DbType="SmallInt")] System.Nullable<short> stockMin)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), ideProd, ideCat, nom, unidadMedida, precioProveedor, precioVenta, stockAct, stockMin);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.cp_EliminarPoducto")]
		public int cp_EliminarPoducto([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdeProd", DbType="Int")] System.Nullable<int> ideProd)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), ideProd);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.cp_InsertarProducto")]
		public int cp_InsertarProducto([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdeProd", DbType="Int")] System.Nullable<int> ideProd, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IdeCat", DbType="Int")] System.Nullable<int> ideCat, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nom", DbType="VarChar(40)")] string nom, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="UnidadMedida", DbType="VarChar(30)")] string unidadMedida, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PrecioProveedor", DbType="Money")] System.Nullable<decimal> precioProveedor, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PrecioVentan", DbType="Money")] System.Nullable<decimal> precioVentan, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="StockAct", DbType="SmallInt")] System.Nullable<short> stockAct, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="StockMin", DbType="SmallInt")] System.Nullable<short> stockMin)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), ideProd, ideCat, nom, unidadMedida, precioProveedor, precioVentan, stockAct, stockMin);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.cp_ListarProducto_Filtro")]
		public ISingleResult<cp_ListarProducto_FiltroResult> cp_ListarProducto_Filtro([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Valor", DbType="VarChar(40)")] string valor)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), valor);
			return ((ISingleResult<cp_ListarProducto_FiltroResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.cp_listarProducto")]
		public ISingleResult<cp_listarProductoResult> cp_listarProducto()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<cp_listarProductoResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CATEGORIA")]
	public partial class CATEGORIA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdCategoria;
		
		private string _Categoria1;
		
		private string _Descripcion;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdCategoriaChanging(int value);
    partial void OnIdCategoriaChanged();
    partial void OnCategoria1Changing(string value);
    partial void OnCategoria1Changed();
    partial void OnDescripcionChanging(string value);
    partial void OnDescripcionChanged();
    #endregion
		
		public CATEGORIA()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdCategoria", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdCategoria
		{
			get
			{
				return this._IdCategoria;
			}
			set
			{
				if ((this._IdCategoria != value))
				{
					this.OnIdCategoriaChanging(value);
					this.SendPropertyChanging();
					this._IdCategoria = value;
					this.SendPropertyChanged("IdCategoria");
					this.OnIdCategoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Categoria", Storage="_Categoria1", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Categoria1
		{
			get
			{
				return this._Categoria1;
			}
			set
			{
				if ((this._Categoria1 != value))
				{
					this.OnCategoria1Changing(value);
					this.SendPropertyChanging();
					this._Categoria1 = value;
					this.SendPropertyChanged("Categoria1");
					this.OnCategoria1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(40)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this.OnDescripcionChanging(value);
					this.SendPropertyChanging();
					this._Descripcion = value;
					this.SendPropertyChanged("Descripcion");
					this.OnDescripcionChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.VProdCategoria")]
	public partial class VProdCategoria
	{
		
		private int _IdProducto;
		
		private string _Categoria;
		
		private string _Nombre;
		
		private string _UnidadMedida;
		
		private System.Nullable<decimal> _PrecioProveedor;
		
		private System.Nullable<short> _StockActual;
		
		private System.Nullable<short> _StockMinimo;
		
		private System.Nullable<decimal> _PrecioVenta;
		
		public VProdCategoria()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdProducto", DbType="Int NOT NULL")]
		public int IdProducto
		{
			get
			{
				return this._IdProducto;
			}
			set
			{
				if ((this._IdProducto != value))
				{
					this._IdProducto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Categoria", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Categoria
		{
			get
			{
				return this._Categoria;
			}
			set
			{
				if ((this._Categoria != value))
				{
					this._Categoria = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnidadMedida", DbType="VarChar(30)")]
		public string UnidadMedida
		{
			get
			{
				return this._UnidadMedida;
			}
			set
			{
				if ((this._UnidadMedida != value))
				{
					this._UnidadMedida = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrecioProveedor", DbType="Money")]
		public System.Nullable<decimal> PrecioProveedor
		{
			get
			{
				return this._PrecioProveedor;
			}
			set
			{
				if ((this._PrecioProveedor != value))
				{
					this._PrecioProveedor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StockActual", DbType="SmallInt")]
		public System.Nullable<short> StockActual
		{
			get
			{
				return this._StockActual;
			}
			set
			{
				if ((this._StockActual != value))
				{
					this._StockActual = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StockMinimo", DbType="SmallInt")]
		public System.Nullable<short> StockMinimo
		{
			get
			{
				return this._StockMinimo;
			}
			set
			{
				if ((this._StockMinimo != value))
				{
					this._StockMinimo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrecioVenta", DbType="Money")]
		public System.Nullable<decimal> PrecioVenta
		{
			get
			{
				return this._PrecioVenta;
			}
			set
			{
				if ((this._PrecioVenta != value))
				{
					this._PrecioVenta = value;
				}
			}
		}
	}
	
	public partial class cp_ListaProveedoresFiltroResult
	{
		
		private int _IdProveedor;
		
		private string _CedProveedor;
		
		private string _Nombre;
		
		private string _Representante;
		
		private string _Direccion;
		
		private string _Ciudad;
		
		private string _Telefono;
		
		private string _Fax;
		
		public cp_ListaProveedoresFiltroResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdProveedor", DbType="Int NOT NULL")]
		public int IdProveedor
		{
			get
			{
				return this._IdProveedor;
			}
			set
			{
				if ((this._IdProveedor != value))
				{
					this._IdProveedor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CedProveedor", DbType="VarChar(10)")]
		public string CedProveedor
		{
			get
			{
				return this._CedProveedor;
			}
			set
			{
				if ((this._CedProveedor != value))
				{
					this._CedProveedor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(40)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Representante", DbType="VarChar(30)")]
		public string Representante
		{
			get
			{
				return this._Representante;
			}
			set
			{
				if ((this._Representante != value))
				{
					this._Representante = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(60)")]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this._Direccion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ciudad", DbType="VarChar(15)")]
		public string Ciudad
		{
			get
			{
				return this._Ciudad;
			}
			set
			{
				if ((this._Ciudad != value))
				{
					this._Ciudad = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="VarChar(15)")]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this._Telefono = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fax", DbType="VarChar(15)")]
		public string Fax
		{
			get
			{
				return this._Fax;
			}
			set
			{
				if ((this._Fax != value))
				{
					this._Fax = value;
				}
			}
		}
	}
	
	public partial class cp_ListarCategoria_FiltroResult
	{
		
		private int _IdCategoria;
		
		private string _Categoria;
		
		private string _Descripcion;
		
		public cp_ListarCategoria_FiltroResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdCategoria", DbType="Int NOT NULL")]
		public int IdCategoria
		{
			get
			{
				return this._IdCategoria;
			}
			set
			{
				if ((this._IdCategoria != value))
				{
					this._IdCategoria = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Categoria", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Categoria
		{
			get
			{
				return this._Categoria;
			}
			set
			{
				if ((this._Categoria != value))
				{
					this._Categoria = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(40)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
	}
	
	public partial class cp_ListarProducto_FiltroResult
	{
		
		private int _IdProducto;
		
		private string _Categoria;
		
		private string _Nombre;
		
		private string _UnidadMedida;
		
		private System.Nullable<decimal> _PrecioProveedor;
		
		private System.Nullable<short> _StockActual;
		
		private System.Nullable<short> _StockMinimo;
		
		private System.Nullable<decimal> _PrecioVenta;
		
		public cp_ListarProducto_FiltroResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdProducto", DbType="Int NOT NULL")]
		public int IdProducto
		{
			get
			{
				return this._IdProducto;
			}
			set
			{
				if ((this._IdProducto != value))
				{
					this._IdProducto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Categoria", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Categoria
		{
			get
			{
				return this._Categoria;
			}
			set
			{
				if ((this._Categoria != value))
				{
					this._Categoria = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnidadMedida", DbType="VarChar(30)")]
		public string UnidadMedida
		{
			get
			{
				return this._UnidadMedida;
			}
			set
			{
				if ((this._UnidadMedida != value))
				{
					this._UnidadMedida = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrecioProveedor", DbType="Money")]
		public System.Nullable<decimal> PrecioProveedor
		{
			get
			{
				return this._PrecioProveedor;
			}
			set
			{
				if ((this._PrecioProveedor != value))
				{
					this._PrecioProveedor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StockActual", DbType="SmallInt")]
		public System.Nullable<short> StockActual
		{
			get
			{
				return this._StockActual;
			}
			set
			{
				if ((this._StockActual != value))
				{
					this._StockActual = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StockMinimo", DbType="SmallInt")]
		public System.Nullable<short> StockMinimo
		{
			get
			{
				return this._StockMinimo;
			}
			set
			{
				if ((this._StockMinimo != value))
				{
					this._StockMinimo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrecioVenta", DbType="Money")]
		public System.Nullable<decimal> PrecioVenta
		{
			get
			{
				return this._PrecioVenta;
			}
			set
			{
				if ((this._PrecioVenta != value))
				{
					this._PrecioVenta = value;
				}
			}
		}
	}
	
	public partial class cp_listarProductoResult
	{
		
		private int _IdProducto;
		
		private int _IdCategoria;
		
		private string _Nombre;
		
		private string _UnidadMedida;
		
		private System.Nullable<decimal> _PrecioProveedor;
		
		private System.Nullable<short> _StockActual;
		
		private System.Nullable<short> _StockMinimo;
		
		private System.Nullable<decimal> _PrecioVenta;
		
		public cp_listarProductoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdProducto", DbType="Int NOT NULL")]
		public int IdProducto
		{
			get
			{
				return this._IdProducto;
			}
			set
			{
				if ((this._IdProducto != value))
				{
					this._IdProducto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdCategoria", DbType="Int NOT NULL")]
		public int IdCategoria
		{
			get
			{
				return this._IdCategoria;
			}
			set
			{
				if ((this._IdCategoria != value))
				{
					this._IdCategoria = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnidadMedida", DbType="VarChar(30)")]
		public string UnidadMedida
		{
			get
			{
				return this._UnidadMedida;
			}
			set
			{
				if ((this._UnidadMedida != value))
				{
					this._UnidadMedida = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrecioProveedor", DbType="Money")]
		public System.Nullable<decimal> PrecioProveedor
		{
			get
			{
				return this._PrecioProveedor;
			}
			set
			{
				if ((this._PrecioProveedor != value))
				{
					this._PrecioProveedor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StockActual", DbType="SmallInt")]
		public System.Nullable<short> StockActual
		{
			get
			{
				return this._StockActual;
			}
			set
			{
				if ((this._StockActual != value))
				{
					this._StockActual = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StockMinimo", DbType="SmallInt")]
		public System.Nullable<short> StockMinimo
		{
			get
			{
				return this._StockMinimo;
			}
			set
			{
				if ((this._StockMinimo != value))
				{
					this._StockMinimo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrecioVenta", DbType="Money")]
		public System.Nullable<decimal> PrecioVenta
		{
			get
			{
				return this._PrecioVenta;
			}
			set
			{
				if ((this._PrecioVenta != value))
				{
					this._PrecioVenta = value;
				}
			}
		}
	}
}
#pragma warning restore 1591