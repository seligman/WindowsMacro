using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeysTestApp
{
    public partial class ExampleForm : Form
    {
        string m_todo = "";
        Action m_todoRun = null;
        DateTime m_runAt = DateTime.MinValue;

        public ExampleForm()
        {
            InitializeComponent();
        }

        void timerTick_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now >= m_runAt)
            {
                timerTick.Enabled = false;
                labelTicker.Text = "";
                m_todoRun();
            }
            else
            {
                labelTicker.Text =
                    (m_runAt - DateTime.Now).TotalSeconds.ToString("0") +
                    " secs: " + m_todo;
            }
        }

        void useSendKeys_Click(object sender, EventArgs e)
        {
            Launch(TimeSpan.FromSeconds(10), "Send Keys", RunSendKeys);
        }

        void useKeys_Click(object sender, EventArgs e)
        {
            Launch(TimeSpan.FromSeconds(10), "Keys", RunKeys);
        }

        void Launch(TimeSpan span, string desc, Action action)
        {
            m_runAt = DateTime.Now.Add(span);
            m_todo = desc;
            m_todoRun = action;
            timerTick.Enabled = true;

            timerTick_Tick(null, EventArgs.Empty);
        }

        void RunSendKeys()
        {
            SendKeys.Send("Hello, wold{left}{left}r{right}{right}!");
        }

        void RunKeys()
        {
            ScottsUtils.Keys.PressSendKeys("Hello, wold{left}{left}r{right}{right}!");
        }
    }
}
