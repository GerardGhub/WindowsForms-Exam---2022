using AutoSproc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Interfaces
{

    public interface IStoredProcedures : ISprocBase
    {

        DataSet sp_getMajorTables(string eTableName);


            DataSet sp_region(int Id,
            string Name,
            string mode);

            DataSet sp_branch(int Id,
            string Name,
            int RegionId,
            string mode);



    }
}
