using CleanTemplate.Application.Common.Interfaces;
using System;

namespace CleanTemplate.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
