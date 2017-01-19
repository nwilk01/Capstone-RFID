using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using System.Windows.Media;
using System.Media;
using System.IO;
using Parallax28340;
using System.Xml;
using System.Windows.Threading;

namespace RFID_Reader
{
    public partial class Form1 : Form
    {
        Parallax28340Device RFID = new Parallax28340Device();
        public Form1()
        {
            InitializeComponent();
            



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //70005A4954
        }

        private void button1_Click(object sender, EventArgs e)
        {//add
            XmlDocument doc = new XmlDocument();
            doc.Load("Valid.xml");
            XmlNode rootNode = doc.SelectSingleNode("//Valid_List");
            doc.AppendChild(rootNode);
            XmlNode RFIDElement = doc.CreateElement("RFID_Tag");
            XmlAttribute ID = doc.CreateAttribute("ID");
            ID.Value = textBox1.Text;
            RFIDElement.Attributes.Append(ID);
            rootNode.AppendChild(RFIDElement);
            doc.Save("Valid.xml");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        
    }
}
    

        

       

