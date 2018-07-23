using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public partial class ParentForm : Form
    {
        private Timer timer;
        private TimeSpan timeSpan;
        private object labelTime;
        private readonly TimeSpan oneSecond = new TimeSpan(0, 0, 1);
        public ParentForm()
        {
            InitializeComponent();
            timer = new Timer
            {
                Interval = 1000
            };
            timer.Tick += new EventHandler(TimerTick);
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            timeSpan = timeSpan.Add(oneSecond);
            labelTime.Text = timeSpan.ToString();
        }

        private void ButtonStopclick_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            timeSpan = new TimeSpan(0, 0, 0);
            timer.Enabled = false; ;
        }

        private void labelTime_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
