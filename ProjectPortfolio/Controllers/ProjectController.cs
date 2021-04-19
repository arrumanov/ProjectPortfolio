using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using ProjectPortfolio.Data;

namespace ProjectPortfolio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {

        private readonly ILogger<ProjectController> _logger;
        private readonly ProjectPortfolioDbContext _dbContext;

        public ProjectController(ILogger<ProjectController> logger, ProjectPortfolioDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<Project> Get()
        {
            return _dbContext.Projects.ToList();
        }

        [HttpPost]
        public Project AddProject([FromBody] Project project)
        {
            project.CreatedDate = DateTime.Today;
            _dbContext.Add(project);
            _dbContext.SaveChanges();
            return project;
        }
    }
}
