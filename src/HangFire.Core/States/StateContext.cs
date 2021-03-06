﻿// This file is part of HangFire.
// Copyright © 2013-2014 Sergey Odinokov.
// 
// HangFire is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as 
// published by the Free Software Foundation, either version 3 
// of the License, or any later version.
// 
// HangFire is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public 
// License along with HangFire. If not, see <http://www.gnu.org/licenses/>.

using System;
using HangFire.Common;
using HangFire.Storage;

namespace HangFire.States
{
    public class StateContext
    {
        public StateContext(string jobId, Job job, DateTime createdAt, IStorageConnection connection)
        {
            if (connection == null) throw new ArgumentNullException("connection");
            if (String.IsNullOrEmpty(jobId)) throw new ArgumentNullException("jobId");
            
            JobId = jobId;
            Job = job;
            CreatedAt = createdAt;

            Connection = connection;
        }

        internal StateContext(StateContext context)
            : this(context.JobId, context.Job, context.CreatedAt, context.Connection)
        {
        }

        public string JobId { get; private set; }
        public Job Job { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public IStorageConnection Connection { get; private set; }
    }
}