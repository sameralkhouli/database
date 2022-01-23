using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Uppgift.Data;

namespace Uppgift.Views
{
    internal interface ICustomerService
    {
        internal class CustomerService : ICustomerService
        {
            private readonly SqlContext _context = new();

            
        }
    }
}