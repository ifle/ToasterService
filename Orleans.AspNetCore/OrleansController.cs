﻿using Microsoft.AspNetCore.Mvc;
using System;

namespace Orleans.AspNetCore
{
    public abstract class OrleansController<TStatelessWorkerController> : Controller where TStatelessWorkerController : IGrainWithGuidKey
    {
        protected TStatelessWorkerController ControllerGrain { get; private set; }

        public OrleansController()
        {
            ControllerGrain = GrainClient.GrainFactory.GetGrain<TStatelessWorkerController>(Guid.Empty);
        }
    }
}
