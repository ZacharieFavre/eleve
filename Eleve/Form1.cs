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
        List<Student> studentList = new List<Student>();

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

            foreach (var line in File.ReadLines(valeurCSV))
            {
                var values = line.Split(';');
                string name = values[0];
                Boolean role = values[1] == "1" ? true : false;
                List<int> listOfChoices = new List<int>();
                int i = 0;
                foreach (string val in values)
                {
                    if (i != 0 && i != 1)
                    {
                        listOfChoices.Add(Convert.ToInt16(val));
                    }
                    i++;
                }
                studentList.Add(new Student(name, role, listOfChoices));
            }
            foreach (var el in studentList)
            {
                lstGroupe.Items.Add(el);
            }
        }

    }
}
