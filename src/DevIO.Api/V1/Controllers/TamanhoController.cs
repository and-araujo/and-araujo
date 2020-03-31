using AutoMapper;
using DevIO.Api.Controllers;
using DevIO.Api.ViewModels;
using DevIO.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevIO.Api.V1.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/tamanhos")]
    public class TamanhoController : MainController
    {
        private readonly ITamanhoRepository _tamanhoRepository;
        private readonly ITamanhoService _tamanhoService;
        private readonly IMapper _mapper;

        public TamanhoController(INotificador notificador,
                                  ITamanhoRepository saborRepository,
                                  ITamanhoService saborService,
                                  IMapper mapper,
                                  IUser user) : base(notificador, user)
        {
            _tamanhoRepository = saborRepository;
            _tamanhoService = saborService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<TamanhoViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<TamanhoViewModel>>(await _tamanhoRepository.ObterTamanhosDisponiveis());
        }
    }
}
