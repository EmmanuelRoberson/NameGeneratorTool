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
        public AbstractNameBuilder nameGenerator;
        public NameGeneratorContainer nameGeneratorList;
        public List<HonorificList> honorificListContainer;

        public nameGeneratorForm()
        {
            InitializeComponent();
            nameGenerator = new AlternatingWholeNameBuilder();

            //ToDo:: namegeneratorcontainer to have a constructor for multiple instances
            //ToDo:: Done
            nameGeneratorList = new NameGeneratorContainer
            {
                basePresetNameList = new List<BasePresetName>
                {
                    new BasePresetName("AmericanFirstnames.csv"){NameType = "American"},
                    new BasePresetName("HispanicFirstnames.csv"){NameType = "Hispanic"},
                    new BasePresetName("JapaneseFIrstnames.csv"){NameType = "Japanese"},
                    new BasePresetName("FrenchFirstnames.csv"){NameType = "French"},
                    new BasePresetName("RussianFirstnames.csv"){NameType = "Russian"},
                }
            };

            honorificListContainer = new List<HonorificList>
            {
                new HonorificList("AmericanHonorifics.csv", "American"),
                new HonorificList("HispanicHonorifics.csv", "Hispanic"),
                new HonorificList("JapaneseHonorifics.csv", "Japanese"),
                new HonorificList("FrenchHonorifics.csv", "French"),
                new HonorificList("RussianHonorifics.csv", "Russian")
            };


            int i = 0;
            foreach (BasePresetName index in nameGeneratorList.List)
            {
                nationalitiesDropDox.Items.Add(nameGeneratorList.List[i].NameType);
                i++;
            }

            i = 0;
            foreach (HonorificList honorificType in honorificListContainer)
            {
                honorificComboBox.Items.Add(honorificListContainer[i].GetHonorificType);
                i++;
            }

            {
                nameLenghNumericUpDown.Hide();
                nameLengthLabel.Hide();
            }

            listOfGeneratedNamesRichTextBox.Multiline = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            genderComboBox.Items.Add("Male");
            genderComboBox.Items.Add("Female");
            genderComboBox.Items.Add("Random");
        }

        private void nationalitiesDropDox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)nationalitiesDropDox.SelectedItem == "Randomly Generated")
            {
                nameLenghNumericUpDown.Show();
                nameLengthLabel.Show();
            }
            else
            {
                nameLenghNumericUpDown.Hide();
                nameLengthLabel.Hide();
            }
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

        private void nameGeneratorTab_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void generateNameButton_Click(object sender, EventArgs e)
        {
            if (
                (string)nationalitiesDropDox.SelectedItem == "Japanese" && 
                (string)genderComboBox.SelectedItem != "Male" &&
                (string)genderComboBox.SelectedItem != "Female")
            {
                JapaneseNameBuilder japaneseNameBuilder = new JapaneseNameBuilder("JapaneseSyllables.csv");
                nameGenerated = japaneseNameBuilder.GenerateName;
            }
            else if ((string)nationalitiesDropDox.SelectedItem == "Randomly Generated")
            {
                nameGenerated = nameGenerator.GenerateWholeName((int)nameLenghNumericUpDown.Value);
            }
            else
            { 
                foreach (var generatorType in nameGeneratorList.List)
                {
                    if ((string)nationalitiesDropDox.SelectedItem == generatorType.NameType)
                    {
                        nameGenerated =
                            ((string)genderComboBox.SelectedItem == "Male")
                                ? generatorType.MaleName
                                : generatorType.FemaleName;
                    }
                }
            }

            AddHonorific(sender, e);
            namesGeneratedRichTextBox.Text = nameGenerated + '\n';
            allNamesGeneratedRichTextBox.Text += nameGenerated + '\n';
        }

        private void nameLenghNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (nameLenghNumericUpDown.Value < 0)
                nameLenghNumericUpDown.Value = 0;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToNamesGeneratedButton_Click(object sender, EventArgs e)
        {
            listOfGeneratedNamesRichTextBox.Text += nameGenerated + '\n';
        }

        private void listOfGeneratedNamesRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void generateNameListButton_Click(object sender, EventArgs e)
        {
            List<string> classConditionsMet = new List<string>();
            List<string> honorificConditionsMet = new List<string>();

            int totalNamesGenerated = (int)numberOfNamesGeneratedNumericUpDown.Value;

            foreach (Control option in nameClassCheckBoxList.Controls)
            {
                if (option is CheckBox)
                {
                    CheckBox chkBox = (CheckBox)option;
                    if (chkBox.Checked)
                    {
                        classConditionsMet.Add(chkBox.Text);
                    }
                }
            }
            foreach (Control option in honorificCheckBoxList.Controls)
            {
                if (option is CheckBox)
                {
                    CheckBox chkBox = (CheckBox)option;
                    if (chkBox.Checked)
                    {
                        honorificConditionsMet.Add(chkBox.Text);
                    }
                }
            }

            foreach (var classType in classConditionsMet)
            {
                foreach (var generatorType in nameGeneratorList.List)
                {
                    //todo: iterate and check to see if the conditions meet the generator type, and generate a name based on it
                    //if()
                    //nameGenerated =
                    //    ((string)genderComboBox.SelectedItem == "Male")
                    //        ? generatorType.MaleName
                    //        : generatorType.FemaleName;
                }
            }

        }

        private void nameLengthLabel_Click(object sender, EventArgs e)
        {
            //nameLengthLabel.
        }

        private void namesGeneratedGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
