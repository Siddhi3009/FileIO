using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace FileIODemo
{
    class SerializationDeserialization
    {
        public string path = @"C:\Users\Administrator\Desktop\BridgeLabz Practice\33. File IO Operation\FileIO\FileIODemo\binarySerialize.txt";

        public string Name { get; private set; }
        public string Description { get; private set; }

        public void BinarySerialization()
        {
            Demo demo = new Demo();
            FileStream fileStream = new FileStream(path, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, demo);
            Console.ReadKey();
        }
        public void BinaryDeserialization()
        {
            FileStream fileStream = new FileStream(path, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Demo deserializedObject = (Demo)binaryFormatter.Deserialize(fileStream);
            Console.WriteLine($"Application Id:  {deserializedObject.ApplicationId}");
            Console.WriteLine($"Application Name:  {deserializedObject.ApplicationName}");
            Console.ReadKey();
        }
        public void JsonSerialization()
        {
            BlogSites blogSites = new BlogSites()
            {
                Name = "Sam",
                Description = "Welcome Json"
            };
            string jsonData = JsonConvert.SerializeObject(blogSites);
            Console.WriteLine(jsonData);
        }
        public void JsonDeSerialization()
        {
            string jSonData = @"{
                'Name' : 'Sam',
                'Description': 'Welcome Json'
                }";
            BlogSites blogSites = JsonConvert.DeserializeObject<BlogSites>(jSonData);
            Console.WriteLine(blogSites.Name);
            Console.WriteLine(blogSites.Description);
        }
        public void XMLSerialize()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(OrderForm));
            FileStream fileStream = new FileStream(@"C:\Users\Administrator\Desktop\BridgeLabz Practice\33. File IO Operation\FileIO\FileIODemo\xmlSerialize.txt", FileMode.Create);
            OrderForm orderForm = new OrderForm();
            DateTime dateTime = new DateTime(2020, 10, 25);
            orderForm.OrderDate = dateTime;
            xmlSerializer.Serialize(fileStream, orderForm);
        }
        public void XmlDeSerialization()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(OrderForm));
            FileStream fileStream = new FileStream(@"C:\Users\Administrator\Desktop\BridgeLabz Practice\33. File IO Operation\FileIO\FileIODemo\xmlSerialize.txt", FileMode.Open);
            OrderForm orderForm = (OrderForm)xmlSerializer.Deserialize(fileStream);
            Console.WriteLine(orderForm.OrderDate);
        }

    }
    [Serializable]
    public class Demo
    {
        public string ApplicationName { get; set; } = "Binary Serialize";
        public int ApplicationId { get; set; } = 1001;
    }
    [DataContract]
    public class BlogSites
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
    public class OrderForm
    {
        public DateTime OrderDate;
    }
}
