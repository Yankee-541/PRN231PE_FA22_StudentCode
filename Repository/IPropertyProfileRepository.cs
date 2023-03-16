using BusinessObjects.Models;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class IPropertyProfileRepository
    {
        private readonly PRN231PE_FA22_StudentCodeContext _context;
        public void SavePropertyProfile(PropertyProfile p) => PropertyProfileDAO.SavePropertyProfile(p);

        public async Task<IEnumerable> GetAllPropertyProfile()
        {
            return await _context.PropertyProfiles.ToListAsync();
        }

        public void UpdatePropertyProfile(PropertyProfile p) => PropertyProfileDAO.UpdateProduct(p);

        public void DeletePropertyProfile(int p) => PropertyProfileDAO.DeleteProduct(p);
    }
}
