using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitOrSvn
{
    public enum DirectoryType { None, Svn, Git };

    public class CheckDirectory
    {
        public static DirectoryType GetDirectoryType(string path)
        {
            if (string.IsNullOrEmpty(path))
                return DirectoryType.None;
            else if (Directory.Exists(Path.Combine(path, ".svn")))
                return DirectoryType.Svn;
            else if(Directory.Exists(Path.Combine(path, ".git")))
                return DirectoryType.Git;
            var directoryInfo = new DirectoryInfo(path);
            return GetDirectoryType(directoryInfo.Parent?.FullName);
        }
    }
}
