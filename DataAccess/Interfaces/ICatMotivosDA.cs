using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Interfaces
{
    public interface ICatMotivosDA
    {
        public bool Create(catMotivos motives);
        public bool Delete(catMotivos motives);
        public bool Update(catMotivos motives);
        public List<catMotivos> Select(int? Id);
    }
}
