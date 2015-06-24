using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormIntroApp
{
    public partial class SearchCourseUI : Form
    {
        public SearchCourseUI()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            myDictionary.Add(101, "CSE101");
            myDictionary.Add(102, "CSE102");
            myDictionary.Add(103, "EEE111");
            myDictionary.Add(104, "EEE222");

            if (codeTextBox.Text == "")
            {
                MessageBox.Show("Enter Code");
            }
            else
            {
                int code = Convert.ToInt32(codeTextBox.Text);

                if (myDictionary.ContainsKey(code))
                {
                    MessageBox.Show(myDictionary[code]);
                }
                else
                {
                    MessageBox.Show("Not Found!");
                }

                codeTextBox.Clear();
            }


        }
    }
}
