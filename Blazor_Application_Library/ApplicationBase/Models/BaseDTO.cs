using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Application_Library.ApplicationBase.Models
{
    public interface IBaseDTO<TKey>
    {
        TKey ID { get; set; }
    }
    public class BaseDTO<T> : IBaseDTO<T>
    {
        public T ID { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class BaseDTO : BaseDTO<long>
    {

    }
}
