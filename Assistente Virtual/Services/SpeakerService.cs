using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
namespace Assistente_Virtual.Services
{
    class SpeakerService
    {
        
        internal  static string SpeakerSystem(string result,bool StandBye,SpeechSynthesizer Speaker)
        {
            string Say = "";
            if (!StandBye)
            {
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
                        Say = DateTime.Now.ToString("dddd", new CultureInfo("pt-BR"));
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
                    case "Nexus Acorde":
                        Say = "";
                        break;
                    case "Nexus Suspender":
                        Say = "";
                        break;
                    default:
                        Say = "Não entendi o que disse, talvez eu ainda não possua tal gramática";
                        break;
                }
            }
            return Say.ToString();
        }
        
    }
}
