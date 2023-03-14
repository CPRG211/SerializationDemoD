using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationDemoD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Writing (serializing)
            Student student1 = new Student("Joe Blow", 3.5, 21, "password");

            Student student2 = new Student("John Smith", 2.3, 77, "secret");

            Student student3 = new Student("Joe Schmoe", 4.0, 67, "abcd");

            /*FileStream fileStream = File.OpenWrite("students.bin");

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(fileStream, student1);
            formatter.Serialize(fileStream, student2);
            formatter.Serialize(fileStream, student3);

            fileStream.Close();*/

            // Reading (deserializing)
            FileStream fileStream = File.OpenRead("students.bin");

            BinaryFormatter formatter = new BinaryFormatter();

            //for (int i = 0; i < 4; i++)
            while (fileStream.Position < fileStream.Length)
            {
                object deserialized = formatter.Deserialize(fileStream);

                Student student = (Student)deserialized;

                Console.WriteLine("Deserialized student name: " + student.Name);
                Console.WriteLine("Deserialized student GPA: " + student.GPA);
            }
            
            /*deserialized = formatter.Deserialize(fileStream);

            student = (Student)deserialized;

            Console.WriteLine("Deserialized student name: " + student.Name);
            Console.WriteLine("Deserialized student GPA: " + student.GPA);*/

            fileStream.Close();
        }
    }
}