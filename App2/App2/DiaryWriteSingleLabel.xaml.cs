using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DiaryWriteSingleLabel : ContentPage
	{

        private PhraseList _Ph;
        readonly TodoRepository _Td = new TodoRepository(); // <-1
        public IEnumerable<TodoItem> DiaryItems { get; set; }


        public DiaryWriteSingleLabel ()
		{
			InitializeComponent ();

            btnSave.IsEnabled = false;

            _Ph = new PhraseList();
        }

        private void BtnWriteOnClicked(object sender, EventArgs args)
        {

            Random random = new Random();
            int idx=0;

            idx = random.Next(_Ph.WeatherLists.Count);
            lblWeather.Text = _Ph.WeatherLists[idx].ItmString;

            idx = random.Next(_Ph.WhenLists.Count);
            lblWhen.Text = _Ph.WhenLists[idx].ItmString;

            idx = random.Next(_Ph.WhereLists.Count);
            lblWhere.Text = _Ph.WhereLists[idx].ItmString;

            idx = random.Next(_Ph.WhoLists.Count);
            lblWho.Text = _Ph.WhoLists[idx].ItmString;

            idx = random.Next(_Ph.HowLists.Count);
            lblHow.Text = _Ph.HowLists[idx].ItmString;

            idx = random.Next(_Ph.WhatLists.Count);
            lblWhat.Text = _Ph.WhatLists[idx].ItmString;

            idx = random.Next(_Ph.DoLists.Count);
            lblDo.Text = _Ph.DoLists[idx].ItmString;

            idx = random.Next(_Ph.FeelingLists.Count);
            lblFeeling.Text = _Ph.FeelingLists[idx].ItmString;

            btnWrite.Text = "書き直す";
            btnSave.IsEnabled = true;


        }

        private void BtnSaveOnClicked(object sender, EventArgs args)
        {

            string diarystring = lblWeather.Text + lblWhen.Text + lblWhere.Text + lblWho.Text + lblHow.Text + lblWhat.Text + lblDo.Text + lblFeeling.Text;

            TodoItem saveitm = new TodoItem { Weather = lblWeather.Text, When = lblWhen.Text, Where = lblWhere.Text, Who = lblWho.Text, How = lblHow.Text, What = lblWhat.Text, Do = lblDo.Text, Feeling = lblFeeling.Text, Diary = diarystring, CreatedAt = DateTime.Now.ToLocalTime(), Delete = false };

            int ret = _Td.SaveItem(saveitm);

            _Td.Commit();

        }


    }

}
