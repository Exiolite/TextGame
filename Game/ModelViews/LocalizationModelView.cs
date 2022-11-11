using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;

namespace ModelViews
{
    public sealed class LocalizationModelView
    {
        public Dictionary<string, string> Localization { get; }


        public LocalizationModelView()
        {
            Localization = new Dictionary<string, string>();

            InitializeLocalizationDictionary();
        }


        public void DisplayMessage(string messageName)
        {
            if (Localization.TryGetValue(messageName, out string value))
                Console.WriteLine(value);
        }


        private void InitializeLocalizationDictionary()
        {
            XmlDocument xmlDocument = new XmlDocument();

            string path = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                "Localizations",
                "Localization.xml"
            );

            xmlDocument.LoadXml(
                File.ReadAllText(
                    path
                )
            );

            foreach (XmlNode node in xmlDocument.ChildNodes)
            {
                if (node.Name == "localizationDictionary")
                    foreach (XmlNode textNode in node.ChildNodes)
                    {
                        string key = textNode.Attributes["key"].Value;
                        string value = textNode.Attributes["value"].Value;

                        if (!Localization.ContainsKey(key))
                            Localization.Add(key, value);
                    }
            }
        }
    }
}
