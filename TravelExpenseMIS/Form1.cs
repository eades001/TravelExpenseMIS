using System;
using System.Windows.Forms;

/*****************************************/
/*  Project 5:   Travel Expense MIS      */
/*  Author:      Lynn Eades              */
/*  Date:        11/12/2018              */
/*****************************************/

namespace TravelExpenseMIS
{
    public partial class travelExpenseForm : Form
    {
        public travelExpenseForm()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
