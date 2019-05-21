using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IMDCheck
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class FreqSet
        {
            public int freq1 { get; set; }
            public int freq2 { get; set; }
            public int lowerFreq { get; set; }
            public int upperFreq { get; set; }
        }

        List<int> checkedButtons = new List<int>();
        List<FreqSet> interferedFreq = new List<FreqSet>();

        private void ToggleButton_Clicked(object sender, RoutedEventArgs e)
        {
            ToggleButton button = sender as ToggleButton;
            BuildButtonList();
            CalcInterference();

            troubleFreqs.Text = "";

            foreach (FreqSet freqs in interferedFreq)
            {
                troubleFreqs.Text += freqs.freq1 + "\t";
                troubleFreqs.Text += freqs.freq2 + "\t";
                troubleFreqs.Text += freqs.lowerFreq + "\t";
                troubleFreqs.Text += freqs.upperFreq + System.Environment.NewLine;
            }
        }

        private void CalcInterference()
        {
            checkedButtons.Sort();
            interferedFreq.Clear();

            for (int freq = 0; freq < checkedButtons.Count(); freq++)
            {
                for (int subSearch = freq; subSearch < checkedButtons.Count() - 1; subSearch++)
                {
                    int freq1 = checkedButtons[subSearch];
                    int freq2 = checkedButtons[subSearch + 1];
                    int differFreq = freq2 - freq1;
                    int lowerFreq = freq1 - differFreq;
                    int upperFreq = freq2 + differFreq;
                    interferedFreq.Add(new FreqSet() { freq1 = freq1, freq2 = freq2, lowerFreq = lowerFreq, upperFreq = upperFreq });
                }
            }
        }
 
        private void BuildButtonList()
        {
            checkedButtons.Clear();

            if ((bool)f1Button.IsChecked) checkedButtons.Add(int.Parse(f1Button.Content.ToString()));
            if ((bool)f2Button.IsChecked) checkedButtons.Add(int.Parse(f2Button.Content.ToString()));
            if ((bool)f3Button.IsChecked) checkedButtons.Add(int.Parse(f3Button.Content.ToString()));
            if ((bool)f4Button.IsChecked) checkedButtons.Add(int.Parse(f4Button.Content.ToString()));
            if ((bool)f5Button.IsChecked) checkedButtons.Add(int.Parse(f5Button.Content.ToString()));
            if ((bool)f6Button.IsChecked) checkedButtons.Add(int.Parse(f6Button.Content.ToString()));
            if ((bool)f7Button.IsChecked) checkedButtons.Add(int.Parse(f7Button.Content.ToString()));
            if ((bool)f8Button.IsChecked) checkedButtons.Add(int.Parse(f8Button.Content.ToString()));

            if ((bool)b1Button.IsChecked) checkedButtons.Add(int.Parse(b1Button.Content.ToString()));
            if ((bool)b2Button.IsChecked) checkedButtons.Add(int.Parse(b2Button.Content.ToString()));
            if ((bool)b3Button.IsChecked) checkedButtons.Add(int.Parse(b3Button.Content.ToString()));
            if ((bool)b4Button.IsChecked) checkedButtons.Add(int.Parse(b4Button.Content.ToString()));
            if ((bool)b5Button.IsChecked) checkedButtons.Add(int.Parse(b5Button.Content.ToString()));
            if ((bool)b6Button.IsChecked) checkedButtons.Add(int.Parse(b6Button.Content.ToString()));
            if ((bool)b7Button.IsChecked) checkedButtons.Add(int.Parse(b7Button.Content.ToString()));
            if ((bool)b8Button.IsChecked) checkedButtons.Add(int.Parse(b8Button.Content.ToString()));

            if ((bool)a1Button.IsChecked) checkedButtons.Add(int.Parse(a1Button.Content.ToString()));
            if ((bool)a2Button.IsChecked) checkedButtons.Add(int.Parse(a2Button.Content.ToString()));
            if ((bool)a3Button.IsChecked) checkedButtons.Add(int.Parse(a3Button.Content.ToString()));
            if ((bool)a4Button.IsChecked) checkedButtons.Add(int.Parse(a4Button.Content.ToString()));
            if ((bool)a5Button.IsChecked) checkedButtons.Add(int.Parse(a5Button.Content.ToString()));
            if ((bool)a6Button.IsChecked) checkedButtons.Add(int.Parse(a6Button.Content.ToString()));
            if ((bool)a7Button.IsChecked) checkedButtons.Add(int.Parse(a7Button.Content.ToString()));
            if ((bool)a8Button.IsChecked) checkedButtons.Add(int.Parse(a8Button.Content.ToString()));

            if ((bool)e1Button.IsChecked) checkedButtons.Add(int.Parse(e1Button.Content.ToString()));
            if ((bool)e2Button.IsChecked) checkedButtons.Add(int.Parse(e2Button.Content.ToString()));
            if ((bool)e3Button.IsChecked) checkedButtons.Add(int.Parse(e3Button.Content.ToString()));
            if ((bool)e4Button.IsChecked) checkedButtons.Add(int.Parse(e4Button.Content.ToString()));
            if ((bool)e5Button.IsChecked) checkedButtons.Add(int.Parse(e5Button.Content.ToString()));
            if ((bool)e6Button.IsChecked) checkedButtons.Add(int.Parse(e6Button.Content.ToString()));
            if ((bool)e7Button.IsChecked) checkedButtons.Add(int.Parse(e7Button.Content.ToString()));
            if ((bool)e8Button.IsChecked) checkedButtons.Add(int.Parse(e8Button.Content.ToString()));

            if ((bool)r1Button.IsChecked) checkedButtons.Add(int.Parse(r1Button.Content.ToString()));
            if ((bool)r2Button.IsChecked) checkedButtons.Add(int.Parse(r2Button.Content.ToString()));
            if ((bool)r3Button.IsChecked) checkedButtons.Add(int.Parse(r3Button.Content.ToString()));
            if ((bool)r4Button.IsChecked) checkedButtons.Add(int.Parse(r4Button.Content.ToString()));
            if ((bool)r5Button.IsChecked) checkedButtons.Add(int.Parse(r5Button.Content.ToString()));
            if ((bool)r6Button.IsChecked) checkedButtons.Add(int.Parse(r6Button.Content.ToString()));
            if ((bool)r7Button.IsChecked) checkedButtons.Add(int.Parse(r7Button.Content.ToString()));
            if ((bool)r8Button.IsChecked) checkedButtons.Add(int.Parse(r8Button.Content.ToString()));
        }
    }
}
