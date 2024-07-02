using AppObjectOlusturucu.Concrete;
using JSGABackend.Business.Abstract.Base;
using JSGABackend.Entity.Abstract;
using JSGABackend.Entity.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Net;

namespace JSGABackend.WebApi.Base.Concrete
{
    [ApiController]
    public class BaseController<TEntity, TIBusiness> : ControllerBase//, IBaseController<TEntity, TIBusiness>
        where TEntity : class, IEntity
        where TIBusiness : class, IBaseForBusiness<TEntity>
    {
        internal TIBusiness _business = null!;

        public BaseController() : base()
        {
            try
            {
                Olusturucu olusturucu = Olusturucu.olustur;
                var result = Olusturucu.olustur.GetObj<TIBusiness>();

                if (result == null)
                    throw new NullReferenceException();

                _business = result;
            }
            catch (Exception)
            {

            }
        }

        [HttpPost()]
        [Route("[controller]/[Action]")]
        public async Task<ActionResult<TEntity>> Add(TEntity entity)
        {
            ActionResult<TEntity> response;
            try
            {
                var result = await this._business.Add(entity);

            
                if (result == null)
                    throw new NullReferenceException();

                if (result.Status)
                    response = Ok(result!.Value!);
                else
                    response = BadRequest(result.Message + "ekleme hata");
            }
            catch (Exception ex)
            {
               response = ValidationProblem(statusCode:((int)HttpStatusCode.NotFound),detail:ex.Message,title:"Error");
            }
            return response!;
        }

        [HttpPost()]
        [Route("[controller]/[Action]")]
        public async Task<ActionResult<bool>> AddList(List<TEntity> entities)
        {
            ActionResult<bool> response;

            try
            {
                if (entities == null || entities.Count <= 0)
                    throw new NullReferenceException();

                var result = await this._business.Add(entities);

                if (!result.Status)
                    response = BadRequest(result.Message);
                else
                    response = Ok(result.Value);
            }
            catch (Exception ex)
            {
                response = ValidationProblem(statusCode: ((int)HttpStatusCode.NotFound), detail: ex.Message, title: "Error");
            }

            return response;
        }


        [HttpGet()]
        [Route("[controller]/[Action]")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            ActionResult<TEntity> response;
            try
            {
                if(id <=0) throw new NullReferenceException();

                var result = await this._business.GetByID(id);

                if (result.Status)
                    response = Ok(result.Value!);
                else
                    response = BadRequest(result.Message);
            }
            catch (Exception ex)
            {
                response = ValidationProblem(statusCode: ((int)HttpStatusCode.NotFound), detail: ex.Message, title: "Error");
            }
            return response;
        }

        [HttpGet()]
        [Route("[controller]/[Action]")]
        public async Task<ActionResult<List<TEntity>>> GetAll()
        {
            ActionResult<List<TEntity>> response;
            try
            {
                var result = await this._business.GetAll();

                if (result.Status)
                    response = Ok(result.Value!);
                else
                    response = BadRequest(result.Message);
            }
            catch (Exception ex)
            {
                response = ValidationProblem(statusCode: ((int)HttpStatusCode.NotFound), detail: ex.Message, title: "Error");
            }
            return response;
        }

        [HttpGet()]
        [Route("[controller]/[Action]")]
        public async Task<ActionResult<int>> GetTotalCount()
        {
            ActionResult<int> response;
            try
            {
                var result = await this._business.GetAllTotalCount();

                if (result.Status)
                    response = Ok(result.Value!);
                else
                    response = BadRequest(result.Message);
            }
            catch (Exception ex)
            {
                response = ValidationProblem(statusCode: ((int)HttpStatusCode.NotFound), detail: ex.Message, title: "Error");
            }
            return response;
        }

        [HttpPost()]
        [Route("[controller]/[Action]")]
        public async Task<ActionResult<bool>> Remove(TEntity entity)
        {
            ActionResult<bool> response;
            try
            {
                if(entity.isNull()||entity.isEmpity())
                    throw new NullReferenceException();

                var result = await this._business.Remove(entity);

                if (result.Status)
                    response = Ok(result.Value!);
                else
                    response = BadRequest(result.Message);
            }
            catch (Exception ex)
            {
                response = ValidationProblem(statusCode: ((int)HttpStatusCode.NotFound), detail: ex.Message, title: "Error");
            }
            return response;
        }

        [HttpPost()]
        [Route("[controller]/[Action]")]
        public async Task<ActionResult<bool>> RemoveById(int Id)
        {
            ActionResult<bool> response;
            try
            {
                if (Id <= 0)
                    throw new NullReferenceException();

                var result = await this._business.Remove(Id);

                if (result.Status)
                    response = Ok(result.Value!);
                else
                    response = BadRequest(result.Message);
            }
            catch (Exception ex)
            {
                response = ValidationProblem(statusCode: ((int)HttpStatusCode.NotFound), detail: ex.Message, title: "Error");
            }
            return response;
        }

        [HttpPost()]
        [Route("[controller]/[Action]")]
        public async Task<ActionResult<TEntity>> Update(TEntity entity)
        {
            ActionResult<TEntity> response;
            try
            {
                if(entity == null || entity.isEmpity()) 
                    throw new ArgumentNullException();
                
                var result = await this._business.Add(entity);


                if (result == null)
                    throw new NullReferenceException();

                if (result.Status)
                    response = Ok(result!.Value);
                else
                    response = BadRequest(result.Message );
            }
            catch (Exception ex)
            {
                response = ValidationProblem(statusCode: ((int)HttpStatusCode.NotFound), detail: ex.Message, title: "Error");
            }
            return response!;
        }

        [HttpPost()]
        [Route("[controller]/[Action]")]
        public async Task<ActionResult<List<TEntity>>> UpdateList(List<TEntity> entity)
        {
            ActionResult<List<TEntity>> response;
            try
            {
                if (entity == null || entity.Count <= 0 || entity.Where(p=>p.isEmpity()).IsNullOrEmpty())
                    throw new ArgumentNullException();

                var result = await this._business.Update(entity);


                if (result == null)
                    throw new NullReferenceException();

                if (result.Status)
                    response = Ok(result!.Value);
                else
                    response = BadRequest(result.Message);
            }
            catch (Exception ex)
            {
                response = ValidationProblem(statusCode: ((int)HttpStatusCode.NotFound), detail: ex.Message, title: "Error");
            }
            return response!;
        }
    }
}
