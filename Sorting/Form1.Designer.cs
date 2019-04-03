namespace Sorting
{
    partial class Form1
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
            this.SelectionListBox = new System.Windows.Forms.ListBox();
            this.QuickButton = new System.Windows.Forms.Button();
            this.QuickListBox = new System.Windows.Forms.ListBox();
            this.UnsortedLabel = new System.Windows.Forms.Label();
            this.SortingHeadingLabel = new System.Windows.Forms.Label();
            this.SelectionWatchLabel = new System.Windows.Forms.Label();
            this.QuickWatchLabel = new System.Windows.Forms.Label();
            this.ArraySizeTextBox = new System.Windows.Forms.TextBox();
            this.InsLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.SelectionButton = new System.Windows.Forms.Button();
            this.ResetLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectionListBox
            // 
            this.SelectionListBox.FormattingEnabled = true;
            this.SelectionListBox.Location = new System.Drawing.Point(32, 182);
            this.SelectionListBox.Name = "SelectionListBox";
            this.SelectionListBox.Size = new System.Drawing.Size(156, 147);
            this.SelectionListBox.TabIndex = 1;
            // 
            // QuickButton
            // 
            this.QuickButton.Location = new System.Drawing.Point(298, 127);
            this.QuickButton.Name = "QuickButton";
            this.QuickButton.Size = new System.Drawing.Size(75, 41);
            this.QuickButton.TabIndex = 2;
            this.QuickButton.Text = "QuickSort";
            this.QuickButton.UseVisualStyleBackColor = true;
            this.QuickButton.Click += new System.EventHandler(this.QuickButton_Click);
            // 
            // QuickListBox
            // 
            this.QuickListBox.FormattingEnabled = true;
            this.QuickListBox.Location = new System.Drawing.Point(257, 182);
            this.QuickListBox.Name = "QuickListBox";
            this.QuickListBox.Size = new System.Drawing.Size(156, 147);
            this.QuickListBox.TabIndex = 4;
            // 
            // UnsortedLabel
            // 
            this.UnsortedLabel.AutoSize = true;
            this.UnsortedLabel.Location = new System.Drawing.Point(52, 171);
            this.UnsortedLabel.Name = "UnsortedLabel";
            this.UnsortedLabel.Size = new System.Drawing.Size(0, 13);
            this.UnsortedLabel.TabIndex = 5;
            // 
            // SortingHeadingLabel
            // 
            this.SortingHeadingLabel.AutoSize = true;
            this.SortingHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortingHeadingLabel.Location = new System.Drawing.Point(179, 15);
            this.SortingHeadingLabel.Name = "SortingHeadingLabel";
            this.SortingHeadingLabel.Size = new System.Drawing.Size(87, 25);
            this.SortingHeadingLabel.TabIndex = 6;
            this.SortingHeadingLabel.Text = "Sorting";
            // 
            // SelectionWatchLabel
            // 
            this.SelectionWatchLabel.AutoSize = true;
            this.SelectionWatchLabel.Location = new System.Drawing.Point(95, 336);
            this.SelectionWatchLabel.Name = "SelectionWatchLabel";
            this.SelectionWatchLabel.Size = new System.Drawing.Size(30, 13);
            this.SelectionWatchLabel.TabIndex = 7;
            this.SelectionWatchLabel.Text = "Time";
            // 
            // QuickWatchLabel
            // 
            this.QuickWatchLabel.AutoSize = true;
            this.QuickWatchLabel.Location = new System.Drawing.Point(320, 336);
            this.QuickWatchLabel.Name = "QuickWatchLabel";
            this.QuickWatchLabel.Size = new System.Drawing.Size(30, 13);
            this.QuickWatchLabel.TabIndex = 8;
            this.QuickWatchLabel.Text = "Time";
            // 
            // ArraySizeTextBox
            // 
            this.ArraySizeTextBox.Location = new System.Drawing.Point(175, 85);
            this.ArraySizeTextBox.Name = "ArraySizeTextBox";
            this.ArraySizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ArraySizeTextBox.TabIndex = 9;
            this.ArraySizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ArraySizeTextBox.TextChanged += new System.EventHandler(this.ArraySizeTextBox_TextChanged);
            // 
            // InsLabel
            // 
            this.InsLabel.AutoSize = true;
            this.InsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsLabel.Location = new System.Drawing.Point(123, 53);
            this.InsLabel.Name = "InsLabel";
            this.InsLabel.Size = new System.Drawing.Size(220, 16);
            this.InsLabel.TabIndex = 10;
            this.InsLabel.Text = "Enter an integer greater than 0:";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(64, 370);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(339, 13);
            this.notesLabel.TabIndex = 11;
            this.notesLabel.Text = "Arrays with more than 20,000 indexes will not be shown in the listboxes";
            // 
            // SelectionButton
            // 
            this.SelectionButton.Location = new System.Drawing.Point(73, 127);
            this.SelectionButton.Name = "SelectionButton";
            this.SelectionButton.Size = new System.Drawing.Size(75, 41);
            this.SelectionButton.TabIndex = 12;
            this.SelectionButton.Text = "Selection Sort";
            this.SelectionButton.UseVisualStyleBackColor = true;
            this.SelectionButton.Click += new System.EventHandler(this.SelectionButton_Click);
            // 
            // ResetLabel
            // 
            this.ResetLabel.AutoSize = true;
            this.ResetLabel.Location = new System.Drawing.Point(95, 391);
            this.ResetLabel.Name = "ResetLabel";
            this.ResetLabel.Size = new System.Drawing.Size(259, 13);
            this.ResetLabel.TabIndex = 13;
            this.ResetLabel.Text = "Entering a new value for the array will reset all objects";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 433);
            this.Controls.Add(this.ResetLabel);
            this.Controls.Add(this.SelectionButton);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.InsLabel);
            this.Controls.Add(this.ArraySizeTextBox);
            this.Controls.Add(this.QuickWatchLabel);
            this.Controls.Add(this.SelectionWatchLabel);
            this.Controls.Add(this.SortingHeadingLabel);
            this.Controls.Add(this.UnsortedLabel);
            this.Controls.Add(this.QuickListBox);
            this.Controls.Add(this.QuickButton);
            this.Controls.Add(this.SelectionListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox SelectionListBox;
        private System.Windows.Forms.Button QuickButton;
        private System.Windows.Forms.ListBox QuickListBox;
        private System.Windows.Forms.Label UnsortedLabel;
        private System.Windows.Forms.Label SortingHeadingLabel;
        private System.Windows.Forms.Label SelectionWatchLabel;
        private System.Windows.Forms.Label QuickWatchLabel;
        private System.Windows.Forms.TextBox ArraySizeTextBox;
        private System.Windows.Forms.Label InsLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Button SelectionButton;
        private System.Windows.Forms.Label ResetLabel;
    }
}

