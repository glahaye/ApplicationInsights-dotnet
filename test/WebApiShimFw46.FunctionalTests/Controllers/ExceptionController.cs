﻿using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;

namespace SampleWebAPIIntegration.Controllers
{
    [Route("api/[controller]")]
    public class ExceptionController : Controller
    {
        // GET: api/exception
        [HttpGet]
        public IEnumerable<string> Get()
        {
            throw new InvalidOperationException();
        }
    }
}
