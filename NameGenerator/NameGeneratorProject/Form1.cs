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
using NameGeneratorProject.CustomNameGeneratorClasses;
using NameGeneratorProject.Honorifics;

namespace NameGeneratorProject
{

    public partial class nameGeneratorForm : Form
    {
        public string nameGenerated;
        public RandomNameGenetator RandomNameBuilder;
        public NameGeneratorContainer nameGeneratorList;
        public List<HonorificList> honorificListContainer;

        public nameGeneratorForm()
        {
            InitializeComponent();
            RandomNameBuilder = new RandomNameGenetator
            {
                nameBuilder = new BaseNameBuilder(),
                prefixes = new PrependList(),
                suffixes = new AppendList()
            };

            nameGeneratorList = new NameGeneratorContainer();
            nameGeneratorList.AddNameGenerator("AmericanFirstnames.csv", "American");
            nameGeneratorList.AddNameGenerator("HispanicFirstnames.csv", "Hispanic");
            nameGeneratorList.AddNameGenerator("JapaneseFirstnames.csv", "Japanese");
            nameGeneratorList.AddNameGenerator("FrenchFirstnames.csv", "French");
            nameGeneratorList.AddNameGenerator("RussianFirstnames.csv", "Russian");

            honorificListContainer = new List<HonorificList>();
            honorificListContainer.Add(new HonorificList("AmericanHonorifics.csv","American"));
            honorificListContainer.Add(new HonorificList("HispanicHonorifics.csv","Hispanic"));
            honorificListContainer.Add(new HonorificList("JapaneseHonorifics.csv","Japanese"));
            honorificListContainer.Add(new HonorificList("FrenchHonorifics.csv","French"));
            honorificListContainer.Add(new HonorificList("RussianHonorifics.csv","Russian"));


            int i = 0;
            foreach (BasePresetName index in nameGeneratorList.GeneratorList)
            {
                nationalitiesDropDox.Items.Add(nameGeneratorList.GeneratorList[i].GetNameType);
                i++;
            }

            i = 0;
            foreach (HonorificList honorificType in honorificListContainer)
            {
                honorificComboBox.Items.Add(honorificListContainer[i].GetHonorificType);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            japaneseNameGeneratorButton.Visible = false;
        }

        //[No Name Generated]


        private void nationalitiesDropDox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!((string)nationalitiesDropDox.SelectedItem == "Randomly Generated"))
            {
                randomlyGeneratedNameButton.Hide();
                maleSymbolButton.Show();
                femaleSymbolButton.Show();
            }
            else
            {
                randomlyGeneratedNameButton.Show();
                maleSymbolButton.Hide();
                femaleSymbolButton.Hide();
            }

            if (!(nationalitiesDropDox.SelectedItem == "Japanese"))
            {
                this.Size = new Size(this.Size.Width, 150);
                japaneseNameGeneratorButton.Hide();
            }
            else
            {
                this.Size = new Size(this.Size.Width, 220);
                japaneseNameGeneratorButton.Show();
            }
        }

        private void maleSymbolButton_Click(object sender, EventArgs e)
        {
            if ((string) nationalitiesDropDox.SelectedItem == "Randomly Generated")
            {
                nameGenerated = RandomNameBuilder.GenerateName();
                nameGeneratedText.Text = nameGenerated;
            }

            foreach (BasePresetName nameGenerator in nameGeneratorList.GeneratorList)
            {
                if (nameGenerator.GetNameType == (string)nationalitiesDropDox.SelectedItem)
                {
                    nameGenerated = nameGenerator.MaleName;
                    AddHonorific(sender, e);
                    nameGeneratedText.Text = nameGenerated;
                }
            }
        }

        private void femaleSymbolButton_Click(object sender, EventArgs e)
        {
            foreach (BasePresetName nameGenerator in nameGeneratorList.GeneratorList)
            {
                if (nameGenerator.GetNameType == (string)nationalitiesDropDox.SelectedItem)
                {
                    nameGenerated = nameGenerator.FemaleName;
                    AddHonorific(sender, e);
                    nameGeneratedText.Text = nameGenerated;
                }
            }
        }

        private void japaneseNameGeneratorButton_Click(object sender, EventArgs e)
        {
            if (japaneseNameGeneratorButton.Visible)
            {
                foreach (BasePresetName nameGenerator in nameGeneratorList.GeneratorList)
                {
                    if (nameGenerator.GetNameType == "Japanese")
                    {
                        JapaneseNameBuilder japaneseNameBuilder = new JapaneseNameBuilder("JapaneseSyllables.csv");
                        nameGenerated = japaneseNameBuilder.GenerateName;
                        AddHonorific(sender, e);
                        nameGeneratedText.Text = nameGenerated;
                    }
                }
            }
        }


        private void randomlyGeneratedNameButton_Click(object sender, EventArgs e)
        {
            nameGenerated = RandomNameBuilder.GenerateName();
            AddHonorific(sender, e);
            nameGeneratedText.Text = nameGenerated;
        }

        private void nameGeneratedText_TextChanged(object sender, EventArgs e)
        {

        }

        Point lastPoint;
        private void nameGeneratorForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void nameGeneratorForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void honorificComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            availableHonorifics.Items.Clear();
            foreach (var honorificList in honorificListContainer)
            {
                if ((string)honorificComboBox.SelectedItem == honorificList.GetHonorificType)
                {
                    for (int i = 0; i < honorificList.GetHonorificList.Count; i++)
                    {
                        availableHonorifics.Items.Add(honorificList.GetHonorificList[i]);
                    }
                }
            }

            availableHonorifics.SelectedItem = availableHonorifics.Items[0];
        }

        private void AddHonorific(object sender, EventArgs e)
        {
            if ((string)honorificComboBox.SelectedItem == "Japanese")
            {
                nameGenerated += (string) availableHonorifics.SelectedItem;
            }
                else
            {
                nameGenerated = (string)availableHonorifics.SelectedItem + " " + nameGenerated;
            }
        }
    }
}
