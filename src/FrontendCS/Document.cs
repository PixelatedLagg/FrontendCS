using System.Collections.Generic;
using System.Text;

namespace FrontendCS
{
    public sealed class Document
    {
        public INode[] Nodes;
        public Dictionary<string, string> Attributes;

        public Document(INode[] nodes, Dictionary<string, string> attributes)
        {
            Nodes = nodes;
            Attributes = attributes;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != typeof(Document))
            {
                return false;
            }
            return Nodes == ((Document)obj).Nodes && Attributes == ((Document)obj).Attributes;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder("<!DOCTYPE html><html");
            foreach (KeyValuePair<string, string> attribute in Attributes)
            {
                builder.Append($" {attribute.Key}=\"{attribute.Value}\"");
            }
            builder.Append($">");
            foreach (INode node in Nodes)
            {
                builder.Append(node);
            }
            return builder.Append("</html>").ToString();
        }
    }
}