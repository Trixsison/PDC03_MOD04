using System;
using System.Collections.Generic;
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
        ObservableCollection<student> students = new ObservableCollection<student>();

        public ObservableCollection<student> student = new ObservableCollection<student>();

        public activity2()
        {
            InitializeComponent();
            studentView.ItemsSource = students;

            student.Add(new student { DisplayName = "Trixie May Sison", course = "BS in Information Technology" });
            students.Add(new student { DisplayName = "Christle Faith Orfinada", course = "BS in Multimedia Arts" });
            students.Add(new student { DisplayName = "Laika Anne Dizon", course = "Doctor of Medicine" });
            students.Add(new student { DisplayName = "Raymond Gomez", course = "BS in Information Technology" });
            students.Add(new student { DisplayName = "JT Pecson", course = "BS in Nursing" });
            students.Add(new student { DisplayName = "Mikaella Joy Sison", course = "BS in Biology" });
        }

    }
}