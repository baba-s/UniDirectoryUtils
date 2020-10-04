using JetBrains.Annotations;
using System.IO;

namespace Kogane
{
	public static class DirectoryUtils
	{
		[CanBeNull]
		public static DirectoryInfo CreateDirectoryFromFilePath( [NotNull] string filePath )
		{
			var path = Path.GetDirectoryName( filePath );
			if ( string.IsNullOrWhiteSpace( path ) ) return null;
			return Directory.CreateDirectory( path );
		}
	}
}