using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Collager : Form
    {
        public Collager()
        {
            InitializeComponent();

        }
        int height;
        int width;
        int badgesPerColumn;

        private void button1_Click(object sender, EventArgs e)
        {
            //set the variables from the GUI at runtime
            //check if they error
            try
            {
                height = int.Parse(heightBox.Text);
                width = int.Parse(widthBox.Text);
                badgesPerColumn = int.Parse(badgesperColumn.Text);
            }
            catch { MessageBox.Show("One or more of your values are not integers"); return; }

            //File Picker Section
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //set parameters for the file dialog                
                openFileDialog.Filter = "Image Files|*.PNG;*.JPG;*.GIF;*.TIFF";
                openFileDialog.Title = "Select Pictures";
                openFileDialog.Multiselect = true;
                openFileDialog.RestoreDirectory = true;               

                //when files are selected run the following
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //set an increment
                    int i = 0;
                    //this will be for building columns
                    int currentWidth = 0;
                    //find number of files user wants to use
                    int filesSelected = openFileDialog.FileNames.Length;
                    //MessageBox.Show("Files Selected: " + filesSelected.ToString());

                    //check to see if the user selected less files than images per column so it doesn't create blank space
                    if (filesSelected < badgesPerColumn)
                    {
                        badgesPerColumn = filesSelected;
                    }
                    
                    //math for finding columns needed based upon allowed badges per column
                    int columnsNeeded = (int)Math.Ceiling((double)filesSelected / (double)badgesPerColumn);
                    //create an empty bitmap with the newly found values 
                    Bitmap result = new Bitmap(width * columnsNeeded, height * badgesPerColumn);
                    
                    //iterate through each file selected
                    foreach (string selectedItems in openFileDialog.FileNames)
                    {
                        //if the code has run through the number of badges per column, add the width to the current width so it moves over 1 
                        if (i == badgesPerColumn)
                        {
                            currentWidth = currentWidth + width;
                            i = 0;
                        }
                        //create graphics of the blank image
                        Graphics newImage = Graphics.FromImage(result);
                        
                        //create a bitmap from the currently selected file in iteration
                        Bitmap image = new Bitmap(selectedItems);
                        
                        //add the current bitmap in iteration to the previously blank image at the current coordinates 
                        //use the current iteration for height multiplier 
                        newImage.DrawImage(image, currentWidth, i * height, width, height);
                        
                        //check if the user wants this copied to their clipboard and do so 
                        if (copyToClipboard.Checked == true)
                        {
                            Clipboard.SetImage(result);
                        }

                        //iterate
                        i++;
                        
                    }

                    //SAVE SECTION

                    if (saveResult.Checked == true)
                    {
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                        saveFileDialog1.Filter = "Image Files|*.PNG;*.JPG;*.GIF;*.TIFF";
                        saveFileDialog1.RestoreDirectory = true;

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            if (saveFileDialog1.FileName != null)
                            {
                                // Code to write the stream goes here.
                                MessageBox.Show(saveFileDialog1.FileName);
                                result.Save(saveFileDialog1.FileName, ImageFormat.Png);

                            }
                        }
                    }
                    
                }
                

            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
