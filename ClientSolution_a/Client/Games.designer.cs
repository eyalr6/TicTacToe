#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="client_db")]
	public partial class GamesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTblStep(TblStep instance);
    partial void UpdateTblStep(TblStep instance);
    partial void DeleteTblStep(TblStep instance);
    partial void InsertTblGame(TblGame instance);
    partial void UpdateTblGame(TblGame instance);
    partial void DeleteTblGame(TblGame instance);
    #endregion
		
		public GamesDataContext() : 
				base(global::Client.Properties.Settings.Default.client_dbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public GamesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GamesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GamesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GamesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TblStep> TblSteps
		{
			get
			{
				return this.GetTable<TblStep>();
			}
		}
		
		public System.Data.Linq.Table<TblGame> TblGames
		{
			get
			{
				return this.GetTable<TblGame>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TblSteps")]
	public partial class TblStep : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _SrcCellRow;
		
		private int _SrcCellCol;
		
		private int _DstCellRow;
		
		private int _DstCellCol;
		
		private int _PieceToRemoveRow;
		
		private int _PieceToRemoveCol;
		
		private string _EndGameResult;
		
		private string _Player;
		
		private int _GameId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnSrcCellRowChanging(int value);
    partial void OnSrcCellRowChanged();
    partial void OnSrcCellColChanging(int value);
    partial void OnSrcCellColChanged();
    partial void OnDstCellRowChanging(int value);
    partial void OnDstCellRowChanged();
    partial void OnDstCellColChanging(int value);
    partial void OnDstCellColChanged();
    partial void OnPieceToRemoveRowChanging(int value);
    partial void OnPieceToRemoveRowChanged();
    partial void OnPieceToRemoveColChanging(int value);
    partial void OnPieceToRemoveColChanged();
    partial void OnEndGameResultChanging(string value);
    partial void OnEndGameResultChanged();
    partial void OnPlayerChanging(string value);
    partial void OnPlayerChanged();
    partial void OnGameIdChanging(int value);
    partial void OnGameIdChanged();
    #endregion
		
		public TblStep()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SrcCellRow", DbType="Int NOT NULL")]
		public int SrcCellRow
		{
			get
			{
				return this._SrcCellRow;
			}
			set
			{
				if ((this._SrcCellRow != value))
				{
					this.OnSrcCellRowChanging(value);
					this.SendPropertyChanging();
					this._SrcCellRow = value;
					this.SendPropertyChanged("SrcCellRow");
					this.OnSrcCellRowChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SrcCellCol", DbType="Int NOT NULL")]
		public int SrcCellCol
		{
			get
			{
				return this._SrcCellCol;
			}
			set
			{
				if ((this._SrcCellCol != value))
				{
					this.OnSrcCellColChanging(value);
					this.SendPropertyChanging();
					this._SrcCellCol = value;
					this.SendPropertyChanged("SrcCellCol");
					this.OnSrcCellColChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DstCellRow", DbType="Int NOT NULL")]
		public int DstCellRow
		{
			get
			{
				return this._DstCellRow;
			}
			set
			{
				if ((this._DstCellRow != value))
				{
					this.OnDstCellRowChanging(value);
					this.SendPropertyChanging();
					this._DstCellRow = value;
					this.SendPropertyChanged("DstCellRow");
					this.OnDstCellRowChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DstCellCol", DbType="Int NOT NULL")]
		public int DstCellCol
		{
			get
			{
				return this._DstCellCol;
			}
			set
			{
				if ((this._DstCellCol != value))
				{
					this.OnDstCellColChanging(value);
					this.SendPropertyChanging();
					this._DstCellCol = value;
					this.SendPropertyChanged("DstCellCol");
					this.OnDstCellColChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PieceToRemoveRow", DbType="Int NOT NULL")]
		public int PieceToRemoveRow
		{
			get
			{
				return this._PieceToRemoveRow;
			}
			set
			{
				if ((this._PieceToRemoveRow != value))
				{
					this.OnPieceToRemoveRowChanging(value);
					this.SendPropertyChanging();
					this._PieceToRemoveRow = value;
					this.SendPropertyChanged("PieceToRemoveRow");
					this.OnPieceToRemoveRowChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PieceToRemoveCol", DbType="Int NOT NULL")]
		public int PieceToRemoveCol
		{
			get
			{
				return this._PieceToRemoveCol;
			}
			set
			{
				if ((this._PieceToRemoveCol != value))
				{
					this.OnPieceToRemoveColChanging(value);
					this.SendPropertyChanging();
					this._PieceToRemoveCol = value;
					this.SendPropertyChanged("PieceToRemoveCol");
					this.OnPieceToRemoveColChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndGameResult", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string EndGameResult
		{
			get
			{
				return this._EndGameResult;
			}
			set
			{
				if ((this._EndGameResult != value))
				{
					this.OnEndGameResultChanging(value);
					this.SendPropertyChanging();
					this._EndGameResult = value;
					this.SendPropertyChanged("EndGameResult");
					this.OnEndGameResultChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Player", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Player
		{
			get
			{
				return this._Player;
			}
			set
			{
				if ((this._Player != value))
				{
					this.OnPlayerChanging(value);
					this.SendPropertyChanging();
					this._Player = value;
					this.SendPropertyChanged("Player");
					this.OnPlayerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GameId", DbType="Int NOT NULL")]
		public int GameId
		{
			get
			{
				return this._GameId;
			}
			set
			{
				if ((this._GameId != value))
				{
					this.OnGameIdChanging(value);
					this.SendPropertyChanging();
					this._GameId = value;
					this.SendPropertyChanged("GameId");
					this.OnGameIdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TblGames")]
	public partial class TblGame : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _GameId;
		
		private System.DateTime _Date;
		
		private string _Winner;
		
		private int _Id;
		
		private int _PlayerId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnGameIdChanging(int value);
    partial void OnGameIdChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnWinnerChanging(string value);
    partial void OnWinnerChanged();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnPlayerIdChanging(int value);
    partial void OnPlayerIdChanged();
    #endregion
		
		public TblGame()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GameId", DbType="Int NOT NULL")]
		public int GameId
		{
			get
			{
				return this._GameId;
			}
			set
			{
				if ((this._GameId != value))
				{
					this.OnGameIdChanging(value);
					this.SendPropertyChanging();
					this._GameId = value;
					this.SendPropertyChanged("GameId");
					this.OnGameIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Winner", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Winner
		{
			get
			{
				return this._Winner;
			}
			set
			{
				if ((this._Winner != value))
				{
					this.OnWinnerChanging(value);
					this.SendPropertyChanging();
					this._Winner = value;
					this.SendPropertyChanged("Winner");
					this.OnWinnerChanged();
				}
			}
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerId", DbType="Int NOT NULL")]
		public int PlayerId
		{
			get
			{
				return this._PlayerId;
			}
			set
			{
				if ((this._PlayerId != value))
				{
					this.OnPlayerIdChanging(value);
					this.SendPropertyChanging();
					this._PlayerId = value;
					this.SendPropertyChanged("PlayerId");
					this.OnPlayerIdChanged();
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
