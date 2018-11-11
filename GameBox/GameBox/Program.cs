using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBox
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
            Application.Run(new Form1());
        }
        public static string user1 = "", user2 = "";
        public static Boolean TypeUser; /* Guest=0, User=1 */
        public static Boolean GameChoice; /* true = reversi, false = LAS */
        public static int cnt_players;  //1= 1 player , 2 = 2 players
    }
}
