//Sabrina Turney
//C# 
//Chapter 7-6: Name Search
//Create an application that reads the contents of the two files into two separate arrays or Lists. 
//The user should be able to enter a boy’s name, a girl’s name, or both, and the application should display 
//messages indicating whether the names were among the most popular.

//Last edited: 09/22/19

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NameSearch
{
    public partial class NameSearch : Form
    {
        public NameSearch()
        {
            InitializeComponent();
        }

        //create a private class for the name files.
        //read the files' contents to know what "popular" names are.
        private void ReadNames(List<string> nameList)
        {
            try
            {
                //open the names files.
                StreamReader inputFile1 = File.OpenText("BoyNames.txt");
                StreamReader inputFile2 = File.OpenText("GirlNames.txt");

                //read the names
                while(!inputFile1.EndOfStream)
                {
                    nameList.Add(inputFile1.ReadLine());
                }

                while(!inputFile2.EndOfStream)
                {
                    nameList.Add(inputFile2.ReadLine());
                }

                //close files- Very important!
                inputFile1.Close();
                inputFile2.Close();

            }
            catch (Exception ex)
            {
                //This displays an error message if the files screw up:
                MessageBox.Show(ex.Message);
            }
        }

        //The DisplayNames method (like the DisplayScores Method)
        //displays the contents of the list parameter in the list box.
        private void DisplayNames(List<string> nameList)
        {
            foreach (string name in nameList)
            {
                nameListBox.Items.Add(name);
            }
        }

        //The PopularName method returns a yes or no if a name is popular.
        private string PopularName(List<string> nameList)
        {
            //if either name is found in the lists we have
            if (girlBox.ToString || boyBox.ToString == List<string> nameList)
            {
                //We tell our message box to display "Yes"
                yesOrNo.Text = "Yes! Good guess!";
            }
            //if neither name is found in our list
            if (girlBox.ToString && boyBox.ToString != List<string> nameList)
            {
                //we instruct our box to tell the user "No".
                yesOrNo.Text = "Sorry, no names found on our list!";
            }
            
        }

        private void NameButton_Click(object sender, EventArgs e)
        {
            string nameList;
            List<string> nameList = new List<string>();

            //Declare our variables, and then run through the lists and methods.
            ReadNames(nameList);
            //Reads the names on the lists.

            //Displays the names to the list box:
            DisplayNames(nameList);

            //Display if the users input matches that of the list names.
            PopularName(List<string> nameList);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Closes the program.
            this.Close();
        }
    }
}
