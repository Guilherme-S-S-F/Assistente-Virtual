using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Assistente_Virtual.Services
{
    public class ExecuteFile
    {
        //Navigator Sites
        public void OpenGoogle()
        {                 
            Process.Start(@"https://www.google.com/webhp?hl=pt-BR&ictx=2&sa=X&ved=0ahUKEwjcwcHlgdj0AhW-ppUCHaYdCawQPQgI");
        }
        public void OpenYoutube()
        {
            Process.Start(@"https://www.youtube.com");
        }
        public void OpenUnityAPI()
        {
            Process.Start(@"https://docs.unity3d.com/ScriptReference/");
        }
        public void OpenUnityAssets()
        {
            Process.Start(@"https://assetstore.unity.com");
        }
        //Apps
        public void OpenCalc()
        {
            Process.Start("calc.exe");
        }
        //Google Search
        public void SearchOnGoogle(string search)
        {
            Process.Start("https://www.google.com/search?q=" + search);
        }
    }
}
