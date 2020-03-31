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
    [Route("api/v{version:apiVersion}/sabores")]
    public class SaborController : MainController
    {
        private readonly ISaborRepository _saborRepository;
        private readonly ISaborService _saborService;
        private readonly IMapper _mapper;

        public SaborController(INotificador notificador,
                                  ISaborRepository saborRepository,
                                  ISaborService saborService,
                                  IMapper mapper,
                                  IUser user) : base(notificador, user)
        {
            _saborRepository = saborRepository;
            _saborService = saborService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<SaborViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<SaborViewModel>>(await _saborRepository.ObterSaboresDisponiveis());
        }
    }
}