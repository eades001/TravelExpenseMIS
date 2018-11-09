using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*****************************************/
/*  Project 5:   Travel Expense MIS      */
/*  Author:      Lynn Eades              */
/*  Date:        11/12/2018              */
/*****************************************/

namespace TravelExpenseMIS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new travelExpenseForm());
        }
    }
}
