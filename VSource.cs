using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace VividScript
{
    public class VSource
    {
        public string Path = "";
        public VTokenStream Tokens = null;
        public VSource(string path)
        {
            Path = path;
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            TextReader r = new StreamReader(fs);
            VTokenizer toker = new VTokenizer();
            Tokens = new VTokenStream();
            while (true)
            {
                Console.WriteLine("Pos:" + fs.Position + " Len:" + fs.Length);
                if (fs.Position >= fs.Length) break;
                string cl = r.ReadToEnd();
                Console.WriteLine("CL:" + cl);
                if(cl==null || cl==string.Empty || cl==" ")
                {
                    continue;
                }
                var ts = toker.ParseString(cl);
                Console.WriteLine("Parsed line. " + ts.Len + " tokens.");
                foreach(var t in ts.Tokes)
                {
                    Tokens.Add(t);
                }

            }
            fs.Close();
            Console.WriteLine("Parsed Source:" + Tokens.Len + " tokens.");
        }
    }
}
