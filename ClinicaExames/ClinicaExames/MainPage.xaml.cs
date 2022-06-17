using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ClinicaExames.Services;
using System.Collections.ObjectModel;
using ClinicaExames.Models;

namespace ClinicaExames
{
    public partial class MainPage : ContentPage
    {
        private ClinicaService clinicaService;
        public ObservableCollection<Exames> exames1;
        public MainPage()
        {
            InitializeComponent();

            clinicaService = new ClinicaService();
            
            exames1 = new ObservableCollection<Exames>();

            lstExams.ItemsSource = exames1;

            getAllExams();



        }

        private async void getAllExams()
        {
            var exames = await clinicaService.GetAll();
            foreach (var exame in exames) 
            {
                exames1.Add(exame);
            }
        }
    }
}
