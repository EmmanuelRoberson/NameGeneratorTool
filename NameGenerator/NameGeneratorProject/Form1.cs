using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using IntroToCSharp;
using NameGeneratorProject.NationalNameClasses;

namespace NameGeneratorProject
{

    public partial class nameGeneratorForm : Form
    {

        public RandomNameGenetator RandomNameBuilder;
        public string nameGenerated;
        public List<BasePresetName> NameNationalities = new List<BasePresetName>();

        public nameGeneratorForm()
        {
            InitializeComponent();
            RandomNameBuilder = new RandomNameGenetator
            {
                nameBuilder = new BaseNameBuilder(),
                prefixes = new PrependList(),
                suffixes = new AppendList()
            };

            NameNationalities.Add(new AmericanNameBuilder("AmericanFirstnames.csv"){NameType = "American"});
            NameNationalities.Add(new AmericanNameBuilder("HispanicFirstnames.csv"){NameType = "Hispanic"});
            NameNationalities.Add(new AmericanNameBuilder("JapaneseFirstnames.csv"){NameType = "Japanese" });
            NameNationalities.Add(new AmericanNameBuilder("FrenchFirstnames.csv"){NameType = "French"});
            NameNationalities.Add(new RussianNameBuilder("RussianFirstnames.csv"){NameType = "Russian"});

            int i = 0;
            foreach (BasePresetName index in NameNationalities)
            {
                nationalitiesDropDox.Items.Add(NameNationalities[i].NameType);
                i++;
            }
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
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            japaneseNameGeneratorButton.Visible = false;
        }

        //[No Name Generated]
        private void nameGeneratedButton_Click(object sender, EventArgs e)
        {

        }

        private void nationalitiesDropDox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!(nationalitiesDropDox.SelectedItem == "Japanese"))
            {
                this.Size = new Size(this.Size.Width, 150);
                japaneseNameGeneratorButton.Visible = false;
            }
            else
            {
                this.Size = new Size(this.Size.Width, 220);
                japaneseNameGeneratorButton.Visible = true;
            }
        }

        private void maleSymbolButton_Click(object sender, EventArgs e)
        {

            switch (nationalitiesDropDox.SelectedItem)
            {
                case "American":
                    nameGenerated = NameNationalities[(int)Nationalities.USA].MaleName;
                    nameGeneratedButton.Text = nameGenerated;
                    break;
                case "Hispanic":
                    nameGenerated = NameNationalities[(int)Nationalities.HIS].MaleName;
                    nameGeneratedButton.Text = nameGenerated;
                    break;
                case "Japanese":
                    nameGenerated = NameNationalities[(int)Nationalities.JAP].MaleName;
                    nameGeneratedButton.Text = nameGenerated;
                    break;
                case "French":
                    nameGenerated = NameNationalities[(int)Nationalities.FRE].MaleName;
                    nameGeneratedButton.Text = nameGenerated;
                    break;
                case "Russian":
                    nameGenerated = NameNationalities[(int)Nationalities.RUS].MaleName;
                    nameGeneratedButton.Text = nameGenerated;
                    break;
                case "Randomly Generated":
                    nameGenerated = RandomNameBuilder.GenerateName();
                    nameGeneratedButton.Text = nameGenerated;
                    break;
            }
        }

        private void femaleSymbolButton_Click(object sender, EventArgs e)
        {
            switch (nationalitiesDropDox.SelectedItem)
            {
                case "American":
                    nameGenerated = NameNationalities[(int)Nationalities.USA].FemaleName;
                    nameGeneratedButton.Text = nameGenerated;
                    break;
                case "Hispanic":
                    nameGenerated = NameNationalities[(int)Nationalities.HIS].FemaleName;
                    nameGeneratedButton.Text = nameGenerated;
                    break;
                case "Japanese":
                    nameGenerated = NameNationalities[(int)Nationalities.JAP].FemaleName;
                    nameGeneratedButton.Text = nameGenerated;
                    break;
                case "French":
                    nameGenerated = NameNationalities[(int)Nationalities.FRE].FemaleName;
                    nameGeneratedButton.Text = nameGenerated;
                    break;
                case "Russian":
                    nameGenerated = NameNationalities[(int)Nationalities.RUS].FemaleName;
                    nameGeneratedButton.Text = nameGenerated;
                    break;
                case "Randomly Generated":
                    nameGenerated = RandomNameBuilder.GenerateName();
                    nameGeneratedButton.Text = nameGenerated;
                    break;
            }
        }

        private void japaneseNameGeneratorButton_Click(object sender, EventArgs e)
        {
            if (japaneseNameGeneratorButton.Visible)
            {
                var newJapProp = NameNationalities[(int)Nationalities.JAP].GetType();

                object obj = Activator.CreateInstance(newJapProp, "JapaneseFirstnames.csv");
                newJapProp.InvokeMember("SetSyllables", BindingFlags.InvokeMethod, null, obj, new object[] { "JapaneseSyllables.csv" });
                nameGenerated = (string)newJapProp.InvokeMember("GenerateName", BindingFlags.GetProperty, null, obj, new object[0]);
                nameGeneratedButton.Text = nameGenerated;
            }

        }

        private void honorificTypeDropdownBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //honorificTypeDropdownBox.Items;
        }
    }
}
