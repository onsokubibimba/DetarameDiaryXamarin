using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static App2.PhraseList;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DiaryWritePicker : ContentPage
	{

        private PhraseList _Ph;
        readonly TodoRepository _Td = new TodoRepository(); // <-1

        public DiaryWritePicker ()
		{
			InitializeComponent ();
            _Ph = new PhraseList();
            WeatherListCreate();
            WhenListCreate();
            WhoListCreate();
            WhereListCreate();
            HowListCreate();
            WhatListCreate();
            DoListCreate();
            FeelingListCreate();

            btnWrite.IsEnabled = false;

            

        }

        private void BtnSaveOnClicked(object sender, EventArgs args)
        {

            string diarystring = pkrWeather.SelectedItem.ToString() + pkrWhen.SelectedItem.ToString() + pkrWhere.SelectedItem.ToString() + pkrWho.SelectedItem.ToString() + pkrHow.SelectedItem.ToString() + pkrWhat.SelectedItem.ToString() + pkrDo.SelectedItem.ToString() + pkrFeeling.SelectedItem.ToString();

            TodoItem saveitm = new TodoItem { Weather = pkrWeather.SelectedItem.ToString(), When = pkrWhen.SelectedItem.ToString(), Where = pkrWhere.SelectedItem.ToString(), Who = pkrWho.SelectedItem.ToString(), How = pkrHow.SelectedItem.ToString(), What = pkrWhat.SelectedItem.ToString(), Do = pkrDo.SelectedItem.ToString(), Feeling = pkrFeeling.SelectedItem.ToString(), Diary = diarystring, CreatedAt = DateTime.Now.ToLocalTime(), Delete = false };

            int ret = _Td.SaveItem(saveitm);

            _Td.Commit();

            DependencyService.Get<IHelpMsg>().Show("日記帳に残しました");

        }

        #region
        //ピッカーをロックする
        private void PkrlockWeather(object sender, EventArgs args)
        {
           // this.pkrWeather.IsEnabled = false;
           
            if (pkrWeather.SelectedItem != null)
            {
                if (pkrWhen.SelectedItem != null) {
                    if (pkrWhat.SelectedItem != null)
                    {
                        if (pkrHow.SelectedItem != null)
                        {
                            if (pkrDo.SelectedItem != null)
                            {
                                if (pkrWho.SelectedItem != null)
                                {
                                    if (pkrFeeling.SelectedItem != null)
                                    {
                                        btnWrite.IsEnabled = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void PkrlockWhen(object sender, EventArgs args)
        {
            // this.pkrWhen.IsEnabled = false;
            PkrlockWeather(sender,args);
        }

        private void PkrlockWhat(object sender, EventArgs args)
        {
            // this.pkrWhat.IsEnabled = false;
            PkrlockWeather(sender, args);

        }

        private void PkrlockWho(object sender, EventArgs args)
        {
            // this.pkrWho.IsEnabled = false;
            PkrlockWeather(sender, args);

        }

        private void PkrlockHow(object sender, EventArgs args)
        {
            // this.pkrHow.IsEnabled = false;
            PkrlockWeather(sender, args);

        }

        private void PkrlockDo(object sender, EventArgs args)
        {
            // this.pkrDo.IsEnabled = false;
            PkrlockWeather(sender, args);

        }
        private void PkrlockFeeling(object sender, EventArgs args)
        {
            // this.pkrWeather.IsEnabled = false;
            PkrlockWeather(sender, args);

        }


        #endregion

        private void WeatherListCreate()
        {



        ObservableCollection<DiaryItemField> WeatherLists2;



            WeatherLists2 = new ObservableCollection<DiaryItemField>(_Ph.WeatherLists.OrderBy(i => Guid.NewGuid()));


            for (int i = 0; i <= 8; i++)
            {
                this.pkrWeather.Items.Add(WeatherLists2[i].ItmString);
            }
            pkrWeather.SelectedIndex = 0;


            //WeatherSet();

        }

        private void WeatherSet()
        {
        //    for (int i = 0; i <= 7; i++)
        //    {
        //        this.pkrWeather.Items.Add(WeatherLists[i].ItmString);
        //    }
        //    pkrWeather.SelectedIndex = 0;
            
        }

        private void WhenListCreate()
        {

            ObservableCollection<DiaryItemField> WhenLists2;

            WhenLists2 = new ObservableCollection<DiaryItemField>(_Ph.WhenLists.OrderBy(i => Guid.NewGuid()));

            for (int i = 0; i <= 7; i++)
            {
                this.pkrWhen.Items.Add(WhenLists2[i].ItmString);
            }
            pkrWhen.SelectedIndex = 0;

            //WhenSet();

        }

        private void WhenSet()
        {
        //    for (int i = 0; i <= 7; i++)
        //    {
        //        this.pkrWhen.Items.Add(WhenLists[i].ItmString);
        //    }
        //    pkrWhen.SelectedIndex = 0;

        }


        private void WhoListCreate()
        {
            ObservableCollection<DiaryItemField> WhoLists2;


            WhoLists2 = new ObservableCollection<DiaryItemField>(_Ph.WhoLists.OrderBy(InitialIndex => Guid.NewGuid()).ToArray());
            for (int i = 0; i <= 7; i++)
            {
                this.pkrWho.Items.Add(WhoLists2[i].ItmString);
            }
            pkrWho.SelectedIndex = 0;
            //WhoSet();

        }

        private void WhoSet()
        {
        //    for (int i = 0; i <= 7; i++)
        //    {
        //        this.pkrWho.Items.Add(WhoLists[i].ItmString);
        //    }
        //    pkrWho.SelectedIndex = 0;

        }


        private void WhereListCreate()
        {
            ObservableCollection<DiaryItemField> WhereLists2;


            WhereLists2 = new ObservableCollection<DiaryItemField>(_Ph.WhereLists.OrderBy(InitialIndex => Guid.NewGuid()));

            for (int i = 0; i <= 7; i++)
            {
                this.pkrWhere.Items.Add(WhereLists2[i].ItmString);
            }
            pkrWhere.SelectedIndex = 0;
            //WhereSet();

        }

        private void WhereSet()
        {
        //    for (int i = 0; i <= 7; i++)
        //    {
        //        this.pkrWhere.Items.Add(WhereLists[i].ItmString);
        //    }
        //    pkrWhere.SelectedIndex = 0;

        }

        private void HowListCreate()
        {
            ObservableCollection<DiaryItemField> HowLists2;

            HowLists2 = new ObservableCollection<DiaryItemField>(_Ph.HowLists.OrderBy(InitialIndex => Guid.NewGuid()));
            for (int i = 0; i <= 7; i++)
            {
                this.pkrHow.Items.Add(HowLists2[i].ItmString);
            }
            pkrHow.SelectedIndex = 0;
            //HowSet();

        }

        private void HowSet()
        {
        //    for (int i = 0; i <= 7; i++)
        //    {
        //        this.pkrHow.Items.Add(HowLists[i].ItmString);
        //    }
        //    pkrHow.SelectedIndex = 0;

        }


        private void WhatListCreate()
        {
            ObservableCollection<DiaryItemField> WhatLists2;


            WhatLists2 = new ObservableCollection<DiaryItemField>(_Ph.WhatLists.OrderBy(InitialIndex => Guid.NewGuid()));

            for (int i = 0; i <= 7; i++)
            {
                this.pkrWhat.Items.Add(WhatLists2[i].ItmString);
            }
            pkrWhat.SelectedIndex = 0;
            //WhatSet();

        }

        private void WhatSet()
        {
        //    for (int i = 0; i <= 7; i++)
        //    {
        //        this.pkrWhat.Items.Add(WhatLists[i].ItmString);
        //    }
        //    pkrWhat.SelectedIndex = 0;

        }


        private void DoListCreate()
        {
            ObservableCollection<DiaryItemField> DoLists2;

            DoLists2 = new ObservableCollection<DiaryItemField>(_Ph.DoLists.OrderBy(InitialIndex => Guid.NewGuid()));

            for (int i = 0; i <= 7; i++)
            {
                this.pkrDo.Items.Add(DoLists2[i].ItmString);
            }
            pkrDo.SelectedIndex = 0;
            //DoSet();

        }

        private void DoSet()
        {
        //    for (int i = 0; i <= 7; i++)
        //    {
        //        this.pkrDo.Items.Add(DoLists[i].ItmString);
        //    }
        //    pkrDo.SelectedIndex = 0;

        }


        private void FeelingListCreate()
        {
            ObservableCollection<DiaryItemField> FeelingLists2;


            FeelingLists2 = new ObservableCollection<DiaryItemField>(_Ph.FeelingLists.OrderBy(InitialIndex => Guid.NewGuid()));

            for (int i = 0; i <= 7; i++)
            {
                this.pkrFeeling.Items.Add(FeelingLists2[i].ItmString);
            }
            pkrFeeling.SelectedIndex = 0;
            //FeelingSet();

        }

        private void FeelingSet()
        {
        //    for (int i = 0; i <= 7; i++)
        //    {
        //        this.pkrFeeling.Items.Add(FeelingLists[i].ItmString);
        //    }
        //    pkrFeeling.SelectedIndex = 0;

        }

    }
}