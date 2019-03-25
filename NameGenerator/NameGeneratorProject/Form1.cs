using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using IntroToCSharp;

namespace NameGeneratorProject
{
    public partial class nameGeneratorForm : Form
    {

        public RandomNameGenetator RandomNameBuilder;
        public string nameGenerated;

        public nameGeneratorForm()
        {
            InitializeComponent();
            RandomNameBuilder = new RandomNameGenetator
            {
                nameBuilder = new BaseNameBuilder(),
                prefixes = new PrefixList(),
                suffixes = new SuffixList()
            };
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

        //GENERATE NAME
        private void button1_Click(object sender, EventArgs e)
        {
            nameGenerated = RandomNameBuilder.GenerateName();
            nameGeneratedButton.Text = nameGenerated;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //[No Name Generated]
        private void nameGeneratedButton_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(string));

            var filepath = Path.Combine(Directory.GetCurrentDirectory(), nameGenerated + ".xml");

            TextWriter writer = new StreamWriter(nameGenerated + ".xml");

            serializer.Serialize(writer, nameGenerated);
            writer.Close();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Directory.GetCurrentDirectory();
            ofd.ShowDialog();

            XmlSerializer serializer = new XmlSerializer(typeof(string));
            XmlReader reader = new XmlTextReader(ofd.FileName);
            nameGenerated = (string) serializer.Deserialize(reader);
            reader.Close();
            nameGeneratedButton.Text = nameGenerated;
        }
    }
}
