using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Helpers
{
    public static class FileHelper
    {
        public static bool CreateFile(string path, string text)
        {
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            
            using(StreamWriter Writer = new StreamWriter(stream))
            {
                try
                {
                    Writer.WriteLine(text);
                    return true;
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                return false;
            }
        }
    }
}
