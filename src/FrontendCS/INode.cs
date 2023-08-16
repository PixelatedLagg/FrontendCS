using System.Collections.Generic;

namespace FrontendCS
{
    public interface INode
    {
        INode Parent { get; set; }
        INode PreviousSibling { get; set; }
        INode NextSibling { get; set; }
        INode[] Children { get; set; }
        string Text { get; set; }
        string Tag { get; set; }
        Dictionary<string, string> Attributes { get; set; }
        bool Equals(object obj);
        string ToString();
    }
}