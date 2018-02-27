﻿using Data.Repository;
using Domain.Entity;
using MyReports.Data.Infrastracture;
using MyReports.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repository
{
   public class AlerteRepository : RepositoryBase<Alerte>, IAlerteRepository
    {
        public AlerteRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
}
