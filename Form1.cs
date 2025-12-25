namespace TriimAudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            try
            {
                audiohelp.WavFileUtils.TrimWavFile(@"c:\temp\bettywork\betty_blue_work.wav", @"c:\temp\bettywork\betty_blue_work22.wav", TimeSpan.FromSeconds(15), TimeSpan.FromSeconds(15));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);    
            }
        }
    }
}
