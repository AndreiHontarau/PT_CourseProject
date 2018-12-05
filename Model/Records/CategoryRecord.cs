using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Records
{
    public class CategoryRecord : Record
    {
        public string name { get; private set; }
        public string symbolicCode { get; private set; }
        public int amountOfMovies { get; private set;  }

        public CategoryRecord(string name, string symbolicCode, int amountOfMovies)
        {
            this.name = name;
            this.symbolicCode = symbolicCode;
            this.amountOfMovies = amountOfMovies;
        }

        public CategoryRecord(string name, int amountOfMovies)
        {
            this.name = name;
            this.amountOfMovies = amountOfMovies;
        }
    }
}