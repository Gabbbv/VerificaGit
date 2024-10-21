using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BibliotecaScolastica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
    // COMMENTO
        Biblioteca biblioteca = new Biblioteca();

        public MainWindow()
        {
            InitializeComponent();
            lbl_NomeBiblioteca.Text = biblioteca.NomeBiblioteca;
        }

        private void btn_Aggiungi_Click(object sender, RoutedEventArgs e)
        {
            libro = new Libro(txt_Autore.Text, txt_Titolo.Text, Convert.ToInt32(txt_Anno.Text), txt_Editore.Text, Convert.ToInt32(txt_Pagine.Text));
            biblioteca.AggiungiLibro(libro);
        }

        private void btn_Cerca_Click(object sender, RoutedEventArgs e)
        {
            string risultato = biblioteca.CercaTitolo(txt_CercaTitolo.Text);
            if (risultato != null)
            {
                txt_Risultato.Text = risultato;
            }
            else
            {
                txt_Risultato.Text = "Libro non trovato";
            }
        }
    }
}
