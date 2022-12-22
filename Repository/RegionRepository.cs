using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.Classes;
using WindowsFormsApp4.Interfaces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp4.Repository
{

    internal class RegionRepository : IRegionRepository
    {
        public DataSet dSet = new DataSet();
        IStoredProcedures objStorProc = null;
        public StoredProcedures g_objStoredProc = new StoredProcedures();
        public void CheckDataifExist(string Region)
        {
       this.objStorProc = g_objStoredProc.GetCollections();
            this.dSet.Clear();
            this.dSet = objStorProc.sp_region(0,
            Region,
            "getbyname");

        }

  
    }
}
