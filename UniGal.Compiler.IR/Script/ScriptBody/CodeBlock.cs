using UniGal.Compiler.IR.Utilities;

namespace UniGal.Compiler.IR.Script.ScriptBody
{
	/// <summary>
	/// 引擎特定的代码片段
	/// </summary>
	public record CodeBlock(
		string Engine,
		string Language,
		string Content
		);
}
