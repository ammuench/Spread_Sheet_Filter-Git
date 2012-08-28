using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace SpreadSheetFilter
{
    public partial class filterMain : Form
    {
        public filterMain()
        {
            InitializeComponent();
        }
        
        filepaths paths = new filepaths();

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            paths.setSource(openFileDialog1.FileName);
            openText.Text = paths.getSource();
        }

        private void addTermButton_Click(object sender, EventArgs e)
        {
            string newTerm = newTermBox.Text;
            termBox.Items.Add(newTerm);
            termList.Items.Add(newTerm);
            newTermBox.Text = "";
        }

        private void removeTermButton_Click(object sender, EventArgs e)
        {
            termBox.Items.Remove(termList.SelectedItem);
            termList.Items.Remove(termList.SelectedItem);
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            paths.testFile();
            if (paths.fileSuccess == true)
            {
                
                string[] source = System.IO.File.ReadAllLines(paths.getSource());
                int termIndex = 0;
                foreach (var item in termList.Items)
                {
                    termIndex++;
                }//END FOREACH
                string[] filterTerms = new string[termIndex];
                termIndex = 0;
                foreach (var item in termList.Items)
                {
                    filterTerms[termIndex] = item.ToString();
                    termIndex++;
                }//END FOREACH
                int sIndex = 0;
                int regIndex = 0;

                //outputText.Text = "arrays made\n";
                
                //begin filtering CSV
                foreach (string s in source)
                {
                    regIndex = 0;
                    int regSuccess = 0;
                    regSuccess = 0;
                    foreach (string reg in filterTerms)
                    {
                        //outputText.Text = " regex process started\n";
                        Match regex = Regex.Match(source[sIndex], filterTerms[regIndex]);
                        regIndex++;
                        if (regex.Success)
                        {
                            regSuccess++;
                        }//regex success condition
                        else
                        {
                            regSuccess = -100;
                        }

                    }//end foreach
                    if (regSuccess > 0)
                    {
                        parseBox.Items.Add(source[sIndex]);
                    }
                    sIndex++;
                }//Foreach done
                //FOLLOWING CODE IS JUST TO TEST CREATION OF TERM ARRAY
                //COMMENT IN TO TEST
                //THESE COMMENTS ARE JUST SO FULL OF RAGE RIGHT NOW
                /*int i = 0;
                foreach (string s in filterTerms)//temporary just to show proper output
                {
                    outputText.AppendText(filterTerms[i] + "\n");
                    i++;
                }//end foreach*/

            }//endif

        }//end buttonclick
        private void outputText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            parseBox.Items.Clear();
        }

        private void removeRecord_Click(object sender, EventArgs e)
        {
            //parseBox.Items.Remove(
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
                        
            int parsedIndex = 0;
            foreach (var item in parseBox.Items)
            {
                parsedIndex++;
            }//END FOREACH
            string[] output = new string[parsedIndex];
            parsedIndex = 0;
            foreach (var item in parseBox.Items)
            {
                output[parsedIndex] = item.ToString();
                parsedIndex++;
            }//END FOREACH

            File.WriteAllLines(saveFileDialog1.FileName, output, Encoding.Default);
        }
    }
}
