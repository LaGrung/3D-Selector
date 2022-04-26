using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Media3D;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Win32;
using System.Xml;
using System.Text.RegularExpressions;
using static System.Windows.Interop.D3DImage;

namespace _3d_Selector
{

    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FileManager();


            //попытка найти элементы модели через поиск
            var myVar = (ModelVisual3D)this.FindName("Btn2");
            if (myVar != null) textBox_1.Text = "ffffff";
        }

        /// <summary>
        /// Display 3D Model
        /// </summary>
        /// <param name="model">Path to the Model file</param>
        /// <returns>3D Model Content</returns>


        List<Params> items;
        string fileName = "";
        string fileNameJSON = "";
        bool isFirst = false;
        string xmlcontents;



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FileManager();
            //XAML.Children.Clear();
        }

        private void FileManager()
        {

            //XAML model to program

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XAML files|*.xaml|All files|*.*";
            if (dialog.ShowDialog() == true)
            {
                fileName = dialog.FileName;

                if (!isFirst)
                {
                    isFirst = true;
                }
                else
                {
                    XAML.Children.Clear();
                }

                UIElement rootElement;
                FileStream s = new FileStream(fileName, FileMode.Open);
                rootElement = (UIElement)XamlReader.Load(s);
                s.Close();

                XmlDocument doc = new XmlDocument();
                doc.Load(fileName);
                xmlcontents = doc.InnerXml;
   
                Grid grid = (Grid)XamlReader.Load(new XmlTextReader(new StringReader(xmlcontents)));
                XAML.Children.Add(grid);

                textBox_1.Text = xmlcontents;


                string f1 = fileName.Remove(fileName.Length - 5);
                
                //XAML.Children.Add(rootElement);
               
                //JSON to program
                fileNameJSON = f1 + ".json";
                using (StreamReader r = new StreamReader(fileNameJSON))
                {
                    string json = r.ReadToEnd();
                    items = JsonConvert.DeserializeObject<List<Params>>(json);
                    //textBox_1.Text = items[0].systemName;
                    List<Params> tab = new List<Params>(5);

                    foreach (var item in items)
                    {
                        tab.Add(new Params(item.x, item.y, item.radius, item.systemName, item.customName, item.image));
                    }
                    Table.ItemsSource = tab;
                }
            }

 
        }
        // Clear the model
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            XAML.Children.Clear();
            Grid grid = (Grid)XamlReader.Load(new XmlTextReader(new StringReader(xmlcontents)));
            XAML.Children.Add(grid);

        }

        // Exit the program
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

            
        }

        private void ListJSON_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            //textBox_1.Text = ListJSON.SelectedItem.ToString();
        }

        

        private void Table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //int x = Table.SelectedIndex;
            //textBox_1.Text =items[x].systemName;
        }

        private void Table_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            XAML.Children.Clear();
            int x = Table.SelectedIndex;
            textBox_1.Text = items[x].systemName;

            
            

            string word = items[x].customName;
            string replaceTo = "red";


            var words = new Regex(word).Matches(xmlcontents).OfType<Match>().Select(match => match.Index).ToList();
            var result = xmlcontents.Substring(0, words[items[x].radius]) + replaceTo + xmlcontents.Substring(words[items[x].radius] + word.Length);
            
            
            Grid grid = (Grid)XamlReader.Load(new XmlTextReader(new StringReader(result)));
            XAML.Children.Add(grid);
            

        }

        private void MouseSelect() 
        {

            XAML.Children.Clear();
            string word = items[0].customName;
            string replaceTo = "red";

            
            var words = new Regex(word).Matches(xmlcontents).OfType<Match>().Select(match => match.Index).ToList();
            var result = xmlcontents.Substring(0, words[items[0].radius]) + replaceTo + xmlcontents.Substring(words[items[0].radius] + word.Length);


            Grid grid = (Grid)XamlReader.Load(new XmlTextReader(new StringReader(result)));
            XAML.Children.Add(grid);
        }
    }
}
