using System.IO;

namespace Otus.Delegates.Application.Services
{
    public class FileStorageService
    {
        public delegate void FileFoundEventHandler(object sender, FileArgs e);

        public event FileFoundEventHandler FileFound;

        public void FileSearch(string dirPath)
        {
            var dir = new DirectoryInfo(dirPath);

            if (dir == null) throw new DirectoryNotFoundException();

            var files = dir.GetFiles("*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                FileFound?.Invoke(this, new FileArgs(file.Name));
            }
        }
    }
}