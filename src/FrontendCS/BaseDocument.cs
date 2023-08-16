using System;
using System.Collections.Generic;

namespace FrontendCS
{
    public class BaseDocument
    {
        public Document Document;
        public Action? OnLoad;

        public BaseDocument()
        {
            Document = new(Array.Empty<INode>(), new Dictionary<string, string>());
            //set document with parsed html document
        }
    }
}