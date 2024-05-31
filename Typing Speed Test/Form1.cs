using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// fill the text to write
// start timer
// check when the timer finished
/// count the written words 

namespace Typing_Speed_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private string[] texts = {
                "The quick brown fox jumps over the lazy dog.",
                "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness.",
                "A journey of a thousand miles begins with a single step.",
                "The unexamined life is not worth living.",
                "The sun set over the horizon, casting a warm glow over the rolling hills and tranquil lake.",
                "Water is composed of two hydrogen atoms bonded to one oxygen atom, forming the molecule H2O.",
                "The first manned moon landing was accomplished by NASA's Apollo 11 mission in 1969.",
                "I have a dream that my four little children will one day live in a nation where they will not be judged by the color of their skin but by the content of their character.",
                "Artificial intelligence is transforming industries with innovations like machine learning and natural language processing.",
                "In the midst of winter, I found there was, within me, an invincible summer."
        };
        private byte currentTextIndex = 0;
        private int mistakes = 0;
        private int seconds = 0;
        private int writtenLetters = 0;
        private void FillTheText()
        {
            if (texts.Length > currentTextIndex)
            {
                tbPreviewText.Text = texts[currentTextIndex];
            } else
            {
                // to be written...
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FillTheText();
            tbWriteArea.Enabled = true;
            tbWriteArea.Focus();
            TurnTimerOnOff();
        }

        private void TurnTimerOnOff()
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void tbWriteArea_TextChanged(object sender, EventArgs e)
        { 
            int lastIdx = tbWriteArea.Text.Length - 1;
            
            if (tbPreviewText.Text.Length > lastIdx && lastIdx >= 0)
            {
                if (tbWriteArea.Text[lastIdx] != tbPreviewText.Text[lastIdx])
                {
                    mistakes++;
                    tbWriteArea.BackColor = Color.Red;
                    return;
                } else
                {
                    tbWriteArea.BackColor = SystemColors.Menu;
                }
            }

            if (tbWriteArea.Text.Length == tbPreviewText.Text.Length) 
            {
                currentTextIndex++;
                FillTheText();
                tbWriteArea.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTimerText();

            if (seconds == 60)
            {
                timer1.Enabled = false;
                tbWriteArea.Enabled = false;
                ShowResults();
            }
        }

        private void UpdateTimerText()
        {
            seconds++;

            int minutes = seconds / 60;
            int remainingSeconds = seconds % 60;

            lblTimerCounter.Text = $"{(minutes <= 9 ? $"0{minutes}" : minutes.ToString())}:{(remainingSeconds <= 9 ? $"0{remainingSeconds}" : remainingSeconds.ToString())}";
        }

        private int GetWrittenWords()
        {
            int count = 0;
            
            for (int i = 0; i < currentTextIndex; i++)
            {
                count += texts[i].Split(' ').Length;
                writtenLetters += texts[i].Length;
            }

             count += tbWriteArea.Text.Split(' ').Length;
             writtenLetters += tbWriteArea.Text.Length;

            return count;
        }

        private void ShowResults()
        {
            int words = GetWrittenWords();
            
            Form frmResults = new FrmResults(words, writtenLetters, mistakes);
            frmResults.ShowDialog();
            seconds = 0;
        }
    }
}
