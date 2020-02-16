using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitiesVer2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // this method splits the selected item into two parts 
        private void CitiesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CitiesListBox.SelectedIndex == -1)
                return;

            String display = CitiesListBox.SelectedItem.ToString();

            if(display != "")
            {
                String[] split = display.Split('|');
                EditCityTxtBox.Text = split[0];
                EditPopTxtBox.Text = split[1];
            }
        } // end SelectedIndexChanged
        //*****************************************************************************************


        // this method adds a city to the list
        private void AddButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
           
            String name = EditCityTxtBox.Text;  //*************almost
            if ( name.Equals("") || (name.Any(c=>char.IsNumber(c)))  )
            {
                MessageBox.Show("You must enter a name in the city box");
            }
            else
            {
                String pop = EditPopTxtBox.Text;
                if (pop.Equals("") || (pop.Any(c => char.IsLetter(c))))
                {
                    MessageBox.Show("You must enter a number in the population box");
                }
                else
                {
                    String display = String.Format("{0} | {1}", name, pop);

                    Boolean found = false;
                    foreach (String item in CitiesListBox.Items)   //use foreach loop to make sure reading in each line seems name is now part of a string
                    {
                        if (item.Contains(name))
                        {
                            ErrorLabel.Text = "That city is already in the list!";
                            found = true;
                        }
                    }

                    if (!found)
                    {
                        CitiesListBox.Items.Add(display);
                        ErrorLabel.Text = "City added!";
                    }
                }
            }
            
        } // end AddButton_Click

        // this method deletes the city from the list
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(CitiesListBox.SelectedIndex != -1)
            {
                CitiesListBox.Items.RemoveAt(CitiesListBox.SelectedIndex);
            }
        } // end DeleteButton_Click


        // this method allows a city to be edited
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (CitiesListBox.SelectedIndex == -1)
                return;

            // gather new city name and population from txt boxes, format as one string
            String name = EditCityTxtBox.Text;
            if (name.Equals("") || (name.Any(c => char.IsNumber(c))))
            {
                MessageBox.Show("You must enter a name in the city box");
            }
            else
            {
                String pop = (EditPopTxtBox.Text);
                int verPop;    //for parse validation
                //if the box is empty or if it can not be parsed into an int
                if (pop.Equals("") || (!int.TryParse(EditPopTxtBox.Text, out verPop)))//Any(c => char.IsLetter(c))))
                {
                    MessageBox.Show("You must enter a number in the population box");
                }
                else
                {
                    String display = String.Format("{0} | {1}", name, pop);

                    // remove the selcted city/pop
                    CitiesListBox.Items.RemoveAt(CitiesListBox.SelectedIndex);
                    // add the new name and pop
                    CitiesListBox.Items.Add(display);
                }
            }
        } // end EditButton_Click


        // this method allows a city to be inserted
        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (CitiesListBox.SelectedIndex == -1)
                return;

            // gather new city name and population from txt boxes, format as one string
            String name = InsertCityTxtBox.Text;
            if (name.Equals("") || (name.Any(c => char.IsNumber(c))))
            {
                MessageBox.Show("You must enter a name in the city box");
            }
            else
            {
                String pop = InsertPopTxtBox.Text;
                if (pop.Equals("") || (pop.Any(c => char.IsLetter(c))))
                {
                    MessageBox.Show("You must enter a number in the population box");
                }
                else
                {


                    String display = String.Format("{0} | {1}", name, pop);

                    //inserts the new city one line below selected city
                    CitiesListBox.Items.Insert(CitiesListBox.SelectedIndex + 1, display);
                }
            }
        } // end InsertButton_Click




        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (CitiesListBox.SelectedIndex == -1)
                return;
            if (SearchListBox.SelectedIndex == -1)
                return;

            String name = EditCityTxtBox.Text;
            CitiesListBox.Items.Add(name);
           // String pop =  EditPopTxtBox.Text;

           // String display = String.Format("{0} | {1}", name, pop);

            //foreach(string city in CitiesListBox.Items)
            //{
            //    String lbString = CitiesListBox.Items.ToString();
            //    if (lbString.Equals(name))
            //    {
            //        SearchListBox.Items.Add(name);
            //    }
            //    else
                
                   
                
           // }

        }

        // start the form out with a clear main panel and two pre-loaded cities in the list
        private void MainForm_Load(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            CitiesListBox.Items.Add("Grand Rapids | 3454554");
            CitiesListBox.Items.Add("Lansing | 54555544");
        } //end MainForm_Load

        // this method allows list to be viewed
        private void button1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(ViewButton);
            MainPanel.Controls.Add(InstLabel);
            InstLabel.Text = "Click the View Cities\n" +
                             "button to see your list.";
        } //end ViewButton_Click

        //****************************************************************************************

        // this method displays all items to add a city
        private void AddOptionButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            ErrorLabel.Text = "";

            MainPanel.Controls.Add(CitiesListBox);
            MainPanel.Controls.Add(EditCityTxtBox);
            MainPanel.Controls.Add(EditPopTxtBox);
            MainPanel.Controls.Add(AddButton);
            MainPanel.Controls.Add(InstLabel);
            InstLabel.Text = "Enter the name and the\n" +
                             "population of your city\n" +
                             "that you wish to add.Then\n" +
                             "click the Add City button.";
            MainPanel.Controls.Add(CityLabel);
            MainPanel.Controls.Add(PopLabel);
            MainPanel.Controls.Add(ErrorLabel);
        } // end AddOptionButton

        //this method displays all items to modify a city
        private void ModifyOptionButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(CitiesListBox);
            MainPanel.Controls.Add(EditCityTxtBox);
            MainPanel.Controls.Add(EditPopTxtBox);
            MainPanel.Controls.Add(CityLabel);
            MainPanel.Controls.Add(PopLabel);
            MainPanel.Controls.Add(InstLabel);
            InstLabel.Text = "Select the city that you\n" +
                             "wish to modify. Enter the\n" +
                             "new name and population. \n" +
                             "Then click the Edit City \n" +
                             " button";
            MainPanel.Controls.Add(EditButton);
        } // end ModifyOptionButton

        // this method displays all options to insert a city
        private void InsertOption_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(CitiesListBox);
            MainPanel.Controls.Add(InsertCityTxtBox);
            MainPanel.Controls.Add(InsertPopTxtBox);
            MainPanel.Controls.Add(CityLabel);
            MainPanel.Controls.Add(PopLabel);
            MainPanel.Controls.Add(InstLabel);
            InstLabel.Text = "Enter the city name and\n" +
                             "population. Select the \n" +
                             "city you wish to insert\n" + 
                             "the new city after. Then\n" +
                             "click the Insert City button";

            MainPanel.Controls.Add(InsertButton);
        } // end InsertOption_Click

        // this method displays all items to delete a city
        private void DeleteOptionButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(CitiesListBox);
            MainPanel.Controls.Add(DeleteButton);
            MainPanel.Controls.Add(InstLabel);
            InstLabel.Text = "Select the city that\n" +
                             "you wish to delete. \n" +
                             "Then click the Delete\n" +
                             "City button.";
        } // end DeleteOptionButton

        // this method displays all itmes to search for a city
        private void SearchOptionButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(SearchListBox);
            //MainPanel.Controls.Add(CitiesListBox);
            MainPanel.Controls.Add(EditCityTxtBox);
            MainPanel.Controls.Add(CityLabel);
            MainPanel.Controls.Add(SearchButtonTwo);
            MainPanel.Controls.Add(InstLabel);
            InstLabel.Text = "Type the name or \n" +
                             "part of the name \n" +
                             "of the city you  \n" +
                             "wish to search for.\n" +
                             "Then click the Search\n" +
                             "button.";
        } // end SearchOptionButton_Click


        // used with FormatOptionButton, this method will Uppercase the first letter or any letters followed by a space 
        static string UpperCase(string value)
        {
            char[] array = value.ToCharArray();

            if(array.Length >=1)
            {
                if(char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }

            for(int i=1; i<array.Length; i++)
            {
                if(array[i-1] == ' ')
                {
                    if(char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        } // end UpperCase

        // this method displays all items needed to Format the city list
        private void FormatOptionButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(SearchListBox);
            MainPanel.Controls.Add(InstLabel);
            InstLabel.Text = "Your list is now \n" +
                             "properly formatted.";
            SearchListBox.Items.Clear();
            

            foreach(string city in CitiesListBox.Items)
            {
                SearchListBox.Items.Add(UpperCase(city));
            }

            CitiesListBox.Items.Clear();
            foreach(string city in SearchListBox.Items)
            {
                CitiesListBox.Items.Add(city);
            }
        } // end FormatOptionButton_Click







        // this method adds a city to the search list if the city list contains it
        private void button1_Click_1(object sender, EventArgs e)
        {
            String name = EditCityTxtBox.Text;
            
            foreach (string city in CitiesListBox.Items)
            {
                
                if (city.Contains(name) && (!city.Equals("")))
                {
                    SearchListBox.Items.Add(city);
                }
            }
           // CitiesListBox.Items.Add(name);
        } // end SubmitButtonTwo

        // this method shows teh city list box
        private void ViewButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Add(CitiesListBox);
        } // end ViewButton_Click

    } // end class mainForm:Form
}
