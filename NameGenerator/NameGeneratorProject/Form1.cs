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

            //ToDo:: namegeneratorcontainer to have a constructor for multiple instances
            
            nameGeneratorList = new NameGeneratorContainer();
            nameGeneratorList.AddNameGenerator("AmericanFirstnames.csv", "American");
            nameGeneratorList.AddNameGenerator("HispanicFirstnames.csv", "Hispanic");
            nameGeneratorList.AddNameGenerator("JapaneseFirstnames.csv", "Japanese");
            nameGeneratorList.AddNameGenerator("FrenchFirstnames.csv", "French");
            nameGeneratorList.AddNameGenerator("RussianFirstnames.csv", "Russian");

            honorificListContainer = new List<HonorificList>
            {
                new HonorificList("AmericanHonorifics.csv", "American"),
                new HonorificList("HispanicHonorifics.csv", "Hispanic"),
                new HonorificList("JapaneseHonorifics.csv", "Japanese"),
                new HonorificList("FrenchHonorifics.csv", "French"),
                new HonorificList("RussianHonorifics.csv", "Russian")
            };


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

            exitButton.Show();
        }

        //Save Name
        private void button2_Click(object sender, EventArgs e)
        {
            
            XmlSerializer serializer = new XmlSerializer(typeof(string));

            var filepath = Path.Combine(Directory.GetCurrentDirectory(), "RandomlyGeneratedName.xml");

            TextWriter writer = new StreamWriter("RandomlyGeneratedName.xml");

            serializer.Serialize(writer, nameGenerated);

            writer.Close();

          //  Utilities.SaveXML("RandomlyGeneratedName.xml", nameGenerated);
            Utilities.SaveJson("RandomlyGeneratedName.xml", nameGenerated);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            genderComboBox.Items.Add("Male");
            genderComboBox.Items.Add("Female");
            genderComboBox.Items.Add("Random");
        }

        private void nationalitiesDropDox_SelectedIndexChanged(object sender, EventArgs e)
        {
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
 
        // used in order to drag the panel to drag the form
        private bool isDragging = false;
        private Point offset;
        private Point start_point = new Point(0, 0);
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;  // isDragging is your variable flag
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.start_point.X, p.Y - this.start_point.Y);
            }
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void nameGeneratorTab_DrawItem(object sender, DrawItemEventArgs e)
        {
            //for (int i = 0; i < nameGeneratorTab.TabCount; i++)
            //{
            //    e.Graphics.FillRectangle(new SolidBrush(Color.Salmon), e.Bounds);
            //}
        }

        private void generateNameButton_Click(object sender, EventArgs e)
        {
            if (
                (string)nationalitiesDropDox.SelectedItem == "Japanese" && 
                genderComboBox.SelectedText != "Male" &&
                genderComboBox.SelectedText != "Female")
            {
                JapaneseNameBuilder japaneseNameBuilder = new JapaneseNameBuilder("JapaneseSyllables.csv");
                nameGenerated = japaneseNameBuilder.GenerateName;
            }
            else if ((string)nationalitiesDropDox.SelectedItem == "Randomly Generated")
            {
                nameGenerated = RandomNameBuilder.GenerateName();
            }
            else
            { 
                foreach (var generatorType in nameGeneratorList.GeneratorList)
                {
                    if ((string)nationalitiesDropDox.SelectedItem == generatorType.GetNameType)
                    {
                        nameGenerated =
                            ((string)genderComboBox.SelectedItem == "Male")
                                ? generatorType.MaleName
                                : generatorType.FemaleName;
                    }
                }
            }

            AddHonorific(sender, e);
            nameGeneratedText.Text = nameGenerated;
        }
    }
}
