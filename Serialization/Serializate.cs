
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml.Serialization;


namespace WindowsForms
{
    class Serializate
    {

        public static void Serializate_list(List<Circle> circles, string filename)
        {
            XmlSerializer serializater = new XmlSerializer(typeof(List<Circle>));
            Stream stream = new FileStream(filename, FileMode.Create);

            serializater.Serialize(stream, circles);
            stream.Close();

        }


        public static List<Circle> deserealizate(string filename)
        {
            List<Circle> deserialized = null;
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Circle>));
            using (FileStream serialStream = new FileStream(filename, FileMode.Open))
            {
                deserialized = (List<Circle>)xmlser.Deserialize(serialStream);
            }

            if (deserialized == null)
            {
                throw new ApplicationException(string.Format("Can`t deserialize file"));
            }

            return deserialized;

        }
    }
}
