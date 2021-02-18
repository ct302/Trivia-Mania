using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trivia_App.Data
{
    public class Trivia_Categories
    {
        public Categories[] Trivia_categories { get; set; }

        public class Categories
        {
            public int Id { get; set; }
            public string Name { get; set; }


        }

    }
}
