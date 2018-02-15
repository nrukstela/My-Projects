using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Branch
    {
        public List<Branch> Branches { get; set; }
        
        public Branch()
        {
            Branches = new List<Branch>();
        }
        
        public static int GetDepth(Branch branch)
        {
            int depth = 0;
            foreach (Branch node in branch.Branches)
            {
                int tmp = GetDepth(node);
                if (tmp > depth)
                {
                    depth = tmp;
                }
            }
            depth++;
            return depth;
        }
    }
}
