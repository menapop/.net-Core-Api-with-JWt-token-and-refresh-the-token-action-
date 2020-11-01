using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APITest.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public EmployeeController(ApplicationContext context)
        {
            _context = context;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public ActionResult<IEnumerable<employee>> Get()
        {
            return _context.Employees.ToList();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public ActionResult<employee> Get(int id)
        {
            return _context.Employees.Where(e => e.id == id).FirstOrDefault();
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult <employee> Post([FromBody] employee Emp)
        {
            var res = _context.Employees.Add(Emp);
            _context.SaveChanges();
            return res.Entity;
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult<employee> Put(int id, [FromBody] employee Emp)
        {
            if (id != Emp.id)
                return BadRequest();

            var res = _context.Employees.Update(Emp);
            _context.SaveChanges();
            return res.Entity;
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult< bool> Delete(int id)
        {
            var emp= _context.Employees.Where(e => e.id == id).FirstOrDefault();
            if (emp == null)
                return BadRequest();
            _context.Employees.Remove(emp);
            _context.SaveChanges();
            return true;
        }
    }
}
