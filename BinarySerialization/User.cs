using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerialization
{
    [Serializable]
    public class User
    {
        public string Username;
        public string Name;
        public string Email;
        public string Phone;
        public string DateOfBirth;

        internal static User Deserialize(string fileName)
        {
            using (System.IO.FileStream stream = new System.IO.FileStream(fileName, System.IO.FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (User)formatter.Deserialize(stream);
            }
        }

        internal void SerializeBinary(string fileName)
        {

            using (System.IO.FileStream stream = new System.IO.FileStream(fileName, System.IO.FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
            }
        }
    }
}
