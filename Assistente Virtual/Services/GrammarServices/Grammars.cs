using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Assistente_Virtual.Services.GrammarServices
{
    class Grammars
    {
        private static List<string> TimeGrammar = new List<string>();
        private static List<string> DialogGrammar = new List<string>();

        public static List<string> GetTimeGrammar()
        {
            string path = Application.StartupPath + @"\Resources\GrammarsFiles\TimeGrammar.txt";
            if (!File.Exists(path))
            {
                return null;
            }
            string[] lines = File.ReadAllLines(path);

            foreach(string i in lines)
            {
                TimeGrammar.Add(i);
            }

            return TimeGrammar;
        }
        public static List<string> GetDialogGrammar()
        {
            string path = Application.StartupPath + @"\Resources\GrammarsFiles\DialogGrammar.txt";
            if (!File.Exists(path))
            {
                return null;
            }
            string[] lines = File.ReadAllLines(path);

            foreach (string i in lines)
            {
                DialogGrammar.Add(i);
            }

            return DialogGrammar;
        }
    }
}
