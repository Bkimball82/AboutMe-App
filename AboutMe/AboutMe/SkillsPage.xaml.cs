using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AboutMe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SkillsPage : ContentPage
    {
        public ObservableCollection<String> Skills { get; set; }
        public SkillsPage()
        {
            InitializeComponent();

            this.Skills = new ObservableCollection<string>();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            this.Skills.Add(newSkillEntry.Text);

            skillsList.ItemsSource = this.Skills;

            newSkillEntry.Text = "";
        }
    }
}