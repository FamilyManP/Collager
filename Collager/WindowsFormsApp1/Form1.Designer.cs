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
            this.wPaddingLabel = new System.Windows.Forms.Label();
            this.hPaddingLabel = new System.Windows.Forms.Label();
            this.heightPadding = new System.Windows.Forms.TextBox();
            this.widthPadding = new System.Windows.Forms.TextBox();
            this.verticalBox = new System.Windows.Forms.CheckBox();
            this.horizontalBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(329, 115);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(103, 31);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Select Images";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(261, 30);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(47, 20);
            this.widthBox.TabIndex = 1;
            this.widthBox.Text = "64";
            this.widthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.widthBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(261, 7);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(47, 20);
            this.heightBox.TabIndex = 2;
            this.heightBox.Text = "64";
            this.heightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // badgesperColumn
            // 
            this.badgesperColumn.Location = new System.Drawing.Point(89, 26);
            this.badgesperColumn.Name = "badgesperColumn";
            this.badgesperColumn.Size = new System.Drawing.Size(29, 20);
            this.badgesperColumn.TabIndex = 3;
            this.badgesperColumn.Text = "5";
            this.badgesperColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // copyToClipboard
            // 
            this.copyToClipboard.AutoSize = true;
            this.copyToClipboard.Location = new System.Drawing.Point(329, 9);
            this.copyToClipboard.Name = "copyToClipboard";
            this.copyToClipboard.Size = new System.Drawing.Size(113, 17);
            this.copyToClipboard.TabIndex = 4;
            this.copyToClipboard.Text = "Copy To Clipboard";
            this.copyToClipboard.UseVisualStyleBackColor = true;
            // 
            // columnsLabel
            // 
            this.columnsLabel.AutoSize = true;
            this.columnsLabel.Location = new System.Drawing.Point(12, 9);
            this.columnsLabel.Name = "columnsLabel";
            this.columnsLabel.Size = new System.Drawing.Size(182, 13);
            this.columnsLabel.TabIndex = 5;
            this.columnsLabel.Text = "Images Per Column (row if Horizontal)";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(220, 10);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(38, 13);
            this.heightLabel.TabIndex = 6;
            this.heightLabel.Text = "Height";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(220, 33);
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
            this.saveResult.Location = new System.Drawing.Point(329, 33);
            this.saveResult.Name = "saveResult";
            this.saveResult.Size = new System.Drawing.Size(84, 17);
            this.saveResult.TabIndex = 8;
            this.saveResult.Text = "Save Result";
            this.saveResult.UseVisualStyleBackColor = true;
            // 
            // wPaddingLabel
            // 
            this.wPaddingLabel.AutoSize = true;
            this.wPaddingLabel.Location = new System.Drawing.Point(171, 79);
            this.wPaddingLabel.Name = "wPaddingLabel";
            this.wPaddingLabel.Size = new System.Drawing.Size(84, 13);
            this.wPaddingLabel.TabIndex = 12;
            this.wPaddingLabel.Text = "Column Padding";
            // 
            // hPaddingLabel
            // 
            this.hPaddingLabel.AutoSize = true;
            this.hPaddingLabel.Location = new System.Drawing.Point(175, 56);
            this.hPaddingLabel.Name = "hPaddingLabel";
            this.hPaddingLabel.Size = new System.Drawing.Size(71, 13);
            this.hPaddingLabel.TabIndex = 11;
            this.hPaddingLabel.Text = "Row Padding";
            // 
            // heightPadding
            // 
            this.heightPadding.Location = new System.Drawing.Point(261, 53);
            this.heightPadding.Name = "heightPadding";
            this.heightPadding.Size = new System.Drawing.Size(47, 20);
            this.heightPadding.TabIndex = 10;
            this.heightPadding.Text = "0";
            this.heightPadding.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // widthPadding
            // 
            this.widthPadding.Location = new System.Drawing.Point(261, 76);
            this.widthPadding.Name = "widthPadding";
            this.widthPadding.Size = new System.Drawing.Size(47, 20);
            this.widthPadding.TabIndex = 9;
            this.widthPadding.Text = "0";
            this.widthPadding.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // verticalBox
            // 
            this.verticalBox.AutoSize = true;
            this.verticalBox.Checked = true;
            this.verticalBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.verticalBox.Location = new System.Drawing.Point(329, 55);
            this.verticalBox.Name = "verticalBox";
            this.verticalBox.Size = new System.Drawing.Size(61, 17);
            this.verticalBox.TabIndex = 13;
            this.verticalBox.Text = "Vertical";
            this.verticalBox.UseVisualStyleBackColor = true;
            this.verticalBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // horizontalBox
            // 
            this.horizontalBox.AutoSize = true;
            this.horizontalBox.Location = new System.Drawing.Point(329, 79);
            this.horizontalBox.Name = "horizontalBox";
            this.horizontalBox.Size = new System.Drawing.Size(73, 17);
            this.horizontalBox.TabIndex = 14;
            this.horizontalBox.Text = "Horizontal";
            this.horizontalBox.UseVisualStyleBackColor = true;
            this.horizontalBox.CheckedChanged += new System.EventHandler(this.horizontalBox_CheckedChanged);
            // 
            // Collager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 148);
            this.Controls.Add(this.horizontalBox);
            this.Controls.Add(this.verticalBox);
            this.Controls.Add(this.wPaddingLabel);
            this.Controls.Add(this.hPaddingLabel);
            this.Controls.Add(this.heightPadding);
            this.Controls.Add(this.widthPadding);
            this.Controls.Add(this.saveResult);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.columnsLabel);
            this.Controls.Add(this.copyToClipboard);
            this.Controls.Add(this.badgesperColumn);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.runButton);
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
        private System.Windows.Forms.Label wPaddingLabel;
        private System.Windows.Forms.Label hPaddingLabel;
        private System.Windows.Forms.TextBox heightPadding;
        private System.Windows.Forms.TextBox widthPadding;
        private System.Windows.Forms.CheckBox verticalBox;
        private System.Windows.Forms.CheckBox horizontalBox;
    }
}

