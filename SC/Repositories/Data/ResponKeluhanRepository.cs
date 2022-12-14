using Microsoft.EntityFrameworkCore;
using SC.Context;
using SC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SC.Repositories.Data
{
    public class ResponKeluhanRepository
    {
        MyContext myContext;

        public ResponKeluhanRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }

        public List<ResponKeluhan> Get()
        {
            var data = myContext.ResponKeluhans.Include(x => x.Keluhan).ToList();
            return data;
        }

        public ResponKeluhan Get(int id)
        {
            var data = myContext.ResponKeluhans
                       .Include(x => x.Keluhan)
                       .Where(x => x.Id.Equals(id))
                       .FirstOrDefault();
            return data;
        }

        public int Post(ResponKeluhan responKeluhan)
        {
            myContext.ResponKeluhans.Add(responKeluhan);
            var result = myContext.SaveChanges();
            if (result > 0)
                return result;
            return 0;
        }
    }
}
