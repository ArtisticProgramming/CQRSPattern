using CQRSPattern.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSPattern.Application.Interfaces
{
    public interface IWordAppService : IDisposable
    {
        void Register(WordViewModel customerViewModel);
        IEnumerable<WordViewModel> GetAll();
        WordViewModel GetById(Guid id);
        void Update(WordViewModel customerViewModel);
        void Remove(Guid id);
    }
}
