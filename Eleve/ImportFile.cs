using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleve
{
    class ImportFile
    {
        public string ReadFile()
        {
            string fileName = null;
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "C:\\";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog1.FileName;
                }
            }
            //verifier les ;
            //verifier que chaque nom est unique
            if (fileName != null)
            {
                //Do something with the file, for example read text from it
                string texte = File.ReadAllText(fileName);
                return fileName;
            }
            throw new Exception("Error");
        }
    }
}