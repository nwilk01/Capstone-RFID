using System;
using System.Windows;
using System.Windows.Media;
using System.Media;
using System.IO;
using Parallax28340;
using System.Xml;
using System.Text;

namespace RFID_Reader
{
    delegate void UI_Interface();
    

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        Parallax28340Device RFID = new Parallax28340Device();
        Form1 add = new Form1();
        

        SoundPlayer Mplayer         = new SoundPlayer();
        FileStream wavFile          = null;

        public MainWindow()
        {
           InitializeComponent();

            RFID.Init(DisplayRFID, DisplayStatus);

            try
            {
                wavFile = new FileStream("./Sounds/Beep.wav",
                                      FileMode.Open,
                                      FileAccess.Read);

            }
            catch (Exception e)
            {
                DisplayErrorMsg(e.Message);
                wavFile = null;
            }
        }


        public void DisplayErrorMsg(string ErrorMsg)
        {
            Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal,
            (UI_Interface)delegate()
            {
                TextBoxRFID.AppendText(ErrorMsg);
            });
        }

        public void DisplayRFID(string RFID)
        {
            Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal,
            (UI_Interface)delegate ()
            {
                if (TextBoxRFID.Text.Length > 0)
                {
                    TextBoxRFID.AppendText(Environment.NewLine);

                    TextBoxRFID.ScrollToEnd();


                }

                
                if (add.Visible) 
                {
                    add.textBox1.Text = RFID;
                }
                else {
                    /* Comparing whether a valid RFID */
                    XmlReader reader = XmlReader.Create("Valid.xml");
                    while (reader.Read())
                    {

                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            if (RFID == reader.GetAttribute("ID"))
                            {
                                TextBoxRFID.AppendText(RFID);
                                PlaySound();
                            }
                        }
                    }
                    reader.Close();
                }
            });
        }

        public void DisplayStatus(Boolean connected)
        {
            Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal,
            (UI_Interface)delegate()
            {
                if (connected)
                {
                    textBoxStatus.Background = Brushes.Green;
                    textBoxStatus.Text = "Connected";
                }
                else
                {
                    textBoxStatus.Background = Brushes.Red;
                    textBoxStatus.Text = "Not Connected";
                }
            });
        }


        public void PlaySound()
        {
            if (Properties.Settings.Default.BeepEnabled)
            {
                if (wavFile != null)
                {
                    Mplayer.Stream = wavFile;
                    Mplayer.Play();
                }
            }
        }

        private void ExitClicked(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MainWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            RFID.End();
        }

        private void ClearButtonPressed(object sender, RoutedEventArgs e)
        {
            TextBoxRFID.Clear();

        }

        private void checkBoxBeepEnabled_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Delete_Tag(object sender, RoutedEventArgs e)
        {
            Form2 delete = new Form2();
            delete.Show();
        }
        private void Add_Tag(object sender, RoutedEventArgs e)
        {
            add.Show();
        }

    }
        
    
}


