using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ConventionPractice.Data;
using GeneratorData.Services.JsonReaderServices;
using Microsoft.Extensions.DependencyInjection;

namespace GeneratorData.Helpers.Constaints
{
    public static class Globals
    {
        public static MapperConfiguration config;
        public static ServiceProvider serviceProvider;
        public static ApplicationDbContext context;
        // public static IJsonReader<T> jsonReaderAddress;
        // public static IJsonReader<T> jsonReaderCourse;
        // public static IJsonReader<T> jsonReaderName;
    }
}