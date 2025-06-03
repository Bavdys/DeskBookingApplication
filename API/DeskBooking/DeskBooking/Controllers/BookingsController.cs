using DeskBooking.Application.Dtos.RequestDtos;
using DeskBooking.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DeskBooking.API.Controllers
{
    public class BookingsController : BaseApiController
    {
        private readonly IBookingApplicationService _bookingApplicationService;
        public BookingsController(IBookingApplicationService bookingApplicationService)
        {
            _bookingApplicationService = bookingApplicationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBookings()
        {
            var bookingsResponse = await _bookingApplicationService.GetAllBookings();

            return Ok(bookingsResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookingById([FromRoute] Guid id) 
        {
            var bookingResponse = await _bookingApplicationService.GetBookingById(id);

            return bookingResponse == null ? NotFound() : Ok(bookingResponse); 
        }

        [HttpPost]
        public async Task<IActionResult> CreateBooking([FromBody] CreateBookingRequest createBookingRequest)
        {
            var bookingResponse = await _bookingApplicationService.CreateBooking(createBookingRequest);
            
            return CreatedAtAction(nameof(GetBookingById), new { id = bookingResponse.Id }, bookingResponse);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBooking([FromRoute] Guid id, [FromBody] UpdateBookingRequest updateBookingRequest)
        {
            var bookingResponse = await _bookingApplicationService.UpdateBooking(id, updateBookingRequest);

            return bookingResponse == null ? NotFound() : Ok(bookingResponse); 
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking([FromRoute] Guid id)
        {
            var bookingResponse = await _bookingApplicationService.DeleteBooking(id);

            return bookingResponse == null ? NotFound() : NoContent();
        }
    }
}
