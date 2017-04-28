using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageListViewDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            contentList.ItemsSource = InitModel();
        }

        private List<Model> InitModel()
        {
            List<Model> list = new List<Model>();
            for (int i = 0; i < 20; i++)
            {
                list.Add(new Model
                {
                    Name = "Picture " + i,
                    Status = "active"
                });
            }
            return list;
        }
    }
}
