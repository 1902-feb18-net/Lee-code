using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationAndAsync
{
    class Program
    {
        public static void Main(string[] args)
        {
            var persons = new List<Person>()
            {
                new Person
                {
                    Name = "Lunk",
                    Address = new Address
                    {
                        City = "Arlington",
                        State = "Tx",
                        Street = "Mitchell St."
                    },
                },
            };

            // to send this over a network or to a disk, it needs to be serialized.
            // this is to collect the data from across the different memory locations
            // into a well-defined text or binary format so that ideally it is reversible.

            string filename = @"C:\revature\person_data.xml";

            persons = DeserializeFromXMLFromFileAsync(filename).Result;

            SerializeAsXMLToFile(filename, persons);

            string filename2 = @"C:\revature\person_data.json";

            string newDate = JsonConvert.SerializeObject(filename2);
            File.WriteAllTextAsync(filename2, newDate).Wait();


            //persons = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllTextAsync(filename2).Result);
            Console.WriteLine(persons);
        }

        public static void SerializeAsXMLToFile(string filename, List<Person> persons)
        {
            var serializer = new XmlSerializer(typeof(List<Person>));

            FileStream filestream = null;
            try
            {
                filestream = new FileStream(filename, FileMode.Create);
                serializer.Serialize(filestream, persons);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"error in writing to file {ex.Message}");
                throw;
            }
            finally
            {
                filestream?.Dispose();
            }

            
        }

        private static async Task<List<Person>> DeserializeFromXMLFromFileAsync(string filename)
        {
            var DeSerializer = new XmlSerializer(typeof(List<Person>));

            using (var memoryStream = new MemoryStream())
            {
                using (var fileStream = new FileStream(filename, FileMode.Open))
                {
                    await fileStream.CopyToAsync(memoryStream);
                }
                memoryStream.Position = 0;

                return (List<Person>)DeSerializer.Deserialize(memoryStream);
            }
        }
    }
}
