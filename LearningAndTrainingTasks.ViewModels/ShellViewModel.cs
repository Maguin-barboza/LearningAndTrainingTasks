using Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

using LearningAndTrainingTasks.Models;


namespace LearningAndTrainingTasks.ViewModels
{
    public class ShellViewModel
    {
        public ObservableCollection<string> LstMensagemStatus { get; set; } = new ObservableCollection<string>();

        public void btnCreateFiles()
        {
            TxtFile txtFile = new TxtFile();
            txtFile.Path = @"C:\Teste\File1.txt";
            txtFile.TextConent = "File1";

            if (FileHelper.CreateFile(txtFile.Path, txtFile.TextConent))
                AdicionarMensagemStatus($"Arquivo '{txtFile.Path}' criado com sucesso");
            else
                AdicionarMensagemStatus("Falha ao criar arquivo. ");
        }

        private void AdicionarMensagemStatus(string Mensagem)
        {
            string Msg;

            Msg = $"{DateTime.Now.ToString()} - {Mensagem}";
            LstMensagemStatus.Add(Msg);
        }
    }
}
