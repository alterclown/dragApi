using DragDropApi.DragDropContext;
using DragDropApi.Entities;
using DragDropApi.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
                var response =  await _context.MoveItems.Where(x => x.Status != (int)StatusEnum.Deleted).ToListAsync();
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
                var response = await _context.TransferItems.Where(x => x.Status != (int)StatusEnum.Deleted).ToListAsync();
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

        [HttpPost]
        [Route("SaveTransferItem")]
        public async Task<IActionResult> SaveTransferItemList(List<MoveItem> moveItems)
        {
            try
            {
                 MoveItem move = new MoveItem();
                foreach (var item in moveItems) {
                    move.MoveTitle = item.TransferItemTitle;
                    move.MoveItemIndexId = item.TransferItemIndexId;
                    move.Status = item.Status;
                }
                var response =  _context.MoveItems.AddRangeAsync(move);
                await _context.SaveChangesAsync();
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
