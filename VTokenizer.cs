using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VividScript
{
    public class VTokenizer
    {
        public List<string> Ops = new List<string>();
        public List<string> Types = new List<string>();
        public List<string> Keys = new List<string>();
        public Dictionary<string, VToken> ConvTable = new Dictionary<string, VToken>();
        public void AddConv(string tok,VToken t)
        {
            ConvTable[tok] = t;
        }
        public VTokenizer()
        {
           
            Ops.Add("+");
            Ops.Add("-");
            Ops.Add("/");
            Ops.Add("*");
            Ops.Add("^");
            Ops.Add("mod");
            Ops.Add("==");
            AddConv("+", new VToken(TokenClass.Op, Token.Plus, "+"));
            AddConv("-", new VToken(TokenClass.Op, Token.Minus, "-"));
            AddConv("/", new VToken(TokenClass.Op, Token.Div, "/"));
            AddConv("*", new VToken(TokenClass.Op, Token.Div, "*"));
            AddConv("^", new VToken(TokenClass.Op, Token.Pow, "^"));
            AddConv("mod", new VToken(TokenClass.Op, Token.Pow, "mod"));
            AddConv("==", new VToken(TokenClass.Op, Token.Equal, "=="));

            Types.Add("byte");
            Types.Add("short");
            Types.Add("int");
            Types.Add("long");
            Types.Add("float");
            Types.Add("double");
            Types.Add("string");

            Keys.Add("if");
            Keys.Add("elseif");
            Keys.Add("end");
            Keys.Add("for");
            Keys.Add("next");
            Keys.Add("while");
            Keys.Add("module");
            Keys.Add("method");
            Keys.Add("function");


        }
    }
}
