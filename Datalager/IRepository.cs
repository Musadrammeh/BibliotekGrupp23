using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Modellager;

namespace Datalager
{
    interface IRepository<TEntity> where TEntity : class
    {
    }
}
