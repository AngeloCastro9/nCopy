using nCopy;
using System;
using System.Windows.Forms;

namespace CopiaEmissor
{
    public partial class Ajuda : Form
    {
        public Ajuda()
        {
            InitializeComponent();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var helpUsForm = new HelpUsForm();
            helpUsForm.Closed += (s, args) => this.Close();
            helpUsForm.Show();

        }
    }
}
