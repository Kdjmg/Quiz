using System;
using Microsoft.VisualBasic.FileIO;

public class Parse {
    public static void Parsetest() {
        using TextFieldParser textFieldParser = new(@"data/QuestionsExample.csv");
        textFieldParser.TextFieldType = FieldType.Delimited;
        textFieldParser.SetDelimiters(",");
        while (!textFieldParser.EndOfData)
        {
            string[] rows = textFieldParser.ReadFields();
            Console.WriteLine(rows);
        }
    }
  }
