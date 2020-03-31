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
    [Route("api/v{version:apiVersion}/adicionais")]
    public class AdicionalController : MainController
    {
        private readonly IAdicionalRepository _adicionalRepository;
        private readonly IAdicionalService _adicionalService;
        private readonly IMapper _mapper;

        public AdicionalController(INotificador notificador,
                                  IAdicionalRepository adicionalRepository,
                                  IAdicionalService adicionalService,
                                  IMapper mapper,
                                  IUser user) : base(notificador, user)
        {
            _adicionalRepository = adicionalRepository;
            _adicionalService = adicionalService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IEnumerable<AdicionalViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<AdicionalViewModel>>(await _adicionalRepository.ObterAdicionaisDisponiveis());
        }
    }
}
