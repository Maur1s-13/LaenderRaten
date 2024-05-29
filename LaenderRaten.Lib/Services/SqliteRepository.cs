using LaenderRaten.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaenderRaten.Lib.Services;

public class SqliteRepository
{

    private string _path;

    public SqliteRepository(string path)
    {
        _path = path;
    }

    public bool Add (Land land)
    {

        try
        {
            using (var context = new MyDbContext(_path))
            {
                context.Add(land);
                context.SaveChanges();
            }
            return true;
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message);
            return false;
        }
       
    }

}
