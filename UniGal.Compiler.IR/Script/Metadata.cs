using System.Globalization;
using System.Text;

namespace UniGal.Compiler.IR.Script
{
	/// <summary>
	/// 元数据信息
	/// </summary>
	public class Metadata : BasicElement
	{
		/// <summary>源引擎</summary>
		public string SourceEngine = string.Empty;
		/// <summary>目标引擎</summary>
		public string TargetEngine = string.Empty;

		/// <summary>源编码</summary>
		public Encoding SourceEncoding = Encoding.UTF8;
		/// <summary>目标编码，后端可以灵活处理</summary>
		public Encoding TargetEncoding = Encoding.UTF8;

		/// <summary>源文化信息，可选</summary>
		public CultureInfo? SourceCulture;
		/// <summary>目标文化信息，可选</summary>
		public CultureInfo? TargetCulture;
	}
}
