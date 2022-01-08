using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Application.Interfaces;
using Template.Application.ViewModels;
using Template.Domain.Entities;
using Template.Domain.Interfaces;

namespace Template.Application.Services
{
    public class AnuncioService : IAnuncioService
    {
        private readonly IAnuncioRepository _anuncioRepository;
        private readonly IMapper _mapper;

        public AnuncioService(IAnuncioRepository anuncioRepository, IMapper mapper)
        {
            _anuncioRepository = anuncioRepository;
            _mapper = mapper;
        }

        public bool Delete(int Id)
        {
            Anuncio anuncio = _anuncioRepository.Find(x => x.ID == Id);
            if (anuncio == null)
                throw new Exception("Id de Anúncio não encontrado");

            return _anuncioRepository.Delete(anuncio);
        }

        public List<AnuncioViewModel> Get()
        {
            return _mapper.Map<List<AnuncioViewModel>>(_anuncioRepository.GetAll());
        }

        public AnuncioViewModel GetbyId(int Id)
        {
            return _mapper.Map<AnuncioViewModel>(_anuncioRepository.Find(x => x.ID == Id));
        }

        public AnuncioViewModel Post(AnuncioViewModel anuncio)
        {
            return _mapper.Map<AnuncioViewModel>(_anuncioRepository.Create(_mapper.Map<Anuncio>(anuncio)));
        }

        public bool Put(AnuncioViewModel anuncio)
        {
            return _anuncioRepository.Update(_mapper.Map<Anuncio>(anuncio));
        }
    }
}
