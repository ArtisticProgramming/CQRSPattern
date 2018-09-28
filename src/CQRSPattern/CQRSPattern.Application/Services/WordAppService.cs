using AutoMapper;
using CQRSPattern.Application.Interfaces;
using CQRSPattern.Application.ViewModel;
using CQRSPattern.Domain.Commands;
using CQRSPattern.Domain.Commands.Word;
using CQRSPattern.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSPattern.Application.Services
{
    public class WordAppService : IWordAppService
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler Bus;

        public WordAppService(IMapper mapper, IMediatorHandler bus)
        {
            _mapper = mapper;
            Bus = bus;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WordViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public WordViewModel GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Register(WordViewModel wordViewModel)
        {
            var registerCommand = _mapper.Map<RegisterNewWordCommand>(wordViewModel);
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(WordViewModel customerViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
