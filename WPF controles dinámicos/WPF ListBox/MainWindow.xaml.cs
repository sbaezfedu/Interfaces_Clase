using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Lista desde el código C# que se añade manualmente a la propiedad ItemsSource de un ListBox
            List<TodoItem> items = new List<TodoItem>();
            items.Add(new TodoItem() { Title = "WPF", Completion = 45 });
            items.Add(new TodoItem() { Title = "C#", Completion = 80 });
            items.Add(new TodoItem() { Title = "Java", Completion = 0 });
            this.lbTodoList.ItemsSource = items;
        }
    }

    public class TodoItem
    {
        public string Title { get; set; }
        public int Completion { get; set; }

        // Sobrescribimos el método ToString
        public override string ToString()
        {
            return this.Title + "-" + this.Completion;
        }
    }
}
