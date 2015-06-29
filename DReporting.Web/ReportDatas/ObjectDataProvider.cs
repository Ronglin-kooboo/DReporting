﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.Composition;
using System.Linq;
using DReporting.Core;
using DevExpress.DataAccess.ObjectBinding;

namespace DReporting.Web.ReportDatas
{
    [Export("Reporting.ObjectDataProvider", typeof(IDataProvider))]
    public class ObjectDataProvider : IDataProvider
    {
        public string DataProviderName
        {
            get { return "ObjectProvider"; }
        }

        public object GetDataSource(NameValueCollection args, bool designTime)
        {
            var users = new UserCollection();
            users.Add(new User
            {
                FirstName = "Ronglin",
                LastName = "Chen",
                Role = new Role { Group = "Yaitoo" },
                Roles = new RoleCollection { new Role { Group = "Yaitoo" } },
            });


            var ds = new ObjectDataSource();

            ds.DataSource = users;

            ds.Fill();

            return ds;
        }
    }

    public class UserCollection : List<User>
    {
    }

    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Role Role { get; set; }

        public RoleCollection Roles { get; set; }
    }

    public class RoleCollection : List<Role>
    {
    }

    public class Role
    {
        public string Group { get; set; }
    }
}