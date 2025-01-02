using BusinessLayer.Business.Person;
using DataTransferLayer.Objects;
using DataTransferLayer.OtherObject;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ServiceObject;

namespace ServiceLayer.Controllers
{
    [Route("person")]
    public class PersonController : ControllerBase
    {
        private BusinessPerson _businessPerson = new();
        private readonly SoPerson _so = new();

        [HttpGet("getById/{id}")]
        public ActionResult<SoPerson> getById(Guid id)
        {
            _so.dto = new SoPerson.Response();
            (_so.mo, _so.dto.dtoPerson) = _businessPerson.getById(id);
            return _so;
        }

        [HttpGet("getByDni/{dni}")]
        public ActionResult<SoPerson> getByDni(string dni)
        {
            _so.dto = new SoPerson.Response();
            (_so.mo, _so.dto.dtoPerson) = _businessPerson.getByDni(dni);
            return _so;
        }

        [HttpDelete("delete/{idPerson}")]
        public ActionResult<SoPerson> delete(Guid idPerson) 
        {
            _so.dto = new SoPerson.Response();
            _so.mo = _businessPerson.delete(idPerson);
            return _so;
        }

        [HttpPost]
        [Route("[action]")]
        public ActionResult<SoPerson> insert(PersonDto personDto)
        {
            _so.dto = new SoPerson.Response();
            _so.mo = _businessPerson.insert(personDto);
            return _so;
        }

        [HttpPut]
        [Route("[action]")]
        public ActionResult<SoPerson> update(PersonDto personDto)
        {
            _so.dto = new SoPerson.Response();
            _so.mo = _businessPerson.update(personDto);
            return _so;
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<SoPerson> getall()
        {
            _so.dto = new SoPerson.Response();
            (_so.mo, _so.dto.listPerson) = _businessPerson.getall();
            return _so;
        }

    }
}
