using System;
using System.Collections.Generic;
using cSharpGregsList.DB;
using cSharpGregsList.Models;
using cSharpGregsList.Services;
using Microsoft.AspNetCore.Mvc;

namespace cSharpGregsList.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CarsController : ControllerBase
  {
    private readonly CarsService _service;
    public CarsController(CarsService service)
    {
      _service = service;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Car>> GetAll()
    {
      try
      {
        return Ok(FakeDb.Cars);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<Car> GetById(string id)
    {
      try
      {
        Car found = _service.GetById(id);
        return Ok(found);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car newCar)
    {
      try
      {
        Car car = _service.Create(newCar);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Car> EditById(Car editedCar, string id)
    {
      try
      {
        editedCar.Id = id;
        Car car = _service.EditById(editedCar);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<Car> DeleteById(string id)
    {
      try
      {
        _service.DeleteById(id);
        return Ok("Deleted Car Successfully");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}