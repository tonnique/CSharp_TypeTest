using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO; 

namespace TypeTest
{
    public partial class frmTyper : Form
    {
        private const int numOfTextPatternsForTask = 200;
        private const string filesPath = @"..\..\Files\";
        private const string messageRus = "Начните печатать здесь и время начнёт отсчёт.";
        private const string messageEn = "Start typing here and time will begin count up.";

        private bool startTyping = false;
        private int mistypes = 0;
        private int textPosition = 0;        
        private string taskString = string.Empty;
        private int secondsWent = 0; //seconds spent
        private int spm = 0; //SymbolPerMinutes
        private Thread timeThread;

        #region menu arrays
        private string[] russTasks = new string[] {
            "Задание 1 (ао)",
            "Задание 2 (а о)" ,
            "Выражения"
        };

        private string[] engTasks = new string[] {
            "Task 1 (dk)",
            "Task 2 (d k)",
            "Aesop Fables",
            "Space Cowboys",
            "TigerInTheWild",
            "Phrases"
        };
        #endregion 

        string[] rusTaskFile = new string[] {"", "", "phrases_censored.ru"};
        string[] engTaskFile = new string[] {"", "", "Aesop", "SpaceCowboys",  "TigerInTheWild", "phrases.en"};

        public frmTyper()
        {
            InitializeComponent();
        }

        // Changing the Language of the typing test 
        private void lblLang_Click(object sender, EventArgs e)
        {
            cmbTask.Items.Clear();
            if (lblLang.Text == "RU")
            { 
                lblLang.Text = "EN";                
                cmbTask.Items.AddRange(engTasks);                
            }
            else 
            {
                lblLang.Text = "RU";                
                cmbTask.Items.AddRange(russTasks);                
            }
            
            cmbTask.SelectedIndex = 0;
            cmbTask.SelectionLength = cmbTask.Text.Length;            
        }

        private void cmbTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            rchTxtBoxTask.Clear();

            if (lblLang.Text == "RU")
            {
                switch (cmb.SelectedIndex)
                { 
                    case 0:
                        
                        taskString = prepareTask("ао");                        
                        break;
                    case 1:            
                        taskString = prepareTask("а о");                        
                        break;
                    case 2:
                        taskString = readFile(rusTaskFile[cmb.SelectedIndex]);
                        break;
                }                
            }
            else
            {
                switch (cmb.SelectedIndex)
                {
                    case 0:                        
                        taskString = prepareTask("dk");                        
                        break;
                    case 1:                        
                        taskString = prepareTask("d k");
                        break;
                    case 2:                    
                    case 3:                        
                    case 4:                    
                    case 5:
                        taskString = readFile(engTaskFile[cmb.SelectedIndex]);
                        break;
                }
            
            }
            // Text for an exercise
            rchTxtBoxTask.Text = taskString;

            textPosition = 0; // Set to zero position
            mistypes = 0; // Set to zero errors
            lblErrors.Text = mistypes.ToString(); // Change information about errors 

            secondsWent = 0; // time went
            lblTime.Text = secondsWent.ToString(); 

            putCommentIntoUserControl(); // a marker if we start typing
            startTyping = false; // Set comment, where to type and when timer is active            
        }

        // Fills a resulting text for task with given pattern
        private string prepareTask(string s)
        {
            string tempStr = string.Empty;

            for (int i = 0; i < numOfTextPatternsForTask; i++) 
            {
                tempStr += s + " ";
            }
            
            return tempStr;
        }

        //This method handles event which occurs when Form is Shown for the first time
        private void frmTyper_Shown(object sender, EventArgs e)
        {
            lblErrors.Text = mistypes.ToString();
            lblLang.Text = "EN";
            cmbTask.Items.AddRange(engTasks);
            cmbTask.SelectedIndex = 0;            
            putCommentIntoUserControl();
        }

