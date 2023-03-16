using BusinessObjects.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PropertyProfileDAO
    {
        private readonly PRN231PE_FA22_StudentCodeContext _context;

        public static void SavePropertyProfile(PropertyProfile p)
        {
            try
            {
                using (var context = new PRN231PE_FA22_StudentCodeContext())
                {
                    context.PropertyProfiles.Add(p);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void DeleteProduct(int p)
        {
            try
            {
                using (var context = new PRN231PE_FA22_StudentCodeContext())
                {
                    var p1 = context.PropertyProfiles.SingleOrDefault(x => x.PropertyProfileID == p);
                    context.PropertyProfiles.Remove(p1);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void UpdateProduct(PropertyProfile p)
        {
            try
            {
                using (var context = new PRN231PE_FA22_StudentCodeContext())
                {
                    context.Entry<PropertyProfile>(p).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //public async Task<IEnumerable> GetProduct()
        //{
        //    return await _context.PropertyProfiles.ToList();
        //}
    }
}
