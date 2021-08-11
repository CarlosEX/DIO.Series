using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DIOSeries.UI.View.Controls {
    public partial class WindowVideoPlayer : UserControl {
        
        public WindowVideoPlayer() {
            InitializeComponent();
            HideControlsDefaultControlVideo();
            this.buttonPlayPause.Click += ButtonPlay_Click;
        }

        [Category("Control Video")]
        public void URL(string url) {
            axWindowsMediaPlayer1.URL = url;

            var timer = timer1;
            timer.Interval = 1000;
            timer.Tick += new EventHandler(OnTimedEvent);
            timer.Enabled = true;

            this.buttonPlayPause.Image = Properties.Resources.image_pause;

        }

        private void HideControlsDefaultControlVideo() {
            axWindowsMediaPlayer1.uiMode = "None";
        }

        public void Play(AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer) {
            
            if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying) {
                axWindowsMediaPlayer.Ctlcontrols.pause();
                this.buttonPlayPause.Image = Properties.Resources.image_play;
            }
            else {
                axWindowsMediaPlayer.Ctlcontrols.play();
                this.buttonPlayPause.Image = Properties.Resources.image_pause;
            }

        }

        public void Pause(AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer) {
            axWindowsMediaPlayer.Ctlcontrols.pause();
        }

        private void TimerEventProcessor() {
            try {
                var duraction = axWindowsMediaPlayer1.currentMedia.duration;
                var currentPosition = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                double t = Math.Floor(duraction - currentPosition);
                buttonTimerTemp.Text = FormatSecondsFormtHours(Convert.ToInt32(t));

                    
            }
            catch {

            }
        }

        private string FormatSecondsFormtHours(int seconds) {
            
            int hours = seconds / 3600;
            int mins = (seconds % 3600) / 60;
            seconds = seconds % 60;
            return string.Format("{0:D2}:{1:D2}:{2:D2}", hours, mins, seconds);

        }

        private void ButtonPlay_Click(object sender, EventArgs e) {
            Play(axWindowsMediaPlayer1);
        }

        private void OnTimedEvent(object sender, EventArgs e) {
            TimerEventProcessor();
        }

        private void WindowMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e) {
            if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
                this.buttonPlayPause.Image = Properties.Resources.image_play;
        }
    }
}
