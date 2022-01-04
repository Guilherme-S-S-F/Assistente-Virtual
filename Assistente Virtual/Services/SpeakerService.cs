using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using Assistente_Virtual.Engine;
using Assistente_Virtual.Services.GrammarServices;
namespace Assistente_Virtual.Services
{
    class SpeakerService
    {
        public static bool musicOpened = false;
        public static ExecuteFile execute = new ExecuteFile();
        public static bool MusicMode = false;
        internal static string SpeakerSystem(string result, bool StandBye, SpeechSynthesizer Speaker)
        {
            
            string Say = "";
            if (!StandBye)
            {
                if (!MusicMode)
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
                        case "Abrir Musica":
                            FormAssistente.OpenMusic();
                            Say = "Que músicas você quer hoje?";
                            MusicMode = true;
                            break;
                        case "Ligar Modo Música":
                            MusicMode = true;
                            Say = "Modo música está ativado";
                            break;
                        case "Abrir Google":
                            execute.OpenGoogle();
                            Say = "Abrindo google";
                            break;
                        case "Abrir Youtube":
                            execute.OpenYoutube();
                            Say = "Abrindo Youtube";
                            break;
                        case "Abrir Glossário Unity":
                            execute.OpenUnityAPI();
                            Say = "Abrindo o Glossário";
                            break;
                        case "Abrir Loja Unity":
                            execute.OpenUnityAssets();
                            Say = "Abrindo a loja do unity";
                            break;
                        case "Abrir Calculadora":
                            execute.OpenCalc();
                            Say = "Abrindo a calculadora";
                            break;
                        default:
                            Say = "";
                            break;
                    }

                }
                else if (MusicMode)
                {
                    switch (result)
                    {
                        case "Pausar Música":
                            if (musicOpened)
                            {
                                FormMusic.instance.StopMusic();
                                Say = "";
                            }
                            else
                            {
                                Say = "Player de música não está aberto";
                            }
                            break;
                        case "Despausar Música":
                            if (musicOpened)
                            {
                                FormMusic.instance.PlayMusic();
                                Say = "";
                            }
                            else
                            {
                                Say = "Player de música não está aberto";
                            }
                            break;
                        case "Próxima Música":
                            if (musicOpened)
                            {
                                FormMusic.instance.NextPlaylistMusic();
                            }
                            else
                            {
                                Say = "Player de música não está aberto";
                            }
                            break;
                        case "Música Anterior":
                            if (musicOpened)
                            {
                                FormMusic.instance.PreviousMusic();
                            }
                            else
                            {
                                Say = "Player de música não está aberto";
                            }
                            break;                       
                        case "Desligar Modo Música":
                            MusicMode = false;
                            Say = "Modo música está desativado";
                            break;
                        default:
                            Say = "";
                            break;
                    }
                }
                
            }
            return Say.ToString();
        }
    }
}