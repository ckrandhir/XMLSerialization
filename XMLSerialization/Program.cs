using System;
using System.IO;
using System.Collections;
using System.Xml.Serialization;
using XMLSerialization;
public class Test
{
    static void Main()
    {
        chandan c = new chandan();


        Deserialise();


        c.FirstName = "chandan";
        c.LastName = "Kumar";

        chandan.Details myDetails = new chandan.Details();
        myDetails.Y.Add("myData1");
        myDetails.Y.Add("myData2");

        c.MyDetails = myDetails;

        //XmlSerializer x = new XmlSerializer(typeof(DataCollections));  
        XmlSerializer x = new XmlSerializer(typeof(chandan));
         TextWriter txtWriter = new StreamWriter("outPut.xml");
        //x.Serialize(txtWriter, listInfo); 
        x.Serialize(txtWriter, c);





    }


    public static void Deserialise()

    {
        chandan c = new chandan();
        XmlSerializer serializer = new XmlSerializer(typeof(chandan));

        StreamReader reader = new StreamReader("outPut" + ".xml");

    //    TextReader reader = new StreamReader("outPut" + ".xml");
        c = (chandan)serializer.Deserialize(reader);
    }

}
