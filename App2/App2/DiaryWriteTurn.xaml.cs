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
	public partial class DiaryWriteTurn : ContentPage
	{

        private PhraseList _Ph;
        readonly TodoRepository _Td = new TodoRepository(); // <-1
        public IEnumerable<TodoItem> DiaryItems { get; set; }


        private int Susumi = 0;
        private bool Ugoku = false;

        public DiaryWriteTurn ()
		{
			InitializeComponent ();

            btnSave.IsEnabled = false;

            _Ph = new PhraseList();

        }

        private void BtnSaveOnClicked(object sender, EventArgs args)
        {

            string diarystring = lblWeather.Text + lblWhen.Text + lblWhere.Text + lblWho.Text + lblHow.Text + lblWhat.Text + lblDo.Text + lblFeeling.Text;

            TodoItem saveitm = new TodoItem { Weather = lblWeather.Text, When = lblWhen.Text, Where = lblWhere.Text, Who = lblWho.Text, How = lblHow.Text, What = lblWhat.Text, Do = lblDo.Text, Feeling = lblFeeling.Text, Diary = diarystring, CreatedAt = DateTime.Now.ToLocalTime(), Delete = false };

            int ret = _Td.SaveItem(saveitm);

            _Td.Commit();

            DependencyService.Get<IHelpMsg>().Show("日記帳に残しました");


        }

        private void BtnWriteOnClicked(object sender, EventArgs args)
        {

            Susumi++;

            if (Susumi < 9)
            {
                Ugoku = true;
                TextLooper();

            } else
            {
                Ugoku = false;
                btnWrite.IsEnabled = false;
                btnSave.IsEnabled = true;
            }

        }

        private void TextLooper()
        {

            if (Ugoku)
            {


                switch (Susumi)
                {
                    case 1:
                        Device.StartTimer(new TimeSpan(3000), () => {
                            // do something every 2000 milliseconds

                            Random random = new Random();
                            int idx = 0;


                            Device.BeginInvokeOnMainThread(() => {

                                idx = random.Next(_Ph.WeatherLists.Count);
                                lblWeather.Text = _Ph.WeatherLists[idx].ItmString;
                            });


                            return (Susumi==1); // runs again, or false to stop
                        });
                        break;
                    case 2:
                        Device.StartTimer(new TimeSpan(3000), () => {
                            // do something every 2000 milliseconds

                            Random random = new Random();
                            int idx = 0;

                            Device.BeginInvokeOnMainThread(() => {

                                idx = random.Next(_Ph.WhenLists.Count);
                                lblWhen.Text = _Ph.WhenLists[idx].ItmString;
                            });
                            return (Susumi == 2); // runs again, or false to stop
                        });
                        break;

                    case 3:
                        Device.StartTimer(new TimeSpan(3000), () => {
                            // do something every 2000 milliseconds

                            Random random = new Random();
                            int idx = 0;


                            Device.BeginInvokeOnMainThread(() => {

                                idx = random.Next(_Ph.WhereLists.Count);
                                lblWhere.Text = _Ph.WhereLists[idx].ItmString;

                            });
                            return (Susumi == 3); // runs again, or false to stop
                        });

                        break;

                    case 4:
                        Device.StartTimer(new TimeSpan(3000), () => {
                            // do something every 2000 milliseconds

                            Random random = new Random();
                            int idx = 0;

                            Device.BeginInvokeOnMainThread(() => {

                                idx = random.Next(_Ph.WhoLists.Count);
                                lblWho.Text = _Ph.WhoLists[idx].ItmString;

                            });
                            return (Susumi == 4); // runs again, or false to stop
                        });

                        break;

                    case 5:
                        Device.StartTimer(new TimeSpan(3000), () => {
                            // do something every 2000 milliseconds

                            Random random = new Random();
                            int idx = 0;


                            Device.BeginInvokeOnMainThread(() => {

                                idx = random.Next(_Ph.HowLists.Count);
                                lblHow.Text = _Ph.HowLists[idx].ItmString;

                            });
                            return (Susumi == 5); // runs again, or false to stop
                        });

                        break;

                    case 6:
                        Device.StartTimer(new TimeSpan(3000), () => {
                            // do something every 2000 milliseconds

                            Random random = new Random();
                            int idx = 0;


                            Device.BeginInvokeOnMainThread(() => {

                                idx = random.Next(_Ph.WhatLists.Count);
                                lblWhat.Text = _Ph.WhatLists[idx].ItmString;

                            });
                            return (Susumi == 6); // runs again, or false to stop
                        });

                        break;

                    case 7:
                        Device.StartTimer(new TimeSpan(3000), () => {
                            // do something every 2000 milliseconds

                            Random random = new Random();
                            int idx = 0;


                            Device.BeginInvokeOnMainThread(() => {

                                idx = random.Next(_Ph.DoLists.Count);
                                lblDo.Text = _Ph.DoLists[idx].ItmString;

                            });
                            return (Susumi == 7); // runs again, or false to stop
                        });

                        break;

                    case 8:
                        Device.StartTimer(new TimeSpan(2000), () => {
                            // do something every 2000 milliseconds

                            Random random = new Random();
                            int idx = 0;


                            Device.BeginInvokeOnMainThread(() => {

                                idx = random.Next(_Ph.FeelingLists.Count);
                                lblFeeling.Text = _Ph.FeelingLists[idx].ItmString;
                            });
                            return (Susumi == 8); // runs again, or false to stop
                        });

                        break;

                    default:
                        break;
                }


            }

        } 

    }


}
