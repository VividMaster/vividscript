using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VividScript
{
    public enum TokenClass
    {
        Type,Value,Statement,Define,Op
    }
    public enum Token
    {
        If,Else,End,Module,Method,Func,Equal,Plus,Minus,Multi,Div,Comma,Peroid,Colon,SemiColon,StringMark,Int,Short,Byte,Long,Float,Double,String,
        Var,Transient,State,Auto,Link,Pow
    }
    public class VToken
    {
        public TokenClass Class;
        public Token Token;
        public string Text = "";
        public string String = "";
        public byte BVal;
        public short SVal;
        public int IVal;
        public long LVal;
        public float FVal;
        public double DVal;
        public VToken(TokenClass cls,Token tok,string txt)
        {
            Class = cls;
            Token = tok;
            Text = txt;
        }

    }
    public class VTokenStream
    {
        public List<VToken> Tokes = new List<VToken>();
        public int Pos = 0;
        public int Len = 0;
        public VToken Get()
        {
            return Tokes[Pos];
        }
        public VToken GetNext()
        {
            return Tokes[Pos++];
        }
        public VToken Find(Token t)
        {
            foreach(var ti in Tokes)
            {
                if (ti.Token == t) return ti;
            }
            return null;
        }
        public VToken FindPrev(Token t)
        {
            for(int ti=Pos;ti>=0;ti--)
            {
                if (Tokes[ti].Token == t) return Tokes[ti];
            }
            return null;
        }
        public VToken FindNext(Token t)
        {
            for(int ti = Pos; ti < Len; ti++)
            {
                if (Tokes[ti].Token == t) return Tokes[ti];
            }
            return null;
        }
    }
}
