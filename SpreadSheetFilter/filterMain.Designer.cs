namespace SpreadSheetFilter
{
    partial class filterMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.termBox = new System.Windows.Forms.ListBox();
            this.openText = new System.Windows.Forms.TextBox();
            this.newTermBox = new System.Windows.Forms.TextBox();
            this.termList = new System.Windows.Forms.ComboBox();
            this.outputText = new System.Windows.Forms.TextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.addTermButton = new System.Windows.Forms.Button();
            this.removeTermButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // termBox
            // 
            this.termBox.FormattingEnabled = true;
            this.termBox.Location = new System.Drawing.Point(342, 12);
            this.termBox.Name = "termBox";
            this.termBox.Size = new System.Drawing.Size(120, 108);
            this.termBox.TabIndex = 0;
            // 
            // openText
            // 
            this.openText.Location = new System.Drawing.Point(12, 12);
            this.openText.Name = "openText";
            this.openText.Size = new System.Drawing.Size(231, 20);
            this.openText.TabIndex = 1;
            // 
            // newTermBox
            // 
            this.newTermBox.Location = new System.Drawing.Point(12, 38);
            this.newTermBox.Name = "newTermBox";
            this.newTermBox.Size = new System.Drawing.Size(231, 20);
            this.newTermBox.TabIndex = 2;
            // 
            // termList
            // 
            this.termList.FormattingEnabled = true;
            this.termList.Location = new System.Drawing.Point(12, 64);
            this.termList.Name = "termList";
            this.termList.Size = new System.Drawing.Size(231, 21);
            this.termList.TabIndex = 3;
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(12, 130);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputText.Size = new System.Drawing.Size(450, 153);
            this.outputText.TabIndex = 4;
            this.outputText.WordWrap = false;
            this.outputText.TextChanged += new System.EventHandler(this.outputText_TextChanged);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(249, 12);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(87, 20);
            this.openFileButton.TabIndex = 5;
            this.openFileButton.Text = "Load File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addTermButton
            // 
            this.addTermButton.Location = new System.Drawing.Point(249, 38);
            this.addTermButton.Name = "addTermButton";
            this.addTermButton.Size = new System.Drawing.Size(87, 20);
            this.addTermButton.TabIndex = 6;
            this.addTermButton.Text = "Add Term";
            this.addTermButton.UseVisualStyleBackColor = true;
            this.addTermButton.Click += new System.EventHandler(this.addTermButton_Click);
            // 
            // removeTermButton
            // 
            this.removeTermButton.Location = new System.Drawing.Point(249, 65);
            this.removeTermButton.Name = "removeTermButton";
            this.removeTermButton.Size = new System.Drawing.Size(87, 20);
            this.removeTermButton.TabIndex = 7;
            this.removeTermButton.Text = "Remove Term";
            this.removeTermButton.UseVisualStyleBackColor = true;
            this.removeTermButton.Click += new System.EventHandler(this.removeTermButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(104, 95);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(186, 20);
            this.filterButton.TabIndex = 8;
            this.filterButton.Text = "Begin Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "CSV (Comma Separated Values)|.*csv|Text Files|.*txt";
            // 
            // filterMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 291);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.removeTermButton);
            this.Controls.Add(this.addTermButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.termList);
            this.Controls.Add(this.newTermBox);
            this.Controls.Add(this.openText);
            this.Controls.Add(this.termBox);
            this.Name = "filterMain";
            this.Text = "Spreadsheet Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox termBox;
        private System.Windows.Forms.TextBox openText;
        private System.Windows.Forms.TextBox newTermBox;
        private System.Windows.Forms.ComboBox termList;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button addTermButton;
        private System.Windows.Forms.Button removeTermButton;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

