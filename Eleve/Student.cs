using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleve
{
    public class Student
    {
        private string name;
        private Boolean isCapt;
        private List<int> listOfChoices = null;
        
        public Student(string name, Boolean isCapt, List<int> listOfChoices)
        {
            this.name = name;
            this.isCapt = isCapt;
            this.listOfChoices = listOfChoices;
        }

        public string Name
        {
            get { return this.name; }
        }
        public Boolean IsCapt
        {
            get { return this.isCapt; }
        }
        public List<int> ListOfChoices
        {
            get { return this.listOfChoices; }
        }
    }
}