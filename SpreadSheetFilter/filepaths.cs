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
        public Boolean fileSuccess = false;
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
        public void testFile()
        {  
            try
            {
                string[] test = System.IO.File.ReadAllLines(this.sourcePath);
                fileSuccess = true;
            }
            catch (System.IO.IOException)
            {
                System.Windows.Forms.MessageBox.Show("File open in another program.  Please close file and try again");
            }//end catch opened file
            catch
            {
                System.Windows.Forms.MessageBox.Show("Unknown error reading file, please try again");
            }//end catchall
        }
    }
}
