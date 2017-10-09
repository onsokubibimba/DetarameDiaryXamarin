using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.Generic;

namespace App2
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage1 : ContentPage
    {
        readonly TodoRepository _Td = new TodoRepository(); // <-1
        public IEnumerable<TodoItem> DiaryItems { get; set; }

        public ListViewPage1()
        {
            InitializeComponent();

            DiaryItems = _Td.GetItems();

            this.lstDiary.ItemsSource = DiaryItems;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            var itm = (TodoItem)e.Item;
            //var itm = (TodoItem)e.SelectedItem;
            

            //int aaa = itm.Id;
            //await DisplayAlert("Item Tapped", aaa.ToString(), "OK");


            await Navigation.PushAsync(new DiaryReaderPage(itm.Id), true);

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        //private void BtnOnClickedSearch(object sender, EventArgs args)
        //{
        //   DiaryItems = _Td.GetItems();
        //
        //    this.lstDiary.ItemsSource = DiaryItems;
            //await Navigation.PushAsync(new ListViewPage1(), true);


//        }

        //private void BtnOnClickedSave(object sender, EventArgs args)
        //{

        //    TodoItem saveitm = new TodoItem { Diary = "あ", CreatedAt = DateTime.Now.ToLocalTime(), Delete = false };


        //    int ret = _Td.SaveItem(saveitm);

        //    _Td.Commit();
        //    //if (ret == 0)
        //    //{

        //    //}

        //}
    }
}