using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            outputText.Text = "";
            outputText.Text = "Starting New Filter\n";
            try
            {
                string[] test = System.IO.File.ReadAllLines(paths.getSource());
                outputText.AppendText("File Load Successful");
            }
            catch (System.IO.IOException)
            {
                System.Windows.Forms.MessageBox.Show("File open in another program.  Please close file and try again");
                outputText.AppendText("File Load Error: File open in other program\n");
            }//end catch opened file
            catch
            {
                System.Windows.Forms.MessageBox.Show("Unknown error reading file, please try again");
                outputText.AppendText("File Load Error: Unknown Error");
            }//end catchall
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
            
            outputText.Text = "";
            foreach (string s in source)
            {
                regIndex = 0;
                int regSuccess = 0;
                foreach (string reg in filterTerms)
                {
                    outputText.Text = " regex process started";
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
                    outputText.AppendText(source[sIndex] + "\n");
                }
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
        }

        private void outputText_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
