using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Infrastructure.IoC
{
    public interface IFactory
    {
        T Get<T>();

        T Get<T>(object unitOfWork);
    }
}
