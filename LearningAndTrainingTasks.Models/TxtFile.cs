using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace LearningAndTrainingTasks.Models
{
    public class TxtFile
    {
        public string Path { get; set; }
        public string TextContent { get; set; }



        public static void CreateFilesSync(int NumOfFilesToCreate)
        {
            CreateFiles(NumOfFilesToCreate);
        }

        public static async Task CreateFilesAsync(int NumOfFilesToCreate)
        {
            await Task.Run(() => CreateFiles(NumOfFilesToCreate));
        }

        private static void CreateFiles(int NumOfFilesToCreate)
        {
            List<TxtFile> Files = ReturnListOfFiles(NumOfFilesToCreate);

            foreach (TxtFile file in Files)
                CreateFile(file);
        }

        private static List<TxtFile> ReturnListOfFiles(int NumOfFilesToCreate)
        {
            List<TxtFile> Files = new List<TxtFile>();

            for (int i = 1; i < NumOfFilesToCreate; i++)
                Files.Add(new TxtFile { Path = @$"C:\Teste\File{i}.txt", TextContent = $"File{i}" });

            return Files;
        }

        public static void CreateFile(TxtFile file)
        {
            FileHelper.CreateFile(file.Path, file.TextContent);
        }
    }
}
