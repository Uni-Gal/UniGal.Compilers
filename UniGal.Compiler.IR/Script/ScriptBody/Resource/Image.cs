namespace UniGal.Compiler.IR.Script.Resource
{
	/// <summary>
	/// 图像资源
	/// </summary>
	public class Image : ResourceBase
	{

		/// <summary>
		/// 256级透明度
		/// </summary>
		public byte Alpha { get; init; } = 0;

		/// <summary>
		/// 宽，引擎自动确定时，值为0
		/// </summary>
		public readonly uint Width;
		/// <summary>
		/// 高，引擎自动确定时，值为0
		/// </summary>
		public readonly uint Height;
		/// <summary>
		/// 自动加载
		/// </summary>
		public bool AutoLoad { get; init; } = true;

		/// <summary>
		/// 创建图像资源
		/// </summary>
		/// <param name="id">图像ID</param>
		/// <param name="path">图像路径</param>
		/// <param name="w">宽</param>
		/// <param name="h">高</param>
		public Image(string id, FileSystemPath path, uint w, uint h) : base(id, path)
		{
			Width = w;
			Height = h;
		}
		/// <summary>
		/// 创建图像资源
		/// </summary>
		/// <param name="id">图像ID</param>
		/// <param name="path">图像路径</param>
		public Image(string id, FileSystemPath path) :base(id, path)
		{
			Width = 0;
			Height = 0;
		}
	}
}
