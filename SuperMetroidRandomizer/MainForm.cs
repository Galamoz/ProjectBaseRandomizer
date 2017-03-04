using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using SuperMetroidRandomizer.IO;
using SuperMetroidRandomizer.Net;
using SuperMetroidRandomizer.Properties;
using SuperMetroidRandomizer.Random;
using SuperMetroidRandomizer.Rom;

namespace SuperMetroidRandomizer

{


    public partial class MainForm : Form
    {
        private Thread checkUpdateThread;

        public MainForm()
        {
            InitializeSettings();
            InitializeComponent();

        }




        private void InitializeSettings()
        {
            Settings.Default.OutputFileV11 = Settings.Default.OutputFileV11;
            Settings.Default.ControlsShot = Settings.Default.ControlsShot;
            Settings.Default.ControlsJump = Settings.Default.ControlsJump;
            Settings.Default.ControlsDash = Settings.Default.ControlsDash;
            Settings.Default.ControlsItemSelect = Settings.Default.ControlsItemSelect;
            Settings.Default.ControlsItemCancel = Settings.Default.ControlsItemCancel;
            Settings.Default.ControlsAngleUp = Settings.Default.ControlsAngleUp;
            Settings.Default.ControlsAngleDown = Settings.Default.ControlsAngleDown;
            Settings.Default.RandomizerDifficulty = Settings.Default.RandomizerDifficulty;
            Settings.Default.RandoDiff06 = Settings.Default.RandoDiff06;
            Settings.Default.CreateSpoilerLog = Settings.Default.CreateSpoilerLog;
        }

        private void RunCheckUpdate()
        {
            checkUpdateThread = new Thread(RandomizerVersion.CheckUpdate);
            checkUpdateThread.SetApartmentState(ApartmentState.STA);
            checkUpdateThread.Start();
        }

       

       

        private void MainForm_Load(object sender, EventArgs e)
        {
            filenameV11.Text = Settings.Default.OutputFileV11;
            createSpoilerLog.Checked = Settings.Default.CreateSpoilerLog;
            Text = string.Format("Super Metroid: Project Base Randomizer: v1.3", RandomizerVersion.CurrentDisplay);
            randomizerDifficulty.SelectedItem = Settings.Default.RandomizerDifficulty;
            RunCheckUpdate();
        }
       
        		public void CheckBox2Checked(object sender, EventArgs e)
		{

		}
 
    	
    
        private void createV11_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(seedV11.Text))
            {
                SetSeedBasedOnDifficulty();
            }

            ClearOutputV11();
            
            var difficulty = GetRandomizerDifficulty();

            if (difficulty == RandomizerDifficulty.None)
            {
                return;
            }

            CreateRom(difficulty);

