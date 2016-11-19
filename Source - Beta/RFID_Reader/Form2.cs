using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace RFID_Reader
{
    public partial class Form2 : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Form2()
        {
            InitializeComponent();
            
            
            XmlReader reader = XmlReader.Create("Valid.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load("Valid.xml");
            XmlNodeList IDnodes = doc.SelectNodes("//Valid_List/RFID_Tag");
            foreach(XmlNode IDnode in IDnodes)
            {
                comboBox1.Items.Add(IDnode.Attributes["ID"].Value);
            }

           

            
                reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Valid.xml");
            XmlNodeList IDnodes = doc.SelectNodes("//Valid_List/RFID_Tag");
            foreach(XmlNode IDnode in IDnodes)
            {
                if (comboBox1.SelectedItem.ToString()==IDnode.Attributes["ID"].Value)
                {
                    XmlNode delete = IDnode.ParentNode;
                    delete.RemoveChild(IDnode);
                    doc.Save("Valid.xml");
                }
            }
        }
    }
}
