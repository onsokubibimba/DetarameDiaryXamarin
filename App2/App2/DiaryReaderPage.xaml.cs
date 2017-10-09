using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DiaryReaderPage : ContentPage
	{
        readonly TodoRepository _Td = new TodoRepository(); // <-1
        public IEnumerable<TodoItem> DiaryItems { get; set; }

        public DiaryReaderPage (int Did)
		{
			InitializeComponent ();

            DiaryItems = _Td.GetItemById(Did);

            lblWeather.Text = DiaryItems.First().Weather;
            lblWhen.Text = DiaryItems.First().When;
            lblWhere.Text = DiaryItems.First().Where;
            lblWho.Text = DiaryItems.First().Who;
            lblHow.Text = DiaryItems.First().How;
            lblWhat.Text = DiaryItems.First().What;
            lblDo.Text = DiaryItems.First().Do;
            lblFeeling.Text = DiaryItems.First().Feeling;

        }
    }
}