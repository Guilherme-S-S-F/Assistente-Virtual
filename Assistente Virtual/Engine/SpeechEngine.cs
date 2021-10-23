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
namespace Assistente_Virtual.Engine
{
    public class SpeechEngine
    {
        private static SpeechRecognitionEngine RecEngine;
        private static SpeechSynthesizer Speaker;
        private static CultureInfo language;

        public static List<String> ChatLines = new List<string>();

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

            Speaker.Volume = 100;
            Speaker.Rate = 3;

            AssisGrammarLoad();
        }

        private void AssisGrammarLoad()
        {
            #region Choices
            //Choices related with system commands like get hours, shutdown the computer or applications, etc...
            Choices System_choices = new Choices();
            System_choices.Add(Grammars.GetTimeGrammar().ToArray());
            System_choices.Add(Grammars.GetDialogGrammar().ToArray());
            //Choices related with Dialogues functions like chat or answer little questions
            
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
           
            #endregion
        }
        public void Rec_AudioLevel(object sender,AudioLevelUpdatedEventArgs e)
        {
            if(e.AudioLevel > FormAssistente.instance.probMicLevel.Maximum)
            {
                FormAssistente.instance.probMicLevel.Value = FormAssistente.instance.probMicLevel.Maximum;
            }
           else if(e.AudioLevel < FormAssistente.instance.probMicLevel.Minimum)
            {
                FormAssistente.instance.probMicLevel.Value = FormAssistente.instance.probMicLevel.Minimum;
            }
            else
            {
                FormAssistente.instance.probMicLevel.Value = e.AudioLevel;
            }
        }
        public void Rec_Recognizer(object sender,SpeechRecognizedEventArgs e)
        {
            string result = e.Result.Text;
            string Say;

            
            ChatLines.Add("Me: " + result);
                switch (result)
                {
                    case "Que horas são":
                    Say = DateTime.Now.ToShortTimeString();
                        break;
                    case "Me Diga as horas":
                    Say = DateTime.Now.ToShortTimeString();
                        break;
                    case "Quais são as horas":
                    Say = DateTime.Now.ToShortTimeString();
                        break;
                    case "Que dia é hoje":
                    Say = DateTime.Now.ToLongDateString();
                        break;
                    case "Em que dia da semana estamos":
                    Say = DateTime.Now.ToString("dddd", language);
                        break;
                    case "Me dê a data completa":
                    Say = DateTime.Now.ToLongDateString();
                        break;
                    case "Oi":
                    Say = "olá.";
                        break;
                    case "Como vai":
                    Say = "Vou bem, e você?";
                        break;
                    case "Qual seu nome":
                    Say = "Eu ainda não possuo um nome.";
                        break;
                    case "Quem te criou":
                    Say = "Um grande programador, não sei seu nome... mas sei que ele é um gênio.";
                        break;
                    case "Como você está":
                    Say = "Eu não sinto nada, mas para você se sentir mais confortável, eu estou bem.";
                        break;
                    case "Oque é você":
                    Say = "Eu sou uma assistente virtual em desenvolvimento";
                        break;
                    case "até mais":
                    Say = "até.";
                        break;
                    case "tchau":
                    Say = "tchau";
                        break;
                    case "Fechar":
                        Application.Exit();
                    Say = "";
                        break;
                    case "Ocultar janela":
                    FormAssistente.instance.Hide();
                    Say = "Ok, ocultando";
                        break;
                case "Mostrar janela":
                    FormAssistente.instance.Show();
                    Say = "Ok, mostrando";
                    break;
                case "Fica quieta":
                    Speaker.Pause();
                    Say = "...";
                    Speaker.SpeakAsyncCancelAll();
                    Speaker.Resume();
                    break;
                    default:
                    Say = "Não entendi o que disse, talvez eu ainda não possua tal gramática";
                        break;
                }
            
            ChatLines.Add("Assis: " + Say);
            FormAssistente.instance.LoadChatInfo();
            Speaker.SpeakAsync(Say);
        }
    }
}