            Settings.Default.CreateSpoilerLog = createSpoilerLog.Checked;
            Settings.Default.RandomizerDifficulty = randomizerDifficulty.SelectedItem.ToString();
            Settings.Default.Save();
        }

        private void CreateRom(RandomizerDifficulty difficulty)
        {
            int parsedSeed;
            if (!int.TryParse(seedV11.Text, out parsedSeed))
            {
                MessageBox.Show("Seed must be numeric or blank.", "Seed Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                WriteOutputV11("Seed must be numeric or blank.");
            }
            else
            {
                var romLocations = RomLocationsFactory.GetRomLocations(difficulty);
                RandomizerLog log = null;

                if (createSpoilerLog.Checked)
                {
                    log = new RandomizerLog(string.Format(romLocations.SeedFileString, parsedSeed));
                }

                seedV11.Text = string.Format(romLocations.SeedFileString, parsedSeed);
                var randomizerV11 = new RandomizerV11(parsedSeed, romLocations, log);
                randomizerV11.CreateRom(filenameV11.Text);

                var outputString = new StringBuilder();

                outputString.AppendFormat("Done!{0}{0}{0}Seed: ", Environment.NewLine);
                outputString.AppendFormat(romLocations.SeedFileString, parsedSeed);
                outputString.AppendFormat(" ({0} Difficulty){1}{1}", romLocations.DifficultyName, Environment.NewLine);

                WriteOutputV11(outputString.ToString());
            }
        }

        private void CreateSpoilerLog(RandomizerDifficulty difficulty)
        {
            int parsedSeed;

            if (!int.TryParse(seedV11.Text, out parsedSeed))
            {
                MessageBox.Show("Seed must be numeric or blank.", "Seed Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                WriteOutputV11("Seed must be numeric or blank.");
            }
            else
            {
                var romPlms = RomLocationsFactory.GetRomLocations(difficulty);
                RandomizerLog log = new RandomizerLog(string.Format(romPlms.SeedFileString, parsedSeed));

                seedV11.Text = string.Format(romPlms.SeedFileString, parsedSeed);

                var randomizer = new RandomizerV11(parsedSeed, romPlms, log);
                WriteOutputV11(randomizer.CreateRom(filenameV11.Text, true));
            }
     
	
}
        
        private RandomizerDifficulty GetRandomizerDifficulty()
        {
            RandomizerDifficulty difficulty;

            if (seedV11.Text.ToUpper().Contains("C"))
            {
                randomizerDifficulty.SelectedItem = "Casual";
                seedV11.Text = seedV11.Text.ToUpper().Replace("C", "");
                difficulty = RandomizerDifficulty.Casual;
            }
            else if (seedV11.Text.ToUpper().Contains("S"))
            {
                randomizerDifficulty.SelectedItem = "Speedrunner";
                seedV11.Text = seedV11.Text.ToUpper().Replace("S", "");
                difficulty = RandomizerDifficulty.Speedrunner;
            }
            else if (seedV11.Text.ToUpper().Contains("M"))
            {
                randomizerDifficulty.SelectedItem = "Masochist";
                seedV11.Text = seedV11.Text.ToUpper().Replace("M", "");
                difficulty = RandomizerDifficulty.Masochist;
            }
            //else if (seedV11.Text.ToUpper().Contains("I"))
            //{
            //    randomizerDifficulty.SelectedItem = "Insane";
            //    seedV11.Text = seedV11.Text.ToUpper().Replace("I", "");
            //    difficulty = RandomizerDifficulty.Insane;
            //}
            else
            {
                switch (randomizerDifficulty.SelectedItem.ToString())
                {
                    case "Casual":
                        difficulty = RandomizerDifficulty.Casual;
                        break;
                    case "Speedrunner":
                        difficulty = RandomizerDifficulty.Speedrunner;
                        break;
                    case "Masochist":
                        difficulty = RandomizerDifficulty.Masochist;
                        break;
                    //case "Insane":
                    //    difficulty = RandomizerDifficulty.Insane;
                    //    break;
                    default:
                        MessageBox.Show("Please select a difficulty.", "Select Difficulty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        WriteOutputV11("Please select a difficulty.");
                        return RandomizerDifficulty.None;
                }
            }
            return difficulty;
        }

        private void SetSeedBasedOnDifficulty()
        {
            switch (randomizerDifficulty.SelectedItem.ToString())
            {
                case "Casual":
                    seedV11.Text = string.Format("C{0:0000000}", (new SeedRandom()).Next(10000000));
                    break;
                case "Masochist":
                    seedV11.Text = string.Format("M{0:0000000}", (new SeedRandom()).Next(10000000));
                    break;
                case "Insane":
                    seedV11.Text = string.Format("I{0:0000000}", (new SeedRandom()).Next(10000000));
                    break;
                default:
                    seedV11.Text = string.Format("S{0:0000000}", (new SeedRandom()).Next(10000000));
                    break;
            }
        }

        private void ClearOutputV11()
        {
            outputV11.Text = "";
        }

        private void WriteOutputV11(string text)
        {
            outputV11.Text += text;
        }

        private void browseV11_Click(object sender, EventArgs e)
        {
            var info = new FileInfo(Regex.Replace(filenameV11.Text, "<.*>", ""));
            var saveFileDialog = new SaveFileDialog { Filter = "All files (*.*)|*.*", FilterIndex = 2, RestoreDirectory = true, InitialDirectory = info.DirectoryName, FileName = info.Name };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filenameV11.Text = saveFileDialog.FileName;
                MessageBox.Show("Remember to hit \"create\" to create the rom.", "Remember to create the rom!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void filenameV11_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.OutputFileV11 = filenameV11.Text;
            Settings.Default.Save();
        }

        private void controlsV11_Click(object sender, EventArgs e)
        {
            var controlsDialog = new Controls();
            controlsDialog.ShowDialog();
        }

        private void controls_Click(object sender, EventArgs e)
        {
            var controlsDialog = new Controls();
            controlsDialog.ShowDialog();
        }

        private void filename_Leave(object sender, EventArgs e)
        {
            var senderText = (TextBox) sender;

            if (!senderText.Text.Contains("."))
            {
                senderText.Text += ".sfc";
            }
        }

        private void report_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(null, string.Format("https://docs.google.com/forms/d/e/1FAIpQLSeO3NxPYDnKhpxVoxXrgoTVrFjwvi_HqOGWzw62Vw-ziM2DTg/viewform", RandomizerVersion.CurrentDisplay));
        }

        private void randomSpoiler_Click(object sender, EventArgs e)
        {
            SetSeedBasedOnDifficulty();

            ClearOutputV11();

            var difficulty = GetRandomizerDifficulty();
            CreateSpoilerLog(difficulty);
        }

		void Label3Click(object sender, EventArgs e)
		{
	
		}


			
	
			
			
		
		
	
		
    }
}