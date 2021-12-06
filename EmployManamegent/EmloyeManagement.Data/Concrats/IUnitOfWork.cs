using System;
using System.Collections.Generic;
using System.Text;

namespace EmloyeManagement.Data.Concrats
{
  public interface IUnitOfWork:IDisposable
  {
      void Save();
  }
}
