using Helpers;
using LearningAndTrainingTasks.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace LearningAndTrainingTasks.ViewModels
{
    public class ShellViewModel
    {
        public ObservableCollection<string> LstMensagemStatus { get; set; } = new ObservableCollection<string>();
        private List<TxtFile> Files = new List<TxtFile>();

        public void btnCreateFiles()
        {
            Files.Add(new TxtFile { Path = @"C:\Teste\File1.txt", TextConent = "File1" });
            Files.Add(new TxtFile { Path = @"C:\Teste\File2.txt", TextConent = "File2" });
            Files.Add(new TxtFile { Path = @"C:\Teste\File3.txt", TextConent = "File3" });

            foreach(TxtFile file in Files)
                this.CreateFiles(file);
        }

        private void CreateFiles(TxtFile file)
        {
            if (FileHelper.CreateFile(file.Path, file.TextConent))
                this.AdicionarMensagemStatus($"Arquivo '{file.Path}' criado com sucesso");
            else
                this.AdicionarMensagemStatus("Falha ao criar arquivo. ");
        }

        private void AdicionarMensagemStatus(string Mensagem)
        {
            string Msg;

            Msg = $"{DateTime.Now.ToString()} - {Mensagem}";
            this.LstMensagemStatus.Add(Msg);
        }
    }
}
