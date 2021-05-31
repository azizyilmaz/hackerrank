using System;
using System.Collections.Generic;

namespace InFlightMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(foo(110, new List<int> { 6, 20, 70, 90, 30, 60, 110 })); ;
        }

        public static List<int> foo(int flightDuration, List<int> movieDuration)
        {
            flightDuration -= 30;
            List<int> _outputMovie = new List<int>();
            _outputMovie.Add(-1);
            _outputMovie.Add(-1);

            int _movieCounter = movieDuration.Count;
            if (movieDuration != null && _movieCounter > 0)
            {
                int[,] _inputMovie = new int[_movieCounter, 2];
                for (int i = 0; i < _movieCounter; i++)
                {
                    _inputMovie[i, 0] = movieDuration[i];
                    _inputMovie[i, 1] = i;
                }
                // sort
                int _temp, _indexTemp;
                for (int i = 0; i < movieDuration.Count - 1; i++)
                {
                    for (int j = i + 1; j < movieDuration.Count; j++)
                    {
                        if (movieDuration[i] > movieDuration[j])
                        {
                            _temp = _inputMovie[i, 0];
                            _indexTemp = _inputMovie[i, 1];
                            _inputMovie[i, 0] = _inputMovie[j, 0];
                            _inputMovie[i, 1] = _inputMovie[j, 1];
                            _inputMovie[j, 0] = _temp;
                            _inputMovie[j, 1] = _indexTemp;
                        }
                    }
                }
                int _j = 0;
                int _movieIndex = _movieCounter - 1;
                int _max = 0;
                while (_j < _movieIndex)
                {
                    if (_inputMovie[_j, 0] + _inputMovie[_movieIndex, 0] > flightDuration)
                        _movieIndex--;
                    else
                    {
                        if (_inputMovie[_j, 0] + _inputMovie[_movieIndex, 0] > _max)
                        {
                            _max = _inputMovie[_j, 0] + _inputMovie[_movieIndex, 0];
                            _outputMovie[0] = _inputMovie[_j, 1];
                            _outputMovie[1] = _inputMovie[_movieIndex, 1];
                        }
                        _j++;
                    }
                }
            }
            return _outputMovie;
        }
    }
}
