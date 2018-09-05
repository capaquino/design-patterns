using System;
using System.IO;

// Stream is an abstract class, implemented by concrete streams
//     such as FileStream
// TextReader/TextWriter are abstract classes, implemented by helper classes
//     such as StreamReader/StreamWriter

namespace Playground
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string path = @"/Users/nad/Desktop/playground";
            string message = "Hello!!";

            // FileStream
            FileStreamWrite(path, message);
            Console.WriteLine(FileStreamRead(path));

            // StreamWriter/Reader
            StreamWriterWrite(path, message);
            Console.WriteLine(StreamReaderRead(path));
        }

        /* Directly using FileStream */

        public static void FileStreamWrite(string path, string message)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);

            if (fs.CanWrite)
            {
                byte[] writeBuffer = System.Text.Encoding.ASCII.GetBytes(message);
                fs.Write(writeBuffer, 0, writeBuffer.Length);
            }

            fs.Flush();
            fs.Close();
        }

        public static string FileStreamRead(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

            string textRead = String.Empty;
            if (fs.CanRead)
            {
                byte[] readBuffer = new byte[fs.Length]; // buffer is size of the file/stream
                int bytesRead = fs.Read(readBuffer, 0, readBuffer.Length); // read only as much as the buffer can take
                textRead = System.Text.Encoding.ASCII.GetString(readBuffer, 0, bytesRead); // Pretty sure we dont need bytesRead.
            }
            fs.Flush();
            fs.Close();
            return textRead;
        }

        /* StreamWriter/Reader */

        public static void StreamWriterWrite(string path, string message)
        {
            using (StreamWriter sw = new StreamWriter(path)) // default encoding is utf8
            {
                sw.Write(message);
            }
        }

        public static string StreamReaderRead(string path)
        {
            string textRead = String.Empty;
            using (StreamReader sr = new StreamReader(path))
            {
                textRead = sr.ReadToEnd();
            }
            return textRead;
        }
    }
}