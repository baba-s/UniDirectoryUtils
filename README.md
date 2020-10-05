# UniDirectoryUtils

Dictionary 型に関係する汎用的な関数を管理するクラス

## 使用例

### 通常

```cs
using System.IO;
using UnityEditor;

public class Example
{
    [MenuItem( "Tools/Hoge" )]
    private static void Hoge()
    {
        var path = "Assets/Scripts/Example.Generated.cs";
        var dir  = Path.GetDirectoryName( path );

        Directory.CreateDirectory( dir );
        File.WriteAllText( path, "ピカチュウ" );
    }
}
```

### UniDirectoryUtils

```cs
using Kogane;
using System.IO;
using UnityEditor;

public class Example
{
    [MenuItem( "Tools/Hoge" )]
    private static void Hoge()
    {
        var path = "Assets/Scripts/Example.Generated.cs";

        DirectoryUtils.CreateDirectoryFromFilePath( path );
        File.WriteAllText( path, "ピカチュウ" );
    }
}
```
