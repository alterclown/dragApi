using DragDropApi.DragDropContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DragDropApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DragDropController : ControllerBase
    {
        private readonly DragContext _context;
        public DragDropController(DragContext context)
        {
            _context = context;

        }

        [HttpGet]
        [Route("GetMoveItem")]
        public async Task<IActionResult> GetMoveItemList()
        {

            try
            {
                var response =  await _context.MoveItems.ToListAsync();
                if (response != null)
                {
                    return Ok(response);
                }
                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        [HttpGet]
        [Route("GetTransferItem")]
        public async Task<IActionResult> GetTransferItemList()
        {
            try
            {
                var response = await _context.TransferItems.ToListAsync();
                if (response != null)
                {
                    return Ok(response);
                }
                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
