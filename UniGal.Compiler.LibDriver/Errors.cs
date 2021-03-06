using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniGal.Compiler.IR;

namespace UniGal.Compiler.LibDriver
{
	/// <summary>
	/// 编译组织器发出的错误
	/// </summary>
	public class CompilerDriverError : CompilerError
	{
		internal static readonly ErrorCode ice_basic_errc = new() { NumericCode = 9001, Serviety = ErrorServiety.CritialError };
		/// <summary>建议少用，标准没写的错误、警告可以先用这个</summary>
		internal CompilerDriverError(ushort n, ErrorServiety serviety, string explain, IEnumerable<string> msgs) : base(new(n,serviety), msgs)
		{
			Explaination = explain;
		}
		internal CompilerDriverError(ErrorCode errc, IEnumerable<string> msgs):
			base(errc, msgs)
		{
			
		}

		internal CompilerDriverError(IEnumerable<string> msgs):base(ice_basic_errc, msgs)
		{
			Explaination = "发生了严重的内部编译器错误";
		}
	}

	internal class CannotLoadFactory : CompilerDriverError
	{
		public CannotLoadFactory(string backendName, string engine,IEnumerable<string> msgs):
			base(new ErrorCode(9012, ErrorServiety.Warning), msgs)
		{
			Explaination = $"无法加载后端工厂：后端名称：{backendName}，面向引擎：{engine}。";
		}
	}

	internal class CannotLoadBackend : CompilerDriverError
	{
		public CannotLoadBackend(string filename, IEnumerable<string> msgs)
			:base(new(9011 ,ErrorServiety.Warning), msgs)
		{
			Explaination = $"无法加载后端程序集{filename}";
		}
	}
}
