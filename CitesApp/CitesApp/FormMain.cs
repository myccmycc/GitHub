using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CitesApp
{
    public partial class FormMain : Form
    {
        private KeyboardCtrl_V3.KeyboardCtrl keyboardCtrl1;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Rectangle screenRect = Screen.AllScreens[0].Bounds;
            this.Location = new Point(0, 0);
            this.Size = new Size(screenRect.Width,screenRect.Height);

            axShockwaveFlash1.Location = new Point(0, 0);
            axShockwaveFlash1.Size = new Size(screenRect.Width,screenRect.Height);

            axShockwaveFlash1.Movie = Application.StartupPath + "\\CitesAppFlash.swf";

            //===========step2:建立Keyboard实例================//
            this.keyboardCtrl1 = new KeyboardCtrl_V3.KeyboardCtrl();
            this.keyboardCtrl1.Location = new System.Drawing.Point(screenRect.Width / 2 - keyboardCtrl1.Width / 2, screenRect.Height);
            this.keyboardCtrl1.Name = "keyboardCtrl1";
           // this.keyboardCtrl1.Size = new System.Drawing.Size(942, 208);
            this.keyboardCtrl1.TabIndex = 3;
            this.Controls.Add(this.keyboardCtrl1);
            keyboardCtrl1.BringToFront();

           
        }

        private void axShockwaveFlash1_FSCommand(object sender, AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEvent e)
        {
            if (e.command == "keyboard")
            {
                if (e.args == "show")
                    keyboardCtrl1.ShowKeyBoard(true);
                else if (e.args == "hide")
                    keyboardCtrl1.ShowKeyBoard(false);

            }

            if (e.command == "cites")
            {
                //常见问题模块
                if (e.args == "question")
                {
                    textBox1.Location = new Point(60, 335);
                    textBox1.Text = "请输入你要查询的内容....";
               
                }

            }

        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            keyboardCtrl1.ShowKeyBoard(true);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            keyboardCtrl1.ShowKeyBoard(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            XDocument xd = XDocument.Load(Application.StartupPath + "\\questions.xml");
            XElement rt = xd.Element("Root");

            IEnumerable<XElement> questions = rt.Elements();
            foreach(XElement ques in questions)
            {
                XElement questionTitle = ques.Element("QuestionTitle");
                if (questionTitle.Value.IndexOf(textBox1.Text)>=0)
                MessageBox.Show(questionTitle.Value.ToString());
                XElement questionText =  ques.Element("QuestionText");
                
            }

            
        }
    }
}
