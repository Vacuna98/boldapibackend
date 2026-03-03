using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using boldapibackend.Models.DOT;
using boldapibackend.Services.Context;

namespace boldapibackend.Services
{
    public class UserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        internal bool AddUser(CreateAccountDTO usertoAdd)
        {
            throw new NotImplementedException();
        }
    }
}