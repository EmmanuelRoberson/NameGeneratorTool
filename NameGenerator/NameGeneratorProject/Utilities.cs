using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

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

        public static void SaveJson(string filename, string saveobject)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Directory.GetCurrentDirectory();
            sfd.ShowDialog();

            File.WriteAllText(sfd.FileName, Newtonsoft.Json.JsonConvert.SerializeObject(saveobject));
        }
    }
}