using Banking.Operation.Transfer.Query.Domain.Tranfers.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Net.Core.Template.Domain.Abstractions.Exceptions;
using Net.Core.Template.Domain.Abstractions.Messages;
using System;
using System.Threading.Tasks;

namespace Banking.Operation.Transfer.Command.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("/v{version:apiVersion}/banking-operation/{clientid}/transfers")]
    [ApiController]
    public class TransferController : Controller
    {
        private readonly ILogger<TransferController> _logger;
        private readonly ITransferService _transferService;

        public TransferController(ILogger<TransferController> logger, ITransferService transferService)
        {
            _logger = logger;
            _transferService = transferService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BussinessMessage), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> GetByClient(Guid clientid)
        {
            _logger.LogInformation("Receive GetByClient...");

            try
            {
                var transfers = await _transferService.GetByClient(clientid);

                return Ok(transfers);
            }
            catch (BusinessException bex)
            {
                return BadRequest(new BussinessMessage(bex.Type, bex.Message));
            }
            catch (Exception ex)
            {
                _logger.LogError($"GetByClient exception: {ex}");
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BussinessMessage), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> GetByClientById(Guid clientid, Guid id)
        {
            _logger.LogInformation("Receive GetByClientById...");

            try
            {
                var transfer = await _transferService.GetByClientById(clientid, id);

                return Ok(transfer);
            }
            catch (BusinessException bex)
            {
                return BadRequest(new BussinessMessage(bex.Type, bex.Message));
            }
            catch (Exception ex)
            {
                _logger.LogError($"GetByClientById exception: {ex}");
                return BadRequest();
            }
        }
    }
}