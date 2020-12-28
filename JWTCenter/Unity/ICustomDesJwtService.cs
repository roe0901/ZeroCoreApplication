using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTCenter.Unity
{
    public interface ICustomDesJwtService
    {
        public string GetToken(string Name);
    }
}
