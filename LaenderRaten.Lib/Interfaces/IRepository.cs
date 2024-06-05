using LaenderRaten.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaenderRaten.Lib.Interfaces
{
    public interface IRepository
    {
        public bool Add(Land land);
        public bool Delete(Land land);
        public List<Land> GetAll();

        public bool Update(Land land);
        public Land? Find(int id);
    }
}
