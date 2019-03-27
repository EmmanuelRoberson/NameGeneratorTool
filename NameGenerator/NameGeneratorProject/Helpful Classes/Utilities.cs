using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.VisualBasic.FileIO;
using NameGeneratorProject.Helpful_Classes;

namespace NameGeneratorProject
{
    public static class Utilities
    {
        public static void SaveXML(string filename, string saveobject)
        {
            //filename = "RandomlyGeneratedName.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(string));

            var filepath = Path.Combine(Directory.GetCurrentDirectory(), filename);

            TextWriter writer = new StreamWriter(filename);

            serializer.Serialize(writer, saveobject);

            writer.Close();
        }

        public static void SaveJson(object saveobject, string folders)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Directory.GetCurrentDirectory() + folders;
            sfd.ShowDialog();

            File.WriteAllText(sfd.FileName + ".json", Newtonsoft.Json.JsonConvert.SerializeObject(saveobject));
        }

        public static NameListContainer LoadJson(params string[] folders)
        {
            OpenFileDialog ofd = new OpenFileDialog {InitialDirectory = Directory.GetCurrentDirectory() + folders};
            ofd.ShowDialog();
            var data = System.IO.File.ReadAllText(ofd.FileName);
            var loadedFile = Newtonsoft.Json.JsonConvert.DeserializeObject<NameListContainer>(data);

            return loadedFile;
        }

        public static void ReadCSV(string filename, params List<string>[] containers)
        {
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), filename);
            TextFieldParser cvsParser = new TextFieldParser(filepath);

            cvsParser.SetDelimiters(",");

            while (!cvsParser.EndOfData)
            {
                // reads the line, assigns the fields, then moves it to the next line
                string[] lineFields = cvsParser.ReadFields();

                for (int i = 0; i < lineFields.Length; i++)
                {
                    containers[i].Add(lineFields[i]);
                }
            }
        }
    }
}