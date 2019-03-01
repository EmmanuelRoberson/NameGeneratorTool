using System.Collections.Generic;

namespace NameGeneratorProject
{
    public class NameGeneratorContainer
    {
        private List<BasePresetName> nameGeneratorList;

        public string GetNameType(string typeOfName)
        {
            foreach (BasePresetName name in nameGeneratorList)
            {
                if (name.GetNameType == typeOfName)
                    return name.GetNameType;
            }
            return "TYPE OF NAME NOT FOUND";
        }

        public void AddNameGenerator(string fileName, string nameType)
        {
            if (nameGeneratorList == null)
                nameGeneratorList = new List<BasePresetName>();

            nameGeneratorList.Add(new BasePresetName(fileName)
                { GetNameType = nameType});
        }

        //returns the list of NameGenerators
        public List<BasePresetName> GeneratorList => nameGeneratorList;
    }
}