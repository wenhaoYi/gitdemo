﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//     Support: http://www.cnblogs.com/huxj
//     Website: http://ITdos.com/Dos/ORM/Index.html
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace Dos.Model
{

	/// <summary>
	/// 实体类Led_count 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Led_count : Entity 
	{
		public Led_count():base("led_count") {}

		#region Model
		private int _Id;
		private string _Qp;
		private int _Total;
		private int _Good;
		private int _Bad;
		private int _Oldtotal;
		private int _Oldgood;
		private int _Oldbad;
		private DateTime _Ltime;
		private string _Shift;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int Id
		{
			get{ return _Id; }
			set
			{
				this.OnPropertyValueChange(_.Id,_Id,value);
				this._Id=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Qp
		{
			get{ return _Qp; }
			set
			{
				this.OnPropertyValueChange(_.Qp,_Qp,value);
				this._Qp=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Total
		{
			get{ return _Total; }
			set
			{
				this.OnPropertyValueChange(_.Total,_Total,value);
				this._Total=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Good
		{
			get{ return _Good; }
			set
			{
				this.OnPropertyValueChange(_.Good,_Good,value);
				this._Good=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Bad
		{
			get{ return _Bad; }
			set
			{
				this.OnPropertyValueChange(_.Bad,_Bad,value);
				this._Bad=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Oldtotal
		{
			get{ return _Oldtotal; }
			set
			{
				this.OnPropertyValueChange(_.Oldtotal,_Oldtotal,value);
				this._Oldtotal=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Oldgood
		{
			get{ return _Oldgood; }
			set
			{
				this.OnPropertyValueChange(_.Oldgood,_Oldgood,value);
				this._Oldgood=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Oldbad
		{
			get{ return _Oldbad; }
			set
			{
				this.OnPropertyValueChange(_.Oldbad,_Oldbad,value);
				this._Oldbad=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime Ltime
		{
			get{ return _Ltime; }
			set
			{
				this.OnPropertyValueChange(_.Ltime,_Ltime,value);
				this._Ltime=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Shift
		{
			get{ return _Shift; }
			set
			{
				this.OnPropertyValueChange(_.Shift,_Shift,value);
				this._Shift=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.Id;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.Id};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.Id,
				_.Qp,
				_.Total,
				_.Good,
				_.Bad,
				_.Oldtotal,
				_.Oldgood,
				_.Oldbad,
				_.Ltime,
				_.Shift};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._Qp,
				this._Total,
				this._Good,
				this._Bad,
				this._Oldtotal,
				this._Oldgood,
				this._Oldbad,
				this._Ltime,
				this._Shift};
		}
		#endregion

		#region _Field
		/// <summary>
		/// 字段信息
		/// </summary>
		public class _
		{
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*","led_count");
			/// <summary>
			/// auto_increment
			/// </summary>
			public readonly static Field Id = new Field("id","led_count","auto_increment");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Qp = new Field("qp","led_count","qp");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Total = new Field("total","led_count","total");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Good = new Field("good","led_count","good");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Bad = new Field("bad","led_count","bad");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Oldtotal = new Field("oldtotal","led_count","oldtotal");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Oldgood = new Field("oldgood","led_count","oldgood");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Oldbad = new Field("oldbad","led_count","oldbad");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Ltime = new Field("ltime","led_count","ltime");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Shift = new Field("shift","led_count","shift");
		}
		#endregion


	}
}
