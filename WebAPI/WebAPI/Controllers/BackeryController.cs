using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class BackeryController : ControllerBase
    {
        //TODO: логирование
        private readonly ILogger<BackeryController> _logger;
        private readonly IBackeryService _backeryService;
        private readonly IMapper _mapper;

        public BackeryController(ILogger<BackeryController> logger, IBackeryService backeryService, IMapper mapper)
        {
            _logger = logger;
            _backeryService = backeryService;
            _mapper = mapper;

        }

        [HttpPost]
        [Route("createbackeryitems")]
        [Consumes("application/json")]
        public async Task<IEnumerable<BackeryItem>> CreateBackeryItems([FromBody]int count)
        {
            return _mapper.Map<ICollection<BackeryItem>>(await _backeryService.CreateItems(count));
        }

        [HttpGet]
        [Route("getbackeryitems")]
        public async Task<IEnumerable<BackeryItem>> GetBackeryItems()
        {
            return _mapper.Map<ICollection<BackeryItem>>(await _backeryService.GetAllItems());
        }
    }
}
