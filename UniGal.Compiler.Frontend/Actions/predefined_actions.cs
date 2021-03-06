using System;
using System.Collections.Generic;
using System.Xml;
using UniGal.Compiler.IR;
using UniGal.Compiler.IR.Script.ScriptBody;

namespace UniGal.Compiler.Frontend.Actions
{
	/// <summary>
	/// Action的实际解析函数
	/// </summary>
	public delegate ActionRecord ActionParseHandler(string name, IReadOnlyDictionary<string, string> args, string inner);

	/// <summary>
	/// 预定义的Action列表
	/// </summary>
	public static class PredefinedActions
	{
		private static Dictionary<string, ActionParseHandler>? predefined;

		/// <summary>
		/// 获取预定义的action解析函数列表
		/// </summary>
		/// <returns>预定义的action解析函数列表</returns>
		public static IReadOnlyDictionary<string, ActionParseHandler> Get()
		{
			if(predefined != null)
				return predefined;

			Dictionary<string, ActionParseHandler> ret = new(16);

			ret.Add("save_auto", PredefinedHandlers.argless);
			ret.Add("newline", PredefinedHandlers.argless);
			ret.Add("waitclick", PredefinedHandlers.argless);
			ret.Add("clear_text", PredefinedHandlers.argless);
			// TODO: 还差很多可以加的东西

			predefined = ret;
			return ret;
		}
	}

	internal static class PredefinedHandlers
	{
		private record ArglessAction : ActionRecord
		{

			public ArglessAction(string name, string inner):base(name, inner)
			{

			}
		}

		internal static ActionRecord argless(string name,IReadOnlyDictionary<string, string> args, string inner)
		{
			return new ArglessAction(name, inner);
		}
	}
}