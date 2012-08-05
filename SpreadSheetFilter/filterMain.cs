using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            try
            {
                string[] source = System.IO.File.ReadAllLines(paths.getSource());
            }
            catch (System.IO.IOException)
            {
                System.Windows.Forms.MessageBox.Show("File open in another program.  Please close file and try again");
            }//end catch opened file
            catch
            {
                System.Windows.Forms.MessageBox.Show("Unknown error reading file, please try again");
            }//end catchall
            
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
    }
}
