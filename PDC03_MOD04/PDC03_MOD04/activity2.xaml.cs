using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity2 : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees
        {
            get { return employees; }
        }

        public activity2()
        {

            InitializeComponent();
            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee { DisplayName = "Jen Nierva", Position = "President" });
            employees.Add(new Employee { DisplayName = "Mina Myoui", Position = "Vice President" });
            employees.Add(new Employee { DisplayName = "Chaewon Kim", Position = "Director" });
            employees.Add(new Employee { DisplayName = "Yunjin Huh", Position = "Supervisor" });
        }

        private void Add_item(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }
        }
        private void Edit_item(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }

        }
    }
}
