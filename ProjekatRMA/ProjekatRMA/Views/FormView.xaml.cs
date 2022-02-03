using ProjekatRMA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjekatRMA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormView : ContentPage
    {
        public FormView()
        {
            InitializeComponent();
            PozicijaPicker.ItemsSource = LeftToVote.PozicijaList;
            PozicijaPicker.SelectedIndex = 0;
            StrankaPicker.ItemsSource = LeftToVote.PozicijaList[PozicijaPicker.SelectedIndex].StrankaList;
            StrankaPicker.SelectedIndex = 0;
            KandidatPicker.ItemsSource = LeftToVote.PozicijaList[PozicijaPicker.SelectedIndex]
                                                   .StrankaList[StrankaPicker.SelectedIndex].KandidatList;
            KandidatPicker.SelectedIndex = 0;
            
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private void StrankaPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pickerIndex = PozicijaPicker.SelectedIndex;
            int sPickerIndex = StrankaPicker.SelectedIndex;
            if (pickerIndex != -1 && sPickerIndex != -1)
            {
                KandidatPicker.ItemsSource = LeftToVote.PozicijaList[pickerIndex]
                                                               .StrankaList[StrankaPicker.SelectedIndex].KandidatList;
                KandidatPicker.SelectedIndex = 0;
            }
        }

        private void PozicijaPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PozicijaPicker.SelectedIndex != -1 && StrankaPicker.SelectedIndex != -1 && KandidatPicker.SelectedIndex != -1)
            {
                StrankaPicker.ItemsSource = LeftToVote.PozicijaList[PozicijaPicker.SelectedIndex].StrankaList;
                StrankaPicker.SelectedIndex = 0;
                KandidatPicker.ItemsSource = LeftToVote.PozicijaList[PozicijaPicker.SelectedIndex]
                                                                    .StrankaList[StrankaPicker.SelectedIndex].KandidatList;
                KandidatPicker.SelectedIndex = 0;
            }
        }

        private void DajGlas_Clicked(object sender, EventArgs e)
        {
            if (PozicijaPicker.SelectedIndex != -1 && StrankaPicker.SelectedIndex != -1 && KandidatPicker.SelectedIndex != -1)
            {
                int index = PozicijaPicker.SelectedIndex;
                PozicijaPicker.SelectedIndex = -1;
                LeftToVote.Rezultati.Add(LeftToVote.PozicijaList[index].Name + ": " + LeftToVote.PozicijaList[index].StrankaList[StrankaPicker.SelectedIndex].Name + ", " + 
                                         LeftToVote.PozicijaList[index].StrankaList[StrankaPicker.SelectedIndex].KandidatList[KandidatPicker.SelectedIndex].FullName);
                LeftToVote.PozicijaList.RemoveAt(index);
                PozicijaPicker.ItemsSource = null;
                if (LeftToVote.PozicijaList.Count > 0)
                {
                    PozicijaPicker.ItemsSource = LeftToVote.PozicijaList;
                    PozicijaPicker.SelectedIndex = 0;
                }
                else
                {
                    LeftToVote.voted = true;
                    Navigation.PushAsync(new Final());
                }
            }
        }

        private void Nastavi_Clicked(object sender, EventArgs e)
        {
            LeftToVote.voted = true;
            Navigation.PushAsync(new Final());
        }
    }
}