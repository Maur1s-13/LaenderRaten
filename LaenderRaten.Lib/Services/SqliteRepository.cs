using LaenderRaten.Lib.Interfaces;
using LaenderRaten.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LaenderRaten.Lib.Services;

public class SqliteRepository : IRepository
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

    public bool Delete(Land land)
    {
        try
        {
            using(var context = new MyDbContext(_path))
            {
                context.Remove(land);
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

    public List<Land> GetAll()
    {
        using(var context = new MyDbContext(_path))
        {
            try
            {
                var countries = context.Countries.FromSql($"SELECT * FROM Countries").ToList();
                context.SaveChanges();

                return countries;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return new List<Land>();
            }
        }
    }

    public Land? Find(int id)
    { 
        using(var context = new MyDbContext(_path))
        {
            try
            {
                var find = (from country in context.Countries
                            where country.Id == id
                            select country).FirstOrDefault(); //erstes Element oder null
                return find;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw;
            }
        }
    }
  

}
