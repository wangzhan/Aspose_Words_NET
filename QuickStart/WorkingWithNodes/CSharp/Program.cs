//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Words. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System;
using System.IO;

using Aspose.Words;

namespace WorkingWithNodes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a new document.
            Document doc = new Document();

            // Creates and adds a paragraph node to the document.
            Paragraph para = new Paragraph(doc);

            // Typed access to the last section of the document.
            Section section = doc.LastSection;
            section.Body.AppendChild(para);

            // Next print the node type of one of the nodes in the document.
            NodeType nodeType = doc.FirstSection.Body.NodeType;

            Console.WriteLine("NodeType: " + Node.NodeTypeToString(nodeType));
        }
    }
}