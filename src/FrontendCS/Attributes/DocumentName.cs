using System;

namespace FrontendCS
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DocumentName : Attribute
    {
        private string Name;

        public DocumentName(string name)
        {
            Name = name;
        }
    }
}