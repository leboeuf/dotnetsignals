﻿using Microsoft.EntityFrameworkCore;
using System;

namespace Stories.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder RegisterEntityMapping<TEntity, TMapping>(this ModelBuilder builder)
        where TMapping : IEntityTypeConfiguration<TEntity>
        where TEntity : class
        {
            var mapper = (IEntityTypeConfiguration<TEntity>)Activator.CreateInstance(typeof(TMapping));
            mapper.Configure(builder.Entity<TEntity>());
            return builder;
        }
    }
}
