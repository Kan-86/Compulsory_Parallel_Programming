using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrimeGenerator
{
    partial class PrimeNumbersGenerator
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
            this.primeNumbersListBox = new System.Windows.Forms.ListBox();
            this.sequentialButton = new System.Windows.Forms.Button();
            this.parallelButton = new System.Windows.Forms.Button();
            this.startRangeLabel = new System.Windows.Forms.Label();
            this.endRangeLabel = new System.Windows.Forms.Label();
            this.timeUsedLabel = new System.Windows.Forms.Label();
            this.startRangeBox = new System.Windows.Forms.NumericUpDown();
            this.endRangeBox = new System.Windows.Forms.NumericUpDown();
            this.clearAllButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.startRangeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endRangeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // primeNumbersListBox
            // 
            this.primeNumbersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primeNumbersListBox.FormattingEnabled = true;
            this.primeNumbersListBox.ItemHeight = 20;
            this.primeNumbersListBox.Location = new System.Drawing.Point(71, 214);
            this.primeNumbersListBox.Margin = new System.Windows.Forms.Padding(4);
            this.primeNumbersListBox.Name = "primeNumbersListBox";
            this.primeNumbersListBox.Size = new System.Drawing.Size(931, 504);
            this.primeNumbersListBox.TabIndex = 0;
            // 
            // sequentialButton
            // 
            this.sequentialButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sequentialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sequentialButton.Location = new System.Drawing.Point(71, 114);
            this.sequentialButton.Margin = new System.Windows.Forms.Padding(4);
            this.sequentialButton.Name = "sequentialButton";
            this.sequentialButton.Size = new System.Drawing.Size(296, 57);
            this.sequentialButton.TabIndex = 3;
            this.sequentialButton.Text = "Start Sequential Prime Generator";
            this.sequentialButton.UseVisualStyleBackColor = true;
            this.sequentialButton.Click += new System.EventHandler(this.sequentialButton_Click);
            // 
            // parallelButton
            // 
            this.parallelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parallelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parallelButton.Location = new System.Drawing.Point(707, 114);
            this.parallelButton.Margin = new System.Windows.Forms.Padding(4);
            this.parallelButton.Name = "parallelButton";
            this.parallelButton.Size = new System.Drawing.Size(296, 57);
            this.parallelButton.TabIndex = 4;
            this.parallelButton.Text = "Start Parallelized Prime Generator";
            this.parallelButton.UseVisualStyleBackColor = true;
            this.parallelButton.Click += new System.EventHandler(this.parallelButton_Click);
            // 
            // startRangeLabel
            // 
            this.startRangeLabel.AutoSize = true;
            this.startRangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startRangeLabel.Location = new System.Drawing.Point(392, 17);
            this.startRangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startRangeLabel.Name = "startRangeLabel";
            this.startRangeLabel.Size = new System.Drawing.Size(93, 20);
            this.startRangeLabel.TabIndex = 10;
            this.startRangeLabel.Text = "Start range:";
            this.startRangeLabel.Click += new System.EventHandler(this.startRangeLabel_Click);
            // 
            // endRangeLabel
            // 
            this.endRangeLabel.AutoSize = true;
            this.endRangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endRangeLabel.Location = new System.Drawing.Point(543, 17);
            this.endRangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endRangeLabel.Name = "endRangeLabel";
            this.endRangeLabel.Size = new System.Drawing.Size(87, 20);
            this.endRangeLabel.TabIndex = 11;
            this.endRangeLabel.Text = "End range:";
            // 
            // timeUsedLabel
            // 
            this.timeUsedLabel.AutoSize = true;
            this.timeUsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeUsedLabel.Location = new System.Drawing.Point(480, 172);
            this.timeUsedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeUsedLabel.Name = "timeUsedLabel";
            this.timeUsedLabel.Size = new System.Drawing.Size(122, 26);
            this.timeUsedLabel.TabIndex = 12;
            this.timeUsedLabel.Text = "Time used";
            this.timeUsedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startRangeBox
            // 
            this.startRangeBox.Location = new System.Drawing.Point(311, 41);
            this.startRangeBox.Margin = new System.Windows.Forms.Padding(4);
            this.startRangeBox.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.startRangeBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startRangeBox.Name = "startRangeBox";
            this.startRangeBox.Size = new System.Drawing.Size(221, 22);
            this.startRangeBox.TabIndex = 1;
            this.startRangeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startRangeBox.ThousandsSeparator = true;
            this.startRangeBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startRangeBox.ValueChanged += new System.EventHandler(this.startRangeBox_ValueChanged);
            // 
            // endRangeBox
            // 
            this.endRangeBox.Location = new System.Drawing.Point(547, 41);
            this.endRangeBox.Margin = new System.Windows.Forms.Padding(4);
            this.endRangeBox.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.endRangeBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endRangeBox.Name = "endRangeBox";
            this.endRangeBox.Size = new System.Drawing.Size(227, 22);
            this.endRangeBox.TabIndex = 2;
            this.endRangeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endRangeBox.ThousandsSeparator = true;
            this.endRangeBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // clearAllButton
            // 
            this.clearAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearAllButton.Location = new System.Drawing.Point(472, 85);
            this.clearAllButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(140, 37);
            this.clearAllButton.TabIndex = 5;
            this.clearAllButton.Text = "Clear the generator";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // PrimeNumbersGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1067, 763);
            this.Controls.Add(this.endRangeBox);
            this.Controls.Add(this.startRangeBox);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.endRangeLabel);
            this.Controls.Add(this.startRangeLabel);
            this.Controls.Add(this.parallelButton);
            this.Controls.Add(this.sequentialButton);
            this.Controls.Add(this.primeNumbersListBox);
            this.Controls.Add(this.timeUsedLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrimeNumbersGenerator";
            this.Text = "Prime Numbers Generator  -  Team Ground Zero";
            ((System.ComponentModel.ISupportInitialize)(this.startRangeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endRangeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox primeNumbersListBox;
        private System.Windows.Forms.Button sequentialButton;
        private System.Windows.Forms.Button parallelButton;
        private System.Windows.Forms.Label startRangeLabel;
        private System.Windows.Forms.Label endRangeLabel;
        private System.Windows.Forms.Label timeUsedLabel;
        private System.Windows.Forms.NumericUpDown startRangeBox;
        private System.Windows.Forms.NumericUpDown endRangeBox;
        private System.Windows.Forms.Button clearAllButton;
    }
}

