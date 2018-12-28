using PoeHUD.Framework;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.FilesInMemory
{
	/// <summary>
	/// For debugging purposes
	/// </summary>
	public class GenericFilesInMemory : UniversalFileWrapper<GenericFileInMemory>
	{
		private readonly string _fileName;
		public GenericFilesInMemory(Memory m, string fileName, long address) : base(m, address)
		{
			_fileName = fileName;
		}

		public override string ToString()
		{
			return _fileName;
		}
	}
}