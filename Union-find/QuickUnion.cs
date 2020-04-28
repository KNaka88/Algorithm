namespace Union_find
{
    public class QuickUnion : UnionFindBase
    {
        public QuickUnion(int N) : base(N)
        {            
        }

        public override int Find(int p)
        {
            while (p != id[p])
            {
                p = id[p];
            }
            return p;
        }
        public override void Union(int p, int q)
        {
            var pRoot = Find(p);
            var qRoot = Find(q);

            if (pRoot == qRoot)
            {
                return;
            } 

            id[pRoot] = qRoot;
            count--;
        }
    }
}