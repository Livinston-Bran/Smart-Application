using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
using System.Drawing.Imaging;

namespace Smart_Application
{
    public partial class Assistant : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer speech = new SpeechSynthesizer();
        System.Media.SoundPlayer music = new System.Media.SoundPlayer();
        public Assistant()
        {
            InitializeComponent();

            Choices choices = new Choices();
            string[] text = File.ReadAllLines(Environment.CurrentDirectory + "//grammer.txt");
            choices.Add(text);
            Grammar grammar = new Grammar(new GrammarBuilder(choices));
            recEngine.LoadGrammar(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            recEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recEngine_SpeechRecognized);

            speech.SelectVoiceByHints(VoiceGender.Female);
        }

        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string result = e.Result.Text;

            if (result == "Hello Zain")
            {
                result = "Hello, I am Zain State your Command";
            }

            if (result == "Lights On")
            {
                result = "Activated";
            }

            if (result == "Refridgerator On")
            {
                result = "Activated";
            }

            if (result == "Air Conditioner On")
            {
                result = "Activated";
            }

            if (result == "Temprature On")
            {
                result = "Activated";
            }

            if (result == "Lights Off")
            {
                result = "Dectivated";
            }

            if (result == "Refridgerator Off")
            {
                result = "Deactivated";
            }

            if (result == "Air Conditioner Off")
            {
                result = "Deactivated";
            }

            if (result == "Temprature Off")
            {
                result = "Deactivated";
            }

            
            if (result == "EXIT")
            {
                this.Hide();
            }


            speech.SpeakAsync(result);
            txtlabel.Text = result;
        }

        private void Assistant_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
