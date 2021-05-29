using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using SurfersLand.Dtos;
using SurfersLand.Models;

namespace SurfersLand.Controllers.Api
{
    public class BoardsController : ApiController
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public BoardsController()
        {
            _context = new ApplicationDbContext();
            _mapper = MvcApplication.Mapper;
        }

        // GET /api/Boards
        public IEnumerable<BoardDto> GetBoards()
        {
            return _context.Boards.ToList().Select(_mapper.Map<Board, BoardDto>);
        }

        // GET /api/Boards/1
        public IHttpActionResult GetBoard(int id)
        {
            var board = _context.Boards.SingleOrDefault(c => c.Id == id);
            if (board == null)
                return NotFound();

            return Ok(_mapper.Map<Board, BoardDto>(board));
        }
        
        // POST /api/Boards
        [HttpPost]
        public IHttpActionResult CreateBoard(BoardDto boardDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var board = _mapper.Map<BoardDto, Board>(boardDto);
            board.DateAdded = DateTime.Now;
            _context.Boards.Add(board);
            _context.SaveChanges();
            
            return Created(new Uri(Request.RequestUri + "/" + board.Id), _mapper.Map<Board, BoardDto>(board)) ;
        }
        
        // PUT /api/Boards/1
        [HttpPut]
        public void UpdateBoard(int id, BoardDto boardDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var boardInDb = _context.Boards.SingleOrDefault(c => c.Id == id);
            if (boardInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _mapper.Map(boardDto, boardInDb);
            
            _context.SaveChanges();
        }
        
        // DELETE /api/Boards/1
        [HttpDelete]
        public void DeleteBoard(int id)
        {
            var boardInDb = _context.Boards.SingleOrDefault(c => c.Id == id);
            if (boardInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Boards.Remove(boardInDb);
            _context.SaveChanges();
        }
    }
}