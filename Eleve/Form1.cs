using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eleve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdDisplayGrp_Click(object sender, EventArgs e)
        {
            ImportFile importFile = new ImportFile();
            string valeurCSV = importFile.ReadFile();

            foreach (var line in File.ReadAllLines(valeurCSV))
            {
                var values = line.Split(';');
            }
        }
    }
}
