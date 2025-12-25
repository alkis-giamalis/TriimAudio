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
                audiohelp.WavFileUtils.TrimWavFile(@"c:\temp\input.wav", @"c:\temp\output.wav", TimeSpan.FromSeconds(15), TimeSpan.FromSeconds(15));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);    
            }
        }
    }
}
