using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Assis_Serializer;

namespace Assistente_Virtual.Services.GrammarServices
{
    class Grammars
    {
        private static List<string> TimeGrammar = new List<string>();
        private static List<string> DialogGrammar = new List<string>();
        private static List<string> MusicGrammar = new List<string>();
        private static List<string> SearchGrammar = new List<string>();
        
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
        public static List<string> GetMusicGrammar()
        {
            string path = Application.StartupPath + @"\Resources\GrammarsFiles\MusicGrammar.txt";
            if (!File.Exists(path))
            {
                return null;
            }
            string[] lines = File.ReadAllLines(path);

            foreach (string i in lines)
            {
                MusicGrammar.Add(i);
            }

            return MusicGrammar;
        }
        public static List<string> GetSearchGrammar()
        {
            string path = Application.StartupPath + @"\Resources\GrammarsFiles\SearchGrammar.txt";
            if (!File.Exists(path))
            {
                return null;
            }
            string[] lines = File.ReadAllLines(path);

            foreach (string i in lines)
            {
                SearchGrammar.Add(i);
            }

            return SearchGrammar;
        }
    }
}
