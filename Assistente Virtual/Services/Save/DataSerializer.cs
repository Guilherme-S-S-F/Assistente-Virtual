using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assis_Serializer
{
    class DataSerializer
    {
        //Saves a data in a file
        public void BinarySerialize(object data, string filePath)
        {
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            
            fileStream = File.Create(filePath);
            bf.Serialize(fileStream, data);
            fileStream.Close();
        }

        public object BinaryDeserialize(string filePath)
        {
            object obj = null;

            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();

            if (File.Exists(filePath))
            {
                fileStream = File.OpenRead(filePath);
                obj = bf.Deserialize(fileStream);
                fileStream.Close();
            }

            return obj;
        }
    }
}
