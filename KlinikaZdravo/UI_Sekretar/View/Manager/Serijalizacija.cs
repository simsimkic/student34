using Aplikacija.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija
{
    class Serijalizacija
    {
        Stream stream = null;
        BinaryFormatter bformatter = null;
        String txtFileName = "";
        public Serijalizacija(String filename)
        {
            txtFileName = filename;
            stream = File.Open(txtFileName, FileMode.Create);
            bformatter = new BinaryFormatter();
        }
        public void SerializeObject(Object objectToSerialize)
        {
            bformatter.Serialize(stream, objectToSerialize);
        }
        public  void DesiriazibleObject()
        {
            Object objectToDeseriazible = null;
            stream = File.Open(txtFileName, FileMode.Open);
            try
            {
                while (stream.CanSeek)
                {
                    objectToDeseriazible = (Object)bformatter.Deserialize(stream);
                    if (objectToDeseriazible is ZaposleniRepository ){
                        ZaposleniRepository r= (ZaposleniRepository)objectToDeseriazible;
                    }
                }
            }
            catch(SerializationException e)
            {
                
            }
          
        }
        public void closeStream()
        {
            stream.Close();
        }

    }
}
