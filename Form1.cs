using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASodium;
using System.IO;

namespace UnicodePasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetEnvironmentVariableHelper.SetEnvironmentVariable();
        }

        private void UnicodeFolderChooserBTN_Click(object sender, EventArgs e)
        {
            UnicodeFolderChooser.ShowDialog();
        }

        private void GenerateUnicodePasswordBTN_Click(object sender, EventArgs e)
        {
            if(UnicodeFolderChooser.SelectedPath!=null && UnicodeFolderChooser.SelectedPath != "") 
            {
                String FolderPath = "";
                int FolderFilesLength = 0;
                String[] FolderFileNames = new String[] { };
                String[] FileContents = new String[] { };
                String Base64FileContent = "";
                Byte[] FileContentByte = new Byte[] { };
                String FileContent = "";
                int FileContentsLength = 0;
                int DiceNumber = 0;
                int FileContentDiceNumber = 0;
                FolderPath = UnicodeFolderChooser.SelectedPath;
                FolderFilesLength = Directory.GetFiles(FolderPath).Length;
                FolderFileNames = Directory.GetFiles(FolderPath);
                DiceNumber = (int)SodiumRNG.GetUniformUpperBoundRandomNumber((uint)FolderFilesLength);
                FileContents = File.ReadAllLines(FolderFileNames[DiceNumber]);
                FileContentsLength = FileContents.Length;
                FileContentDiceNumber = (int)SodiumRNG.GetUniformUpperBoundRandomNumber((uint)FileContentsLength);
                Base64FileContent = FileContents[FileContentDiceNumber];
                FileContentByte = Convert.FromBase64String(Base64FileContent);
                FileContent = Encoding.UTF8.GetString(FileContentByte);
                UnicodePasswordTB.Text = FileContent;
            }
        }
    }
}
