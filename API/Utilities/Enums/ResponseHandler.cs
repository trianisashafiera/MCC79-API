﻿using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace API.Utilities.Enums
{
    public class ResponseHandler<TEntity>
    {
        public int Code { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public TEntity Data { get; set; }
    }
}
