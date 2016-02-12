using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocabularys
{
    public partial class Form1 : Form
    {
        private int chineseTimeLeft = 3;
        private int englishTimeLeft = 2;

        private List<string> chinese = new List<string>();
        private string[] chineseWords = new string[] { };

        private List<string> english = new List<string>();
        private string[] englishWords = new string[] { };

        private List<string> previousChinese = new List<string>();
        private string[] previousChineseWords = new string[] { };
        private List<string> previousEnglish = new List<string>();
        private string[] previousEnglishWords = new string[] { };

        private int orderOfPrevious;

        private bool isPlaying = false;
        private bool isEnglishShowed = false;
        private int timeLeft = 0;
        private int rand = 0;

        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            Encoding.GetEncoding("gb2312");
            String[] lines = System.IO.File.ReadAllLines(@"texts/Words.txt", Encoding.Default);

            foreach (String line in lines)
            {
                char[] spliteChar = { ':' };
                string[] wordOfThisLine = line.Split(spliteChar);

                english.Add(wordOfThisLine[0]);
                chinese.Add(wordOfThisLine[1]);
            }

            chineseWords = chinese.ToArray();
            englishWords = english.ToArray();
            orderOfPrevious = previousChineseWords.Length - 1;

            EnglishLabel.Hide();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                stopPlay();
            }
            else
            {
                beginPlay();
            }
        }

        private void beginPlay()
        {
            String[] lines = System.IO.File.ReadAllLines(@"texts/Setting.txt", Encoding.Default);
            chineseTimeLeft = Int16.Parse(lines[0]);
            englishTimeLeft = Int16.Parse(lines[1]);
            timeLeft = chineseTimeLeft;

            PlayButton.Image = Image.FromFile("res/Pause.png");
            isPlaying = !isPlaying;
            timer1.Start();

            if (ChineseLabel.Text == "Ready?")
            {
                gotoNextWord();
            }
        }
        private void stopPlay()
        {
            PlayButton.Image = Image.FromFile("res/Play.png");
            isPlaying = !isPlaying;
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            if (orderOfPrevious < 1)
            {
                return;
            }

            if (isPlaying)
            {
                stopPlay();
            }

            orderOfPrevious--;
            ChineseLabel.Text = previousChineseWords[orderOfPrevious];
            EnglishLabel.Text = previousEnglishWords[orderOfPrevious];
            showEnglish();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                timeLeft = chineseTimeLeft;
                stopPlay();
            }

            if (!isEnglishShowed)
            {
                showEnglish();
            }
            else if (orderOfPrevious == previousChineseWords.Length - 1)
            {
                gotoNextWord();
            }
            else
            {
                orderOfPrevious++;
                ChineseLabel.Text = previousChineseWords[orderOfPrevious];
                EnglishLabel.Text = previousEnglishWords[orderOfPrevious];
                hideEnglish();
            }
        }

        private void gotoNextWord()
        {
            string chinese = ChineseLabel.Text;
            previousChinese.Add(chinese);
            previousChineseWords = previousChinese.ToArray();

            string english = EnglishLabel.Text;
            previousEnglish.Add(english);
            previousEnglishWords = previousEnglish.ToArray();

            rand = random.Next(chineseWords.Length);
            ChineseLabel.Text = chineseWords[rand];
            EnglishLabel.Text = englishWords[rand];

            orderOfPrevious = previousChineseWords.Length - 1;

            hideEnglish();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                timer1.Stop();
                timeLeft = chineseTimeLeft;
                TimeLabel.Text = timeLeft.ToString();
            }
            else if (timeLeft > 0)
            {
                timeLeft--;
                TimeLabel.Text = timeLeft.ToString();
            }
            else
            {
                if (!isEnglishShowed)
                {
                    showEnglish();
                    return;
                }

                TimeLabel.Text = timeLeft.ToString();

                if (orderOfPrevious == previousChineseWords.Length - 1)
                {
                    gotoNextWord();
                }
                else
                {
                    orderOfPrevious++;
                    ChineseLabel.Text = previousChineseWords[orderOfPrevious];
                    EnglishLabel.Text = previousEnglishWords[orderOfPrevious];
                    hideEnglish();
                }
            }
        }

        private void hideEnglish()
        {
            timeLeft = chineseTimeLeft;
            TimeLabel.Text = timeLeft.ToString();
            EnglishLabel.Hide();
            isEnglishShowed = false;
        }

        private void showEnglish()
        {
            timeLeft = englishTimeLeft;
            TimeLabel.Text = timeLeft.ToString();
            EnglishLabel.Show();
            isEnglishShowed = true;
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                stopPlay();
            }
            Setting f = new Setting();
            f.Show();
        }

        private void feedBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                stopPlay();
            }
            Feedback f = new Feedback();
            f.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                stopPlay();
            }
            System.Diagnostics.Process.Start(@"notepad.exe", @"texts/Help.txt");
        }

        private void sourseCodeOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                stopPlay();
            }
            Source f = new Source();
            f.Show();
        }
    }
}
