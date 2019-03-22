using System.Collections.Generic;

namespace NameGeneratorProject
{
    public class NameGeneratorContainer
    {

        public NameGeneratorContainer()
        {

        }

        public List<BasePresetName> basePresetNameList;

        public string GetNameType(string typeOfName)
        {
            foreach (BasePresetName name in basePresetNameList)
            {
                if (name.NameType == typeOfName)
                    return name.NameType;
            }
            return "TYPE OF NAME NOT FOUND";
        }

        public void AddNameGenerator(string fileName, string nameType)
        {
            if (basePresetNameList == null)
                basePresetNameList = new List<BasePresetName>();

            basePresetNameList.Add(new BasePresetName(fileName)
                { NameType = nameType});
        }

        //returns the list of NameGenerators
        public List<BasePresetName> List => basePresetNameList;
    }
}