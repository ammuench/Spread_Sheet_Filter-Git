using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpreadSheetFilter
{
    public class filepaths
    {
        string sourcePath;
        string outputPath = "output.csv";
        public void setSource(string FilePathIn)
        { // 
            this.sourcePath = FilePathIn;
        }
        public string getSource()
        { //
            return this.sourcePath;
        }
        public void setOutput(string FilePathOut)
        { //
            this.outputPath = FilePathOut;
        }
        public string getOutput()
        {
            return this.outputPath;
        }
    }
}
