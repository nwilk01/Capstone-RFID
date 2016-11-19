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

        }

        private void button1_Click(object sender, EventArgs e)
        {//add
            
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        
    }
}
    

        

       

