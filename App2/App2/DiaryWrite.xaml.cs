using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DiaryWrite : ContentPage
	{

        private ObservableCollection<Temptenki> WeatherLists { get; } = new ObservableCollection<Temptenki>();
        private ObservableCollection<Label> GenerateLabel = new ObservableCollection<Label>();
        private ObservableCollection<Label> GenerateLabelss = new ObservableCollection<Label>();



        public DiaryWrite()
        {
            InitializeComponent();

            WeatherLists.Add(new Temptenki { WeatherItm = "晴れ" });
            WeatherLists.Add(new Temptenki { WeatherItm = "曇り" });
            WeatherLists.Add(new Temptenki { WeatherItm = "雨" });

            WeatherLists.Add(WeatherLists.First<Temptenki>());
            WeatherLists.RemoveAt(0);

            this.lstTenki.ItemsSource = WeatherLists;

            lstTenki.TranslationX = lstTenki.X + 50;

            //int lengths = 5;

            //for (int i = 0; i < lengths; i++)
            //{
            //    GenerateLabelsss.Add(DiaryLabelCreate(i));
            //}

            //this.stkitu.Children.Add(GenerateLabelsss);

        }

        

        public Label DiaryLabelCreate(int cnt)
        {
                //Console.WriteLine(i);
                Label tmplbl = new Label();
            tmplbl.HeightRequest = 100;
            tmplbl.WidthRequest = 100;
            
                
                tmplbl.Text = "ぺすてぃま";

            

            return tmplbl;
        }
	}

    public class Temptenki
    {
        public string WeatherItm { get; set; }
    }
}