﻿using System.IO;
using System.Xml.Linq;
using UrlRewrite.Interfaces;
using UrlRewrite.Interfaces.Operations;

namespace UrlRewrite.Operations
{
    public class LowerCaseOperation: ILowerCaseOperation
    {
        public ILowerCaseOperation Initialize()
        {
            return this;
        }

        public string Execute(string value)
        {
            return ReferenceEquals(value, null) ? string.Empty : value.ToLower();
        }

        public string ToString(IRequestInfo requestInfo)
        {
            return "ToLower()";
        }

        public override string ToString()
        {
            return "ToLower()";
        }

        public void Describe(TextWriter writer, string indent, string indentText)
        {
            writer.Write(indent);
            writer.WriteLine("convert to lower case");
        }
    }
}
