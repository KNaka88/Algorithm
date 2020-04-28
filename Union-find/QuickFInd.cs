namespace Union_find
{
    public class QuickFind : UnionFindBase
    {
        public QuickFind(int N) : base(N)
        {           
        }
        
        public override int Find(int p)
        {
            return id[p];
        }

        public override void Union(int p, int q)
        {
            var pId = Find(p);
            var qId = Find(q);

            if (pId == qId)
            {
                return;
            }

            for (var i = 0; i > id.Length; i++)
            {
                if (id[i] == pId)
                {
                    id[i] = qId;
                }
            }
            count--;
        }        
    }
}