using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parallax28340;
using System.Windows;
using System.Xml;
using System.Windows.Threading;


namespace RFID_Reader
{
    delegate void UI_Interface();
    public partial class Form1 : Form
    {
        Parallax28340Device RFID = new Parallax28340Device();

        
        public Form1()
        {
            InitializeComponent();
            RFID.Init(DisplayRFID, DisplayStatus);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void DisplayRFID(string RFID)
        {
            Dispatcher.CurrentDispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal,
            (UI_Interface)delegate ()
            {
                /*if (TextBoxRFID.Text.Length > 0)
                {
                    TextBoxRFID.AppendText(Environment.NewLine);

                    TextBoxRFID.ScrollToEnd();


                }/*

                /* Comparing whether a valid RFID */


                String[] readerString = new String[8];
                XmlReader reader = XmlReader.Create("Valid.xml");
                while (reader.Read())
                {

                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (RFID == reader.GetAttribute("ID"))
                        {
                            textBox1.Text=RFID;
                            //PlaySound();
                        }



                    }
                }

                reader.Close();

            });
        }

        public void DisplayStatus(Boolean connected)
        {
            Dispatcher.CurrentDispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal,
            (UI_Interface)delegate ()
            {
                if (connected)
                {
                    textBox2.BackColor = Color.Green;
                    textBox2.Text = "Connected";
                }
                else
                {
                    textBox2.BackColor = Color.Red;
                    textBox2.Text = "Not Connected";
                }
            });
        }

        
    }
}
