using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using IntroToCSharp;

namespace NameGeneratorProject
{
    public partial class Form1 : Form
    {
        public RandomNameGenetator fullNameBuilder;
        public string nameGenerated;

        public Form1()
        {
            InitializeComponent();
            fullNameBuilder = new RandomNameGenetator();
            fullNameBuilder.nameBuilder = new BaseNameBuilder();
            fullNameBuilder.prefixes = new PrefixList();
            fullNameBuilder.suffixes = new SuffixList();
        }

        //Save Name
        private void button2_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(string));

            var filepath = Path.Combine(Directory.GetCurrentDirectory(), "RandomlyGeneratedName.xml");

            TextWriter writer = new StreamWriter("RandomlyGeneratedName.xml");

            serializer.Serialize(writer, nameGenerated);

            writer.Close();

        }

        //Generate Name
        private void button1_Click(object sender, EventArgs e)
        {
            nameGenerated = fullNameBuilder.GenerateName();
            nameGeneratedButton.Text = nameGenerated;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Name Generated
        private void nameGeneratedButton_Click(object sender, EventArgs e)
        {
            nameGenerated = fullNameBuilder.GenerateName();
            nameGeneratedButton.Text = nameGenerated;
        }
    }
}
