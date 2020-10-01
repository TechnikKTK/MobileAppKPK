using KpKApp1.RestAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KpKApp1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Schedule : ContentPage
    {
        List<Person> _list = new List<Person>();
        List<Person> Persons { get; set; }
        public Schedule()
        {
            InitializeComponent();
            Persons = _list;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Persons = GetUsers();
            this.ListPersons.ItemsSource = Persons;
        }

        private List<Person> GetUsers()
        {
           var a = RestAPI.RestApi.GetUsers().Result;
           return a;
        }
    }
}