using System;
using System.Collections.Generic;

namespace FrontendCS
{
    public sealed class NullNode : INode
    {
        public static NullNode Default = new();
        public INode Parent { get => throw new NullReferenceException(); set => throw new NullReferenceException(); }
        public INode PreviousSibling { get => throw new NullReferenceException(); set => throw new NullReferenceException(); }
        public INode NextSibling { get => throw new NullReferenceException(); set => throw new NullReferenceException(); }
        public INode[] Children { get => throw new NullReferenceException(); set => throw new NullReferenceException(); }
        public string Text { get => throw new NullReferenceException(); set => throw new NullReferenceException(); }
        public string Tag { get => throw new NullReferenceException(); set => throw new NullReferenceException(); }
        public Dictionary<string, string> Attributes { get => throw new NullReferenceException(); set => throw new NullReferenceException(); }

        public override bool Equals(object? obj)
        {
            return obj != null && obj.GetType() == typeof(NullNode);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            throw new NullReferenceException();
        }
    }
}