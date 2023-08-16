using System.Collections.Generic;

namespace FrontendCS
{
    public static class ArrayExtensions
    {
        public static INode GetByTag(this INode[] nodes, string tag)
        {
            foreach (INode node in nodes)
            {
                if (node.Tag == tag)
                {
                    return node;
                }
            }
            return NullNode.Default;
        }

        public static INode[] GetManyByTag(this INode[] nodes, string tag)
        {
            List<INode> result = new();
            foreach (INode node in nodes)
            {
                if (node.Tag == tag)
                {
                    result.Add(node);
                }
            }
            return result.ToArray();
        }

        public static INode GetByAttribute(this INode[] nodes, string attribute, string value)
        {
            foreach (INode node in nodes)
            {
                if (node.Attributes.ContainsKey(attribute) && node.Attributes[attribute] == value)
                {
                    return node;
                }
            }
            return NullNode.Default;
        }

        public static INode[] GetManyByAttribute(this INode[] nodes, string attribute, string value)
        {
            List<INode> result = new();
            foreach (INode node in nodes)
            {
                if (node.Attributes.ContainsKey(attribute) && node.Attributes[attribute] == value)
                {
                    result.Add(node);
                }
            }
            return result.ToArray();
        }
    }
}