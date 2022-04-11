using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ControlGridView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Persona> personas = new ObservableCollection<Persona>();
        private PersonaDataObjects personaDao= new PersonaDataObjects();

        public MainWindow()
        {
            InitializeComponent();
            personas = new ObservableCollection<Persona>(personaDao.Listar());
            listViewAgenda.ItemsSource = personas;


        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string cadena;
            ComboBoxItem item = (ComboBoxItem)genero.SelectedItem;
            if (item.Content.ToString() == "varon")
                cadena = "imagenes/Hombrepng";
            else
                cadena = "imagenes/Mujer.png";
            personas.Add(new Persona { Nombre = nombre.Text, Email =email.Text, Genero = cadena });

        }
    }
}
