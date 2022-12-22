using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Classes;
using WindowsFormsApp4.Interfaces;

namespace WindowsFormsApp4.Repository
{
    internal class BranchRepository : IBrandRepository
    {
        public int TotalRecords { get; set; }
        public DataSet dSet = new DataSet();
        IStoredProcedures objStorProc = null;

        public StoredProcedures g_objStoredProc = new StoredProcedures();
        public void GetBranch(string Mode)
        {
            this.objStorProc = g_objStoredProc.GetCollections();
            this.dSet.Clear();
            this.dSet = objStorProc.sp_getMajorTables(Mode);
        }
    }
}
