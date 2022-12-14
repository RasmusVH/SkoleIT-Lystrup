using System.Diagnostics;
using System.Windows.Forms;


namespace APBLauncherRemake
{
    public partial class MainWindow : Form
    {
        public MainWindow()

        {


            InitializeComponent();
            Clock.Start();
            folderPath.AutoSize = true;
            applyConfig.Visible = false;



        }
        string contactmsg = "Discord: Entrave#0001 \nSteamID: Entraver \nIngame: Kap & kteniya";

        public void selectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            folderPath.Visible = false;

            if (result == DialogResult.OK)
            {
                folderPath.Visible = true;
                folderPath.Text = fbd.SelectedPath;
                applyConfig.Visible = true;


                Environment.SpecialFolder root = fbd.RootFolder;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void information_Click(object sender, EventArgs e)
        {


            MessageBox.Show("This is just a test of a APB Launcher. \nHopefully it'll be working soon enough.");

        }

        private void startAPB_Click(object sender, EventArgs e)
        {

        }

        private void apbPOP_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.FileName = "https://will.io/apb/";
            myProcess.Start();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            clockMainTimer.Text = DateTime.Now.ToString("HH:mm");
            DayLabel.Text = DateTime.Now.ToString("MMM dd yyyy");
            weekdayLabel.Text = DateTime.Now.ToString("dddd");
        }

        private void contactLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(contactmsg);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process advLauncher = new Process();
            advLauncher.StartInfo.UseShellExecute = true;
            advLauncher.StartInfo.FileName = "https://apb.zone/Advanced%20APB%20Launcher.zip";
            advLauncher.Start();
        }

        private void browseConfigsButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}