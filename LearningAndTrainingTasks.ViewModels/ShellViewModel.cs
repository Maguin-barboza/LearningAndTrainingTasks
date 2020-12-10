using Helpers;
using LearningAndTrainingTasks.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace LearningAndTrainingTasks.ViewModels
{
    public class ShellViewModel
    {
        public ObservableCollection<string> LstMensagemStatus { get; set; } = new ObservableCollection<string>();
        private List<TxtFile> Files = new List<TxtFile>();

        public void btnCreateFilesSync()
        {
            Stopwatch Timer = new Stopwatch();
            Timer.Start();

            TxtFile.CreateFilesSync(7000);
            this.AdicionarMensagemStatus(Timer.ElapsedMilliseconds.ToString());
            Timer.Stop();
        }

        public async void btnCreateFilesAsync()
        {
            Stopwatch Timer = new Stopwatch();
            Timer.Start();

            await TxtFile.CreateFilesAsync(7000);
            this.AdicionarMensagemStatus(Timer.ElapsedMilliseconds.ToString());
            Timer.Stop();
        }

        private void AdicionarMensagemStatus(string Mensagem)
        {
            string Msg;

            Msg = $"{Mensagem}";
            this.LstMensagemStatus.Add(Msg);
        }
    }
}
