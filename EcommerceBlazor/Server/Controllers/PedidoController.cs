﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<PedidoOverviewResponse>>>> GetPedidos()
        {
            var resultado = await _pedidoService.GetPedidos();
            return Ok(resultado);
        }

        [HttpGet("{pedidoId}")]
        public async Task<ActionResult<ServiceResponse<PedidoDetalhesResponse>>> GetDetalhesPedidos(int pedidoId)
        {
            var resultado = await _pedidoService.GetDetalhesPedido(pedidoId);
            return Ok(resultado);
        }
    }
}