        private void rchTxtBoxUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!startTyping)
            {
                rchTxtBoxTask.Select(0, taskString.Length);
                rchTxtBoxTask.SelectionColor = System.Drawing.Color.Black;
                rchTxtBoxTask.Select(0, 0);

                rchTxtBoxUser.Clear();
                startTyping = true;

                timeThread = new Thread(timeCountDown);
                timeThread.Name = "timeThread";
                timeThread.Start();
            }

            if (e.KeyChar.ToString() == taskString.Substring(textPosition, 1))
            {
                
                rchTxtBoxTask.Select(textPosition, 1);
                rchTxtBoxTask.SelectionColor = System.Drawing.Color.Blue;
                rchTxtBoxTask.ScrollToCaret();

                rchTxtBoxUser.Select(textPosition, 1);
                rchTxtBoxUser.SelectionColor = System.Drawing.Color.Black;
                textPosition++;

                if (textPosition >= taskString.Length)
                { 
                    typeTestFinish();
                }
            }
            else
            {
                if (e.KeyChar.ToString() != "\b")
                {
                    mistypes++;
                    lblErrors.Text = mistypes.ToString();
                    rchTxtBoxUser.Select(textPosition, 1);
                    rchTxtBoxUser.SelectionColor = System.Drawing.Color.Red;                    
                }
            }
        }

        //This method puts the comment into rchTxtBoxUser telling a user where to type and when timer is activated
        private void putCommentIntoUserControl()
        {
            string tmpMessage = (lblLang.Text == "RU") ? messageRus : messageEn;

            if (rchTxtBoxUser.InvokeRequired) 
            {
                rchTxtBoxUser.Invoke(new Action<string>((s) => rchTxtBoxUser.Text = s), tmpMessage);
                rchTxtBoxUser.Invoke(new Action(() => rchTxtBoxUser.Select(0, rchTxtBoxUser.Text.Length)));
                rchTxtBoxUser.Invoke(new Action(() => rchTxtBoxUser.SelectionColor = System.Drawing.Color.Gray));                
                rchTxtBoxUser.Invoke(new Action(() => rchTxtBoxUser.Select(0, 0)));
                rchTxtBoxUser.Invoke(new Action(() => rchTxtBoxUser.Focus()));
            }
            else {
                rchTxtBoxUser.Text = tmpMessage;
                rchTxtBoxUser.Select(0, rchTxtBoxUser.Text.Length);
                rchTxtBoxUser.SelectionColor = System.Drawing.Color.Gray;
                rchTxtBoxUser.Select(0, 0);
                rchTxtBoxUser.Focus();
            }            
        }

        private void timeCountDown()
        {
            int secondsLeft = int.Parse(numUpDownMinutes.Value.ToString()) * 60;            

            while (secondsLeft > 0 && startTyping == true)
            {
                lblTime.Invoke(new Action<string>((s) => lblTime.Text = s), secondsWent.ToString()); 
                Thread.Sleep(1000);
                secondsLeft--;
                secondsWent++;
                
                spm = (int)((float)textPosition / ((float)secondsWent / 60));
            }

            if (startTyping) 
                typeTestFinish();
        }

        private void ShowEndStatistics()
        { 
            string message = string.Empty;
            if(lblLang.Text == "RU")
            {
                message = "Время вышло!\n";
                message += "Потрачено времени: ";
                if (secondsWent > 60)
                {
                    message += secondsWent / 60 + "мин. ";
                    secondsWent = secondsWent % 60;                    
                }
                
                message += (secondsWent > 0) ? secondsWent + " сек.\n" : "\n";

                message += "Скорость набора: " + spm +" символов в минуту\n";
                message += "Процент ошибок: " + (float)(mistypes * 100 / textPosition) + " %";
            }
            else
            {
                message = "Time's up!\n";
                message += "Spent time: ";
                if (secondsWent > 60)
                {
                    message += secondsWent / 60 + "min. ";
                    secondsWent = secondsWent % 60;
                }

                message += (secondsWent > 0) ? secondsWent + " sec.\n" : "\n";

                message += "Type speed: " + spm + " symbols per minute\n";
                message += "Errors : " + (float)(mistypes * 100 / textPosition) + " %";               
            }           

            MessageBox.Show(message);
        }

        private void frmTyper_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (timeThread != null) { timeThread.Abort(); }            
        }

        private void typeTestFinish()
        {
            if (startTyping)
            {
                startTyping = false;
                ShowEndStatistics();
            }

            mistypes = 0;
                        
            
            if (lblErrors.InvokeRequired) { lblErrors.Invoke(new Action<string>((s) => lblErrors.Text = s), "0"); }
            else { lblErrors.Text = "0"; }
            if (lblTime.InvokeRequired) { lblTime.Invoke(new Action<string>((s) => lblTime.Text = s), "0"); }
            else { lblTime.Text = "0";}            
        
            textPosition = 0;
            secondsWent = 0;

            putCommentIntoUserControl();           

            if (timeThread != null)
            {
                try
                {
                    timeThread.Abort();
                }
                catch { }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {            
            typeTestFinish();            
        }

        private string readFile(string file)
        { 
            string strTemp = string.Empty;

            if (File.Exists(filesPath + file))
            {
                try
                {
                    strTemp = File.ReadAllText(filesPath + file);
                }
                catch { MessageBox.Show("Error while opening file " + file);}
            }
            return strTemp;
        }
    
    }
}
