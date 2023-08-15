using hm4_solid.Interfaces;

namespace hm4_solid
{
    // LCP - Принцип подстановки Лисков, вместо класса RandomChanged мы можем использовать класс RandomNumber, от которого унаследован класс RandomChanged
    public class RandomNumber : IRandom
    {

        private readonly RandomChanged _rnd = new();

        public int Next(int from, int to)
        {

            return _rnd.Next(from, to);

        }
    }
}
