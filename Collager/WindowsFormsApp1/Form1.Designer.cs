namespace WindowsFormsApp1
{
    partial class Collager
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
            this.runButton = new System.Windows.Forms.Button();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.badgesperColumn = new System.Windows.Forms.TextBox();
            this.copyToClipboard = new System.Windows.Forms.CheckBox();
            this.columnsLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.saveResult = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(235, 62);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(103, 31);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Select Images";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(157, 36);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(47, 20);
            this.widthBox.TabIndex = 1;
            this.widthBox.Text = "64";
            this.widthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.widthBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(157, 13);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(47, 20);
            this.heightBox.TabIndex = 2;
            this.heightBox.Text = "64";
            this.heightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // badgesperColumn
            // 
            this.badgesperColumn.Location = new System.Drawing.Point(39, 32);
            this.badgesperColumn.Name = "badgesperColumn";
            this.badgesperColumn.Size = new System.Drawing.Size(29, 20);
            this.badgesperColumn.TabIndex = 3;
            this.badgesperColumn.Text = "5";
            this.badgesperColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // copyToClipboard
            // 
            this.copyToClipboard.AutoSize = true;
            this.copyToClipboard.Location = new System.Drawing.Point(225, 15);
            this.copyToClipboard.Name = "copyToClipboard";
            this.copyToClipboard.Size = new System.Drawing.Size(113, 17);
            this.copyToClipboard.TabIndex = 4;
            this.copyToClipboard.Text = "Copy To Clipboard";
            this.copyToClipboard.UseVisualStyleBackColor = true;
            // 
            // columnsLabel
            // 
            this.columnsLabel.AutoSize = true;
            this.columnsLabel.Location = new System.Drawing.Point(9, 16);
            this.columnsLabel.Name = "columnsLabel";
            this.columnsLabel.Size = new System.Drawing.Size(101, 13);
            this.columnsLabel.TabIndex = 5;
            this.columnsLabel.Text = "Images Per Column ";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(116, 16);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(38, 13);
            this.heightLabel.TabIndex = 6;
            this.heightLabel.Text = "Height";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(116, 39);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(35, 13);
            this.widthLabel.TabIndex = 7;
            this.widthLabel.Text = "Width";
            // 
            // saveResult
            // 
            this.saveResult.AutoSize = true;
            this.saveResult.Checked = true;
            this.saveResult.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveResult.Location = new System.Drawing.Point(225, 39);
            this.saveResult.Name = "saveResult";
            this.saveResult.Size = new System.Drawing.Size(84, 17);
            this.saveResult.TabIndex = 8;
            this.saveResult.Text = "Save Result";
            this.saveResult.UseVisualStyleBackColor = true;
            // 
            // Collager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 105);
            this.Controls.Add(this.saveResult);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.columnsLabel);
            this.Controls.Add(this.copyToClipboard);
            this.Controls.Add(this.badgesperColumn);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.runButton);
            this.MaximumSize = new System.Drawing.Size(362, 144);
            this.MinimumSize = new System.Drawing.Size(362, 144);
            this.Name = "Collager";
            this.Text = "Collager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox badgesperColumn;
        private System.Windows.Forms.CheckBox copyToClipboard;
        private System.Windows.Forms.Label columnsLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.CheckBox saveResult;
    }
}

