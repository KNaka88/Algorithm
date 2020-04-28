using System;

namespace Union_find
{
    public abstract class UnionFindBase
    {
        protected int[] id;
        protected int count;

        public UnionFindBase(int N)
        {
            count = N;
            id = new int[N];
            for (int i = 0; i < N; i++)
            {
                id[i] = i;
            }
        }

        public int Count() => count;

        public bool Connected(int p, int q) => Find(p) == Find(q);

        public virtual int Find(int p)
        {
            throw new NotImplementedException();
        }

        public virtual void Union(int p, int q)
        {
            throw new NotImplementedException();
        }       
    }
}