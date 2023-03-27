using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_EF6_CF_v2.Model
{
    public class Blog
    {

        // Tabela 1

        #region Scalar properties
        public int BlogID { get; set; }     // PK + identity
        public string Name { get; set; }
        #endregion

        #region Navigation properties
        public virtual ICollection<Post> Posts { get; set; }
        #endregion


    }
}
