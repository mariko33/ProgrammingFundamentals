using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;


namespace _04_Files
{
    public class StartUp
    {
        public static void Main()
        {
            List<FileInRoot> rootFiles = new List<FileInRoot>();

            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                var inputArr = Console.ReadLine().Split(new[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);

                string root = inputArr[0];
                var fileInfo = inputArr.Last().Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                long size = long.Parse(fileInfo.Last());
                string fileName = fileInfo[0];

                FileInRoot fileCurr = new FileInRoot(root, fileName, size);
                rootFiles.Add(fileCurr);
            }

            Dictionary<string, long> resultFiles = new Dictionary<string, long>();

            var commandArr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string rootTarget = commandArr[2];
            string ext = commandArr[0];

            foreach (var f in rootFiles)
            {
                if (f.FileRoot == rootTarget && f.FileName.EndsWith(ext))
                {
                    resultFiles[f.FileName] = f.FileSize;
                }
            }

            if (resultFiles.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var pair in resultFiles
                    .OrderByDescending(kv => kv.Value)
                    .ThenBy(kv => kv.Key))
                {
                    Console.WriteLine($"{pair.Key} - {pair.Value} KB");
                }
            }
        }
    }


    public class FileInRoot
    {
        public FileInRoot(string fileRoot, string fileName, long fileSize)
        {
            this.FileRoot = fileRoot;
            this.FileName = fileName;
            this.FileSize = fileSize;
        }
        public string FileRoot { get; set; }
        public string FileName { get; set; }
        public long FileSize { get; set; }
    }
}
