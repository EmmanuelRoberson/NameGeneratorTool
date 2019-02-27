using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using IntroToCSharp;

namespace NameGeneratorProject
{
    enum Nationalities
    {
        USA = 0,
        HIS = 1,
        JAP = 2,
        FRE = 3,
        RUS = 4,
        TBA = 5
    }

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
    }
}
