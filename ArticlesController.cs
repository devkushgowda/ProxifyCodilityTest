//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System;

//namespace WebApplication1.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class ArticlesController : ControllerBase
//    {
//        private IRepository _repository;

//        public ArticlesController(IRepository repository)
//        {
//            // Console.WriteLine("Sample debug output");
//            _repository = repository;
//        }


//        [HttpPost]
//        [ProducesResponseType(StatusCodes.Status201Created)]
//        [ProducesResponseType((int)StatusCodes.Status400BadRequest)]
//        public ActionResult CreateArticle([FromBody] Article article)
//        {
//            try
//            {
//                article.Id = _repository.Create(article);
//                return new CreatedResult($"api/articles/{article.Id}", article);
//            }
//            //To be logged and also should be handling all the exceptions seperatly.
//            catch (Exception)
//            {
//                return BadRequest();
//            }
//        }

//        [HttpGet]
//        [Route("{id}")]
//        [ProducesResponseType((int)StatusCodes.Status200OK)]
//        [ProducesResponseType((int)StatusCodes.Status400BadRequest)]
//        public ActionResult GetArticleById(Guid id)
//        {
//            var article = _repository.Get(id);
//            if (article == null)
//                return NotFound("Article not found.");
//            else
//                return Ok(article);
//        }

//        [HttpPut]
//        [Route("{id}")]
//        [ProducesResponseType((int)StatusCodes.Status200OK)]
//        [ProducesResponseType((int)StatusCodes.Status400BadRequest)]
//        [ProducesResponseType((int)StatusCodes.Status404NotFound)]
//        public ActionResult UpdateAtricle(Guid id, [FromBody] Article article)
//        {
//            try
//            {
//                article.Id = id;
//                var articleToUpdate = _repository.Get(id);
//                if (articleToUpdate != null)
//                {
//                    var updated = _repository.Update(article);
//                    if (updated)
//                        return Ok();
//                    else
//                        return BadRequest();
//                }
//                else
//                {
//                    return NotFound("Article not found.");
//                }
//            }
//            //To be logged and also should be handling all the exceptions seperatly.
//            catch (Exception)
//            {
//                return BadRequest();
//            }

//        }

//        [HttpDelete]
//        [Route("{id}")]
//        [ProducesResponseType((int)StatusCodes.Status200OK)]
//        [ProducesResponseType((int)StatusCodes.Status404NotFound)]
//        public ActionResult DeleteAtricle(Guid id)
//        {
//            var deleted = _repository.Delete(id);
//            if (deleted)
//            {
//                return Ok();
//            }
//            else
//            {
//                return NotFound("Article not found.");
//            }
//        }
//    }

//    public interface IRepository
//    {
//        // Returns a found article or null.
//        Article Get(Guid id);
//        // Creates a new article and returns its identifier.
//        // Throws an exception if a article is null.
//        // Throws an exception if a title is null or empty.
//        Guid Create(Article article);
//        // Returns true if an article was deleted or false if it was not possible to find it.
//        bool Delete(Guid id);
//        // Returns true if an article was updated or false if it was not possible to find it.
//        // Throws an exception if an articleToUpdate is null.
//        // Throws an exception or if a title is null or empty.
//        bool Update(Article articleToUpdate);
//    }

//    public class Article
//    {
//        public Guid Id { get; set; }
//        public string Title { get; set; }
//        public string Text { get; set; }
//    }
//}



