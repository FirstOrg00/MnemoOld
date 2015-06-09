using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoTricks
{
    public partial class SubmitLoci : Form
    {
        public SubmitLoci(int rightAnswers, string time, string ver1, string ver2)
        {
            InitializeComponent();
            submitLabel1.Text = "Ati raspuns corect la " + rightAnswers + " din 20 intr-un timp de " + time + " .";
            submitLabel2.Text = ver1;
            submitLabel3.Text = ver2;
        }

        

        private void retryButton_Click(object sender, EventArgs e)
        {
            //this.Close();
            TestLoci testLociForm = new TestLoci();

            this.Hide();
            
            testLociForm.StartPosition = FormStartPosition.Manual;
            testLociForm.Location = new Point(this.Location.X - 150, this.Location.Y);
            testLociForm.ShowDialog();
            this.Close();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
