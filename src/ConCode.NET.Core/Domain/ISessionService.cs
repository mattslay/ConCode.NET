﻿using ConCode.NET.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConCode.NET.Core.Domain
{
    public interface ISessionService
    {
        IQueryable<Session> GetSessions();

        void AddSession(Session session);
    }
}
