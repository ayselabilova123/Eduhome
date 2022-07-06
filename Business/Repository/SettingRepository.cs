using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Repository
{
    public class SettingRepository :
    {
        private readonly AppDbContext _context;
        public SettingRepository(AppDbContext context)
        {
            _context = context;
        }
       public async Task <Setting> Get(string key)
        {
            var data = _context.Setting.AsEnumurable().ToDictionary(n => n.Key, n => n.Value)[key];

        }
    }
}
