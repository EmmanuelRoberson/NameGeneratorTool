﻿using System;
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

namespace NameGeneratorProject
{

    public partial class nameGeneratorForm : Form
    {
        public string nameGenerated;
        public RandomNameGenetator RandomNameBuilder;
        public NameGeneratorContainer nameGeneratorList;

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
            nameGeneratorList.AddNameGenerator("AmericanFirstnames.csv", "American");

            int i = 0;
            foreach (BasePresetName index in nameGeneratorList.GeneratorList)
            {
                nationalitiesDropDox.Items.Add(nameGeneratorList.GeneratorList[i].GetNameType);
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
                nameGeneratedButton.Text = nameGenerated;
            }

            foreach (BasePresetName nameGenerator in nameGeneratorList.GeneratorList)
            {
                if (nameGenerator.GetNameType == (string)nationalitiesDropDox.SelectedItem)
                {
                    nameGenerated = nameGenerator.MaleName;
                    nameGeneratedButton.Text = nameGenerated;
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
                    nameGeneratedButton.Text = nameGenerated;
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
                        nameGeneratedButton.Text = nameGenerated;
                    }
                }
            }
        }

        private void honorificTypeDropdownBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //honorificTypeDropdownBox.Items;
        }

        private void randomlyGeneratedNameButton_Click(object sender, EventArgs e)
        {
            nameGenerated = RandomNameBuilder.GenerateName();
            nameGeneratedButton.Text = nameGenerated;
        }
    }
}
