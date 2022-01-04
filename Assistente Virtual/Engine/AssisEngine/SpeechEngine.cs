using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Forms;
using Assistente_Virtual.Services.GrammarServices;
using Assistente_Virtual;
using Assistente_Virtual.Services;
namespace Assistente_Virtual.Engine
{
    public class SpeechEngine
    {
        private static SpeechRecognitionEngine RecEngine;
        public static SpeechSynthesizer Speaker;
        private static CultureInfo language;
       
        public static List<String> ChatLines = new List<string>();

        public bool StandBye = true;
        public SpeechEngine()
        {
            Init();
        }

        private void Init()
        {
            try
            {
                language = new CultureInfo("pt-BR");
                RecEngine = new SpeechRecognitionEngine(language);
                Speaker = new SpeechSynthesizer();
                
            }
            catch(Exception e)
            {
                MessageBox.Show("Error in init: "+ e.Message);
            }

            Speaker.Volume = FormAssistente.instance.SliderVolume.Value;
            Speaker.Rate = 3;
            
            AssisGrammarLoad();
        }
                           
        
        private void AssisGrammarLoad()
        {
            #region Choices
            //Choices related with system commands like get hours, shutdown the computer or applications, etc...
            Choices System_choices = new Choices();
            System_choices.Add(Grammars.GetTimeGrammar().ToArray());
            //Choices related with Dialogues functions like chat or answer little questions
            System_choices.Add(Grammars.GetDialogGrammar().ToArray());
            //Choices related with the music player
            System_choices.Add(Grammars.GetMusicGrammar().ToArray());
            //Choices related with the search feature.
            System_choices.Add(Grammars.GetSearchGrammar().ToArray());
            #endregion
            #region GrammarBuilder
            GrammarBuilder grammarBuilder = new GrammarBuilder();
            grammarBuilder.Append(System_choices);
            

            #endregion
            #region Grammar
            try
            {
                Grammar grammar = new Grammar(grammarBuilder);
                
                try
                {
                    RecEngine.SetInputToDefaultAudioDevice();
                    Speaker.SetOutputToDefaultAudioDevice();
                   
                    RecEngine.RequestRecognizerUpdate();
                    RecEngine.LoadGrammarAsync(grammar);//Loads the grammar
                    RecEngine.SpeechRecognized += Rec_RecognizerStandBye;
                    RecEngine.SpeechRecognized += Rec_Recognizer;
                    
                    
                    RecEngine.AudioLevelUpdated += Rec_AudioLevel;
                    RecEngine.RecognizeAsync(RecognizeMode.Multiple);                 
                    
                }
               catch(Exception e)
                {
                    MessageBox.Show("Error on create the recognize: " + e.Message);
                }
                
            }
            catch(Exception e)
            {
                MessageBox.Show("An error as ocorred: " + e.Message);
            }
            finally
            {
                if(DateTime.Now.Hour < 12)
                {
                    Speaker.Speak("Bom dia!");
                }
                else if(DateTime.Now.Hour > 12)
                {
                    Speaker.Speak("Boa tarde!");
                }
            }
           
            #endregion
        }
        public void Rec_AudioLevel(object sender,AudioLevelUpdatedEventArgs e)
        {            
            if(e.AudioLevel > FormAssistente.instance.pbMicLevel.Maximum)
            {                
                FormAssistente.instance.pbMicLevel.Value = FormAssistente.instance.pbMicLevel.Maximum;
            }
           else if(e.AudioLevel < FormAssistente.instance.pbMicLevel.Minimum)
           {
                FormAssistente.instance.pbMicLevel.Value = FormAssistente.instance.pbMicLevel.Minimum;
           }
            else
            {
                FormAssistente.instance.pbMicLevel.Value = e.AudioLevel;
            }
        }
       public void Rec_RecognizerStandBye(object sender, SpeechRecognizedEventArgs e)
        {
            string result = e.Result.Text;
            string say = "";
            

            if(result == "Annie Acorde")
            {
                StandBye = false;
                
                say = "Estou aqui";
                
                Speaker.Speak(say);                
            }
            else if(result == "Annie Suspender")
            {
                StandBye = true;
                
                say = "Se precisar é só chamar...";

                Speaker.Speak(say);
            }
            
        }
        public void Rec_Recognizer(object sender,SpeechRecognizedEventArgs e)
        {
            string result = e.Result.Text;
                                   
            Speaker.SpeakAsync(SpeakerService.SpeakerSystem(result, StandBye, Speaker));
        }
    }
}
