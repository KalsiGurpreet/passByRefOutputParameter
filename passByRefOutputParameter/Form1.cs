using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace passByRefOutputParameter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void GetFileName(out string selectedFile) // method with a "out" parameter variable.
                                                          // means you don't have to initialize a variable
                                                          // before passing it as a reference.
        {
            if (openFile.ShowDialog() == DialogResult.OK) // whether a user selected OK in dialog box.
            {
                selectedFile = openFile.FileName; // FileName object should be blank in order
                                                  // to store file name in it.
                                                  // it will then stored in selectedFile variable.
            }
            else
            {
                selectedFile = " ";
            }
        }
        private void GetCountries(string files)
        {
            try
            {
                string countryName;

                // StreamReader inputFile; 

                                        // StreamReader is a class and inputFile is a variable
                                        // that is declared as StreamReader class to reference a object.
                                        // It will reference a 
                                        // file object.

                StreamReader inputFile = new StreamReader(files);

                inputFile = System.IO.File.OpenText(files);

                countriesListBox.Items.Clear();

                while (!inputFile.EndOfStream) // task performed on inputFile variable.
                {
                    countryName = inputFile.ReadLine();
                    countriesListBox.Items.Add(countryName);
                }
                inputFile.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
              
        }
        private void countriesButton_Click(object sender, EventArgs e)
        {
            string fileName; // you do not have to initialize an argument 
                             // to be passed as reference using "output" parameter variable.

            GetFileName(out fileName); // file name selected is saved in string variable.
            GetCountries(fileName);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*  openFile.initialDirectory = "C:\Data";
 Verify the user have selected a Open button or Cancel button.
 if(openFileDialog.ShowDialog()== DialogResult.Cancel)
{
    MessageBox.Show("You clicked Cancel Button.");
}
 else
{
    MessageBox.Show("You have to open or close a file.");
} */
    }
}
