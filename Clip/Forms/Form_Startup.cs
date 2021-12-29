using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clip.Forms
{
    public partial class Form_Startup : Form
    {
        private ClipboardListener clipboardListener { get; set; }
        public Form_Startup()
        {
            InitializeComponent();
            clipboardListener = new ClipboardListener(this);
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {

            if (Clipboard.ContainsText())
            {
                Console.WriteLine(Clipboard.GetText());
            }
            if (Clipboard.ContainsFileDropList())
            {
                List<string> listClipboardContents = new List<string>();
                foreach (string filePath in Clipboard.GetFileDropList())
                {
                    listClipboardContents.Add(filePath);
                }
                foreach (string clipboardContent in listClipboardContents)
                {
                    Clipboard.SetText(clipboardContent);
                }

                Console.WriteLine(Clipboard.GetText());
                //Bitmap bitmap = new Bitmap(Clipboard.GetText());
            }
        }

        private void StartupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
