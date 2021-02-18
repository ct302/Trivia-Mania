using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trivia_App.Services
{
    public static class ShuffleService
    {
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> source)
        {
            Random rnd = new Random();
            return source.OrderBy((item) => rnd.Next());
        }
    }
}
