using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERV_T3_E4_Serve
{
    class Record
    {
        private int score;
        private string name;

        public Record()
        {
            score = 0;
            name = "";
        }
        public Record(string name)
        {
            score = 0;
            this.name = name;
        }
        public Record(int score, string name)
        {
            this.score = score;
            this.name = name;
        }
        public int Score
        {
            set
            {
                score = value;
            }
            get
            {
                return score;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
    }
}
